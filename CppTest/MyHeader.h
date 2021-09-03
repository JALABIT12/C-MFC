#include <iostream>
using namespace std;
void swapValue(int a, int b);   // �Լ��� ����(prototype) ����
void swapRef(int& a, int& b);
void swapRef(int* a, int* b);
void str_cpy(char* dest, char* src); // strcpy �Լ��� ����

class Point
{
private:
    int x;  // �⺻ ���� ���� �����ڴ� private 
    int y;

public:
    Point(int x = 0, int y = 0) : x(x)
    {
        this->y = y;
    }
    int X() { return x; }
    int Y() { return y; }
    void SetX(int x) { this->x = x; }
    void SetY(int y) { this->y = y; }
    double distance(Point p); // Point p���� �Ÿ�
    Point operator+(Point p)
    {
        return Point(this->x + p.x, this->y + p.y);
    }
    Point operator+=(Point p)
    {
        x += p.x; y += p.y;
        return *this;
    }
    Point operator*(int n)
    {
        return Point(this->x * n, this->y * n);
    }
};

class Point3D : public Point        // 2D Point class ���
{
private:
    int z; // z��

public:
    Point3D(int x = 0, int y = 0, int z = 0) : Point(x, y)
    {
        this->z = z;
    }
    int Z() { return z; }
    void SetZ(int z) { this->z = z; }
    double distance(Point3D p); // Point3D p���� �Ÿ�
};

class Person
{
private:
    int Number;  // ���� ��ȣ
    char Name[20];  // ���ڿ��� ���� �׸� : �ѱ� 10��
    int Age;

public:
    Person(int num, char* str = NULL, int a = 0) : Number(num), Age(a)
    {
        strcpy(Name, str);
    }
    Person(int num, const char* str = NULL, int a = 0) : Number(num), Age(a)
    {
        strcpy(Name, str);
    }
    int age() { return Age; }
    char* name() { return Name; }
    int number() { return Number; }
    void SetAge(int a) { Age = a; }
    void SetName(char* str)  // ���� ���� ����(delete) �� ���� ����. XXXXXXXXXX
    {
        strcpy(Name, str);
    }
};

class PersonEx
{
private:
    int Number;  // ���� ��ȣ
    char* Name;  // ���ڿ��� ���� �׸���? ==> malloc Ȥ�� new �� �̿��Ͽ� �������� �Ҵ� �ʿ�
    int Age;

public:
    PersonEx(int num, char* str, int a) : Number(num), Age(a)
    {
        Name = new char[strlen(str)];
        strcpy(Name, str);
    }
    ~PersonEx()
    {
        delete[]Name;
    }
    int age() { return Age; }
    char* name() { return Name; }
    void SetAge(int a) { Age = a; }
    void SetName(char* str)  // ���� ���� ����(delete) �� ���� ����.
    {
        delete[]Name;
        Name = new char[strlen(str)];
        strcpy(Name, str);
    }
};

class Student : public Person
{
private:
    int Kor;
    int Eng;
    int Tot;
    double Avg;
    int Rank;
    void calc()
    {
        Tot = Kor + Eng;
        Avg = (double)Tot / 2.0;
    }
public:
    Student(int num, int kor, int eng, char* str = NULL, int age = 0) : Person(num, str, age)
    {
        this->Kor = kor;
        this->Eng = eng;
        calc();
    }
    Student(int num, int kor, int eng, const char* str = NULL, int age = 0) : Person(num, str, age)
    {
        this->Kor = kor;
        this->Eng = eng;
        calc();
    }
    Student(int num, int kor, int eng, std::string str, int age = 0) : Person(num, str.c_str(), age)
    {
        this->Kor = kor;
        this->Eng = eng;
        calc();
    }
    int kor() { return Kor; }
    int eng() { return Eng; }
    int tot() { return Tot; }
    double avg() { return Avg; }
    int rank() { return Rank; }
    void SetKor(int k) { Kor = k; calc(); }
    void SetEng(int e) { Eng = e; calc(); }
    void SetRank(int r) { Rank = r; }
};