// Таблица чисел, закрученная в спираль

#include <iostream>

int main()
{
    std::cout << "Enter the number: ";
    int n = 0;
    std::cin >> n;

    int** arr = new int* [n];

    for (int i = 0; i < n; ++i)
        arr[i] = new int[n];

    int num = 1;

	if (n == 1)
		arr[0][0] = 1;

	if (n == 2) 
	{
		arr[0][0] = 1; arr[0][1] = 2;
		arr[1][0] = 3; arr[1][1] = 4;
	}

	if (n > 2)
	{
		for (int delta = 0; delta < n - 2; ++delta)
		{
			for (int i = 0 + delta; i < n - delta; ++i)
			{
				arr[0 + delta][i] = num;
				++num;
			}

			for (int i = 1 + delta; i < n - delta; ++i)
			{
				arr[i][n - 1 - delta] = num;
				++num;
			}

			for (int i = n - 2 - delta; i - delta >= 0; --i)
			{
				arr[n - 1 - delta][i] = num;
				++num;
			}

			for (int i = n - 2 - delta; i - delta > 0; --i)
			{
				arr[i][0 + delta] = num;
				++num;
			}

			if (n == 3) arr[1][1] = 9;
		}
	}
	
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < n; ++j)
            std::cout << arr[i][j] << " ";
        std::cout << std::endl;
    }

    for (int i = 0; i < n; i++)
    {
        delete[] arr[i];
    }

    return 0;
}