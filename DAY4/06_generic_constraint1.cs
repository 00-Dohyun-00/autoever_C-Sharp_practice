using System;
using static System.Console;


class Point
{
	public int X{set;get;} = 0;
	public int Y{set;get;} = 0;
	public Point(int x, int y) => (X, Y) = (x, y);
}


class Program
{
    public static int Max<T>(T a, T b) 
    {

        var ret1 = a.CompareTo(b); // error
                                   // 임의의 타입에 대해 CompareTo() 메소드가 있다는 보장이 없다.

        var ret2 = a.ToString(); // ok
                                 // ToString()은 object가 제공
                                 // 거의 모든 타입은 object로부터 파생

        // 핵심: Generic 메소드 안에서는 기본적으로 object로 할 수 있는 것만 사용 가능
        //       다른 작업을 하려면 generic constraint 문법 사용 (generic_constraing2.cs 참고)

    }

    public static void Main()
    {
		WriteLine($"{Max(10, 20)}");
		WriteLine($"{Max("AAA", "CC")}");

        Foo(10, 20); 
    }
    public static void Foo<T>(T a, T b)
    {

    }
}
