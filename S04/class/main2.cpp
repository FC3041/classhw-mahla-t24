#include <iostream>
using namespace std;

class Date
{
    int day;
    int month; 
    int year;
};

class Person
{
    public:
        int m_NID;
        char m_fname[20];
        char m_lname[20];
        Date m_BD;

        Person(const char* fn, const char* ln, int id, Date bd):m_BD(bd), m_NID(id)
        {
            int i;
            for(i=0; i<sizeof(m_fname) && fn[i]!='\0';i++)
            {
                m_fname[i] = fn[i];
            }
            m_fname[i]='\0';

            for(i=0; i<sizeof(m_lname) && ln[i]!='\0';i++)
            {
                m_lname[i] = ln[i];
            }
            m_lname[i]='\0';
        }

        void print_person()
        {
            cout<<"Name: "<< m_fname<<" "<<m_lname<< endl;
        }
    
};

int main()
{
    
}