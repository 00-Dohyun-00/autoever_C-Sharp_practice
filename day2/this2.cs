//this2.cs 

using System.Dynamic;
using System.Runtime.CompilerServices;

class Point
{
    private int x = 0;
    private int y = 0;

    // this 활용 1. 이름 충돌이 있을 때 필드를 가리킴을 명확히 하기 위해.
    //              이름 충돌이 없어도 메소드가 복잡하다면 this.를 붙이는 것을 권장(가독성)
    public void Set(int x, int y)
    {
        // x = x; // 인자의 x = 인자의 x
        this.y = y; 
    }
}
class Program
{
    public static void Main()
    {
        Point p1 = new Point();
        Point p2 = new Point();

        p1.Set(1, 2);
        p2.Set(1, 2);
    }
}
