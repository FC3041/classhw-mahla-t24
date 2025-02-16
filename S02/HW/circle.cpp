#include <iostream>
#include <math.h>

using namespace std;

const double PI=3.14159;


class point
{
    public:
        double x;
        double y;
        point(double a, double b)
        {
            x=a;
            y=b;
        }
};


class circle
{
    public:
        double r;
        double ox;
        double oy;

        circle(double a,double b, double c){
            r=a;
            ox=b;
            oy=c;
        }

        double circumference()
        {
            return 2*r*(PI);
        }
        double area()
        {
            return PI*r*r;
        }
        double distance_circles(circle C)
        {
            double dx=ox-C.ox;
            double dy=oy- C.oy;
            return sqrt((dx*dx)+(dy*dy));
        }
        double distance_point(point p)
        {
            double dx= ox- p.x;
            double dy=oy - p.y;
            return sqrt((dx*dx)+(dy*dy));
        }
        const char* point_in(point p)
        {
            if( distance_point(p)>r)
                return "point is not in the circle!";
            if(distance_point(p)==r)
                return "point is on the circle.";
                
            return "point is in the circle.";
        }


};


int main()
{

    point p1(0,2);
    point p2(2,2);
    point p3(1,1);

    circle c1(2,0,0);
    circle c2(1,3,4);

    cout<<"area c1: "<<c1.area()<<endl<<"circumference c1: "<<c1.circumference()<<endl;
    cout<<"distance of p1 from c1: "<<c1.distance_point(p1)<<" and " << c1.point_in(p1)<<endl;
    cout<<"distance of p2 from c1: "<<c1.distance_point(p2)<<" and " << c1.point_in(p2)<<endl;
    cout<<"distance of p3 from c1: "<<c1.distance_point(p3)<<" and " << c1.point_in(p3)<<endl;
    cout<<"distance of c2 from c1: "<<c1.distance_circles(c2)<<endl;

}