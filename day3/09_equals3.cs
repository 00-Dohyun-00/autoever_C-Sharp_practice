using static System.Console;

class Point
{
    private int x = 0;
    private int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);

    public override bool Equals(object obj)
    {
        Point other = (Point)obj;

        return x == other.x && y == other.y;
    }
}

class Program
{
    public static void Main()
    {
        // 객체의 동일성에는 2가지 개념이 있습니다.
        // 1. 객체 자체가 동일한가 ?
        // 2. 객체는 다르지만 상태가 동일한가 ?


        // 동일 객체
        Point p1 = new Point(1, 2);
        Point p2 = p1;

        // 동일 객체 아니지만 상태는 동일
        Point p3 = new Point(1, 2);
        Point p4 = new Point(1, 2);

        bool ret;

        // 최선의 코드
        ret = p2 == p3;
        if(ret == false) ret = p2.Equals(p3);

        // 위 코드와 동일
        bool ret2 = object.Equals(p3, p4);

        Console.WriteLine("{}", ret);


    }
}