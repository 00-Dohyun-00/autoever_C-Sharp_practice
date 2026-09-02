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

        // 동일성 조사하는 방법

        // 1. 연산자 => 객체가 동일한지 조사
        Console.WriteLine("{0}", p1 == p2); // True
        Console.WriteLine("{0}", p3 == p4); // False

        // 2. object에서 상속받은 Equals() 가상메소드
        // 기본 구현은 == 로 동일한 객체인지 조사하게 되어있지만
        // 사용자가 override 해서 동일한 상태인가로 변경하는 경우가 많음.
        Console.WriteLine("{0}", p1.Equals(p2)); // True
        Console.WriteLine("{0}", p3.Equals(p4)); // True


    }
}