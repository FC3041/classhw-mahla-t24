#include <iostream>
#include <math.h>
using namespace std;

class Point
{
    public:
        double m_x;
        double m_y;

        Point() {};
        Point (double a, double b): m_x(a),m_y(b){};

        double distanceto(Point p)
        {
            double dx=m_x - p.m_x;
            double dy= m_y - p.m_y;
            return sqrt(dx*dx + dy*dy);
        }
        void print_point()
        {
            cout<< "x: "<< m_x << ", y: "<< m_y<<endl;
        }
};

class Circle
{
    public:
        Point m_o;
        double m_r;

        // Circle(const Point &o , double r)
        // {
        //     m_o=o;
        //     m_r=r;
        // }

        Circle (const Point &o , double r): m_o(o),m_r(r){};
        Circle () {};

        double distanceto(const Circle &c)
        {
            return distanceto(c.m_o);
        }
        double distanceto(Point p)
        {
            return p.distanceto(m_o);
        }

};

int main()
{
    // Point p1();
    Point p2(4,7);
    Point p3(1,5);
    Circle c1(Point (1,2), 12.3);
    Circle c2(p3, 12);

    cout<<c1.distanceto(c2)<<endl;
    cout<<c1.distanceto(p3)<<endl;
    cout<<p3.distanceto(p2)<<endl;



}