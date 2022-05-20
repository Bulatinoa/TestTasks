// ООП

#include "Student.h"
#include <vector>
#include <string>
#include <windows.h>

int countFacul(const std::vector<Student>& vec, const std::string& str)
{
    int count = 0;
    auto it = vec.begin();

    for (int i = 0; i < vec.size() - 1; ++i)
    {
        if (it->getFaculty() == str)
            ++count;
        ++it;
    }

    return count;
}

int countCourse(const std::vector<Student>& vec, const std::string& str)
{
    int count = 0;
    auto it = vec.begin();

    for (int i = 0; i < vec.size() - 1; ++i)
    {
        if (it->getCourse() == str)
            ++count;
        ++it;
    }

    return count;
}

int countDate(const std::vector<Student>& vec, const std::string& str)
{
    int count = 0;
    auto it = vec.begin();

    for (int i = 0; i < vec.size(); ++i)
    {
        std::string old_str1 = std::string(it->getDateOfBirth()); // char in std::string
        std::string new_str1(old_str1, 6, 4);
        int res1 = std::stoi(new_str1); // std::string in int

        std::string new_str2(str, 6, 4);
        int res2 = std::stoi(new_str2);

        if (res1 > res2)
            ++count;
        ++it;
    }

    return count;
}

int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    Student s1("Иванов", "Иван", "Иванович", "01.01.1996", "Москва",
               "128500", "РК-6", "4");
    Student s2("Петров", "Петр", "Петрович", "02.02.1995", "Москва",
               "128500", "РК-6", "3");
    Student s3("Андреев", "Андрей", "Андреевич", "05.03.1994", "Москва",
               "128500", "РК-3", "2");

    std::vector<Student> vec{ s1, s2, s3};
    
    std::cout << countFacul(vec, "РК-6") << std::endl;
    std::cout << countCourse(vec, "4") << std::endl;
    std::cout << countDate(vec, "05.04.1992") << std::endl;

    return 0;
}

