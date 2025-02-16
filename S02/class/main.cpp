#include <iostream>
using namespace std;
#include <math.h>
class Point
{
    public:
        double x;
        double y;

        Point(double t, double w)
        {
            x=t;
            y=w;
            cout<<"x in c:"<<x<<"  y in c:"<<y<<endl;

        }
        Point(double l)
        {
            x=l;
            y=l;
        }
        Point(Point* p)
        {
            x=p->x;
            y=(p->y)-1;
        }
        ~Point()
        {
            cout<<"x in d:"<<x<<"  y in d:"<<y<<endl;
        }

        void print_point()
        {
            cout<<"x:"<<x <<" y:"<<y<<endl;
        }

        double dis(Point p)
        {
            double ans=sqrt(((p.x-x)*(p.x-x))+((p.y-y)*(p.y-y)) );
            return ans;
        }
};

int main()
{
    Point p1(1,1);
    int c=5;
    while(c!=0)
    {
        if(c>3)
        {
            Point p2(2,2);
        }else{
            Point p3(3,3);
        }
        c--;
    }
}



int main1()
{
    // Point p1;
    // p1.x=5;
    // p1.y=4;
    Point p1(5,4);
    // Point p2;
    // p2.x=1;
    // p2.y=7;
    Point p2(1,7);
    Point p3(8);
    Point p4(p1);
    p2.print_point();
    p1.print_point();
    p4.print_point();
    cout<<p1.dis(p2);

    // int a;
    // cin>>a;
    // cout<<"a:"<<a<<endl;
    return 0;
}