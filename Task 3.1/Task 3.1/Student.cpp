#include "Student.h"

Student::Student() = default;

Student::Student(const char* str1, const char* str2, const char* str3,
        const char* str4, const char* str5, const char* str6,
        const char* str7, const char* str8)
        : surname(new char[strlen(str1) + 1]), name(new char[strlen(str2) + 1]),
        middle_name(new char[strlen(str3) + 1]), date_of_birth(new char[strlen(str4) + 1]),
        address(new char[strlen(str5) + 1]), mobile_number(new char[strlen(str6) + 1]),
        faculty(new char[strlen(str7) + 1]), course(new char[strlen(str8) + 1])
    {
        if (strlen(str1) > 0)
        {
            for (int i = 0; i < strlen(str1) + 1; ++i)
                surname[i] = str1[i];
        }

        if (strlen(str2) > 0)
        {
            for (int i = 0; i < strlen(str2) + 1; ++i)
                name[i] = str2[i];
        }

        if (strlen(str3) > 0)
        {
            for (int i = 0; i < strlen(str3) + 1; ++i)
                middle_name[i] = str3[i];
        }

        if (strlen(str4) > 0)
        {
            for (int i = 0; i < strlen(str4) + 1; ++i)
                date_of_birth[i] = str4[i];
        }

        if (strlen(str5) > 0)
        {
            for (int i = 0; i < strlen(str5) + 1; ++i)
                address[i] = str5[i];
        }

        if (strlen(str6) > 0)
        {
            for (int i = 0; i < strlen(str6) + 1; ++i)
                mobile_number[i] = str6[i];
        }

        if (strlen(str7) > 0)
        {
            for (int i = 0; i < strlen(str7) + 1; ++i)
                faculty[i] = str7[i];
        }

        if (strlen(str8) > 0)
        {
            for (int i = 0; i < strlen(str8) + 1; ++i)
                course[i] = str8[i];
        }
    }

Student::Student(const Student& s)
    {
        surname = new char[strlen(s.surname) + 1];
        for (int i = 0; i < strlen(s.surname) + 1; ++i)
            surname[i] = s.surname[i];

        name = new char[strlen(s.name) + 1];
        for (int i = 0; i < strlen(s.name) + 1; ++i)
            name[i] = s.name[i];

        middle_name = new char[strlen(s.middle_name) + 1];
        for (int i = 0; i < strlen(s.middle_name) + 1; ++i)
            middle_name[i] = s.middle_name[i];

        date_of_birth = new char[strlen(s.date_of_birth) + 1];
        for (int i = 0; i < strlen(s.date_of_birth) + 1; ++i)
            date_of_birth[i] = s.date_of_birth[i];

        address = new char[strlen(s.address) + 1];
        for (int i = 0; i < strlen(s.address) + 1; ++i)
            address[i] = s.address[i];

        mobile_number = new char[strlen(s.mobile_number) + 1];
        for (int i = 0; i < strlen(s.mobile_number) + 1; ++i)
            mobile_number[i] = s.mobile_number[i];

        faculty = new char[strlen(s.faculty) + 1];
        for (int i = 0; i < strlen(s.faculty) + 1; ++i)
            faculty[i] = s.faculty[i];

        course = new char[strlen(s.course) + 1];
        for (int i = 0; i < strlen(s.course) + 1; ++i)
            course[i] = s.course[i];
    }

    Student& Student::operator=(const Student& s)
    {
        if (&s == this)
            return *this;

        delete[] surname;
        delete[] name;
        delete[] middle_name;
        delete[] date_of_birth;
        delete[] address;
        delete[] mobile_number;
        delete[] faculty;
        delete[] course;

        surname = new char[strlen(s.surname) + 1];
        for (int i = 0; i < strlen(s.surname) + 1; ++i)
            surname[i] = s.surname[i];

        name = new char[strlen(s.name) + 1];
        for (int i = 0; i < strlen(s.name) + 1; ++i)
            name[i] = s.name[i];

        middle_name = new char[strlen(s.middle_name) + 1];
        for (int i = 0; i < strlen(s.middle_name) + 1; ++i)
            middle_name[i] = s.middle_name[i];

        date_of_birth = new char[strlen(s.date_of_birth) + 1];
        for (int i = 0; i < strlen(s.date_of_birth) + 1; ++i)
            date_of_birth[i] = s.date_of_birth[i];

        address = new char[strlen(s.address) + 1];
        for (int i = 0; i < strlen(s.address) + 1; ++i)
            address[i] = s.address[i];

        mobile_number = new char[strlen(s.mobile_number) + 1];
        for (int i = 0; i < strlen(s.mobile_number) + 1; ++i)
            mobile_number[i] = s.mobile_number[i];

        faculty = new char[strlen(s.faculty) + 1];
        for (int i = 0; i < strlen(s.faculty) + 1; ++i)
            faculty[i] = s.faculty[i];

        course = new char[strlen(s.course) + 1];
        for (int i = 0; i < strlen(s.course) + 1; ++i)
            course[i] = s.course[i];

        return *this;

    }

Student::Student(Student&& s)
        : surname(s.surname), name(s.name), middle_name(s.middle_name),
        date_of_birth(s.date_of_birth), address(s.address), mobile_number(s.mobile_number),
        faculty(s.faculty), course(s.course)
    {
        s.surname = nullptr;
        s.name = nullptr;
        s.middle_name = nullptr;
        s.date_of_birth = nullptr;
        s.address = nullptr;
        s.mobile_number = nullptr;
        s.faculty = nullptr;
        s.course = nullptr;
    }

    Student& Student::operator=(Student&& s)
    {
        if (&s == this)
            return *this;

        surname = s.surname;
        name = s.name;
        middle_name = s.middle_name;
        date_of_birth = s.date_of_birth;
        address = s.address;
        mobile_number = s.mobile_number;
        faculty = s.faculty;
        course = s.course;

        s.surname = nullptr;
        s.name = nullptr;
        s.middle_name = nullptr;
        s.date_of_birth = nullptr;
        s.address = nullptr;
        s.mobile_number = nullptr;
        s.faculty = nullptr;
        s.course = nullptr;

        return *this;
    }


    void Student::setSurname(const char* str)
    {
        surname = new char[strlen(str) + 1];
        for (int i = 0; i < strlen(str) + 1; ++i)
            surname[i] = str[i];
    }

    void Student::setName(const char* str)
    {
        name = new char[strlen(str) + 1];
        for (int i = 0; i < strlen(str) + 1; ++i)
            name[i] = str[i];
    }

    void Student::setMiddleName(const char* str)
    {
        middle_name = new char[strlen(str) + 1];
        for (int i = 0; i < strlen(str) + 1; ++i)
            middle_name[i] = str[i];
    }

    void Student::setDateOfBirth(const char* str)
    {
        date_of_birth = new char[strlen(str) + 1];
        for (int i = 0; i < strlen(str) + 1; ++i)
            date_of_birth[i] = str[i];
    }

    void Student::setAddress(const char* str)
    {
        address = new char[strlen(str) + 1];
        for (int i = 0; i < strlen(str) + 1; ++i)
            address[i] = str[i];
    }

    void Student::setMobileNumber(const char* str)
    {
        mobile_number = new char[strlen(str) + 1];
        for (int i = 0; i < strlen(str) + 1; ++i)
            mobile_number[i] = str[i];
    }

    void Student::setFaculty(const char* str)
    {
        faculty = new char[strlen(str) + 1];
        for (int i = 0; i < strlen(str) + 1; ++i)
            faculty[i] = str[i];
    }

    void Student::setCourse(const char* str)
    {
        course = new char[strlen(str) + 1];
        for (int i = 0; i < strlen(str) + 1; ++i)
            course[i] = str[i];
    }

    char* Student::getSurname() const { return surname; }
    char* Student::getName() const { return name; }
    char* Student::getMiddleName() const { return middle_name; }
    char* Student::getDateOfBirth() const { return date_of_birth; }
    char* Student::getAddress() const { return address; }
    char* Student::getMobileNumber() const { return mobile_number; }
    char* Student::getFaculty() const { return faculty; }
    char* Student::getCourse() const { return course; }

    void Student::show() const
    {
        std::cout << surname << ", " << name << ", " << middle_name << ", "
            << date_of_birth << ", " << address << ", " << mobile_number << ", "
            << faculty << ", " << course << ".\n";
    }

    Student::~Student()
    {
        delete[] surname;
        delete[] name;
        delete[] middle_name;
        delete[] date_of_birth;
        delete[] address;
        delete[] mobile_number;
        delete[] faculty;
        delete[] course;
    }