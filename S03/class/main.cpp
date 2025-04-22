#include <iostream>
#include <string.h>
#include <stdlib.h>
using namespace std;

class Student
{
    public:
        int m_stdNum;
        char m_FirstName[20];
        char m_LastName[20];
        int m_CoursesPassed;
        int m_Credits[40];
        double m_Grades[40];
        char* m_CourseNames[40];

        double GetGPA()
        {
            double sumGrade = 0;
            double sumCredit=0;
            for(int i=0; i<m_CoursesPassed; i++)
            {
                sumGrade +=m_Credits[i]*m_Grades[i];
                sumCredit +=m_Credits[i];
            }
            return sumGrade/sumCredit;
        }

        void list_courses()
        {

            for(int i=0; i<m_CoursesPassed; i++)
            {
                cout<<m_CourseNames[i]<<": "
                    <<m_Credits[i] <<": "
                    <<m_Grades[i]<<endl;
            }

        }
        void register_course(int credit, const char* name, double grade)
        {
            m_Credits[m_CoursesPassed]=credit;
            m_Grades[m_CoursesPassed]=grade;
            char* namecopy = new char(strlen(name)+1);
            strcpy(namecopy, name);
            m_CourseNames[m_CoursesPassed]= namecopy;
            m_CoursesPassed++;
        }

};

int main()
{
    Student s;
    s.m_CoursesPassed=0;
    cout<< s.GetGPA() << endl;

}
