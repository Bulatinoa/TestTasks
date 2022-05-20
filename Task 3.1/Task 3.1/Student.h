#pragma once

#include <iostream>

class Student
{
private:
    char* surname = nullptr;
    char* name = nullptr;
    char* middle_name = nullptr;
    char* date_of_birth = nullptr;
    char* address = nullptr;
    char* mobile_number = nullptr;
    char* faculty = nullptr;
    char* course = nullptr;

public:
    Student();

    Student(const char* str1, const char* str2, const char* str3,
        const char* str4, const char* str5, const char* str6,
        const char* str7, const char* str8);

    Student(const Student& s);
    
    Student& operator=(const Student& s);
   
    Student(Student&& s);

    Student& operator=(Student&& s);
   
    void setSurname(const char* str);
    void setName(const char* str);
    void setMiddleName(const char* str);
    void setDateOfBirth(const char* str);
    void setAddress(const char* str);
    void setMobileNumber(const char* str);
    void setFaculty(const char* str);
    void setCourse(const char* str);

    char* getSurname() const;
    char* getName() const;
    char* getMiddleName() const;
    char* getDateOfBirth() const;
    char* getAddress() const;
    char* getMobileNumber() const;
    char* getFaculty() const;
    char* getCourse() const;

    void show()const;

    ~Student();
};