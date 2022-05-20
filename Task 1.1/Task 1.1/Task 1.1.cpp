/* Кодирование строки; Ограничение по количеству одинаковых символов = 9,
					   так как string состоит из массива элементов char.*/

#include <iostream>
#include <string>

int main()
{
	std::string str_old;
	std::cout << "Enter the string: ";
	std::getline(std::cin, str_old);

	if (!str_old.empty())
	{
		std::string str_med(str_old.length() * 2, ' ');

		int count = 1;
		int j = 0;
		for (int i = 0; i < str_old.length(); ++i)
		{
			if (str_old[i] != str_old[i + 1])
			{
				str_med[j] = str_old[i];
				str_med[j + 1] = (char)(((int)'0') + count);
				count = 0;
				j += 2;
			}
			++count;
		}

		std::string str_new(j, ' ');

		for (int i = 0; i < j; i++)
			str_new[i] = str_med[i];

		std::cout << "The string after encoding: " << str_new << std::endl;
	}

	return 0;
}
