//this1.cs 

// 1. 필드는 객체당 한 개씩 메모리에 생성. 
// => Point 객체를 2개 생성하면, x, y도 각각 2개씩 존재한다.

// 2. 객체를 여러개 생성해도 메소드는 코드메모리에 한 개만 존재
// => 모든 객체가 한 개만 있는 메소드를 같이 사용 
using System.Dynamic;
using System.Runtime.CompilerServices;

class Point
{
    private int x = 0;
    private int y = 0;

    // this :  메소드 안에서 자신을 호출할 때 사용한 객체를 나타내는 키워드

    // 사용자가 만든 코드
    public void Set(int a, int b)
    {
        x = a;
        y = b;
    }
    // 실제로는 컴파일러가 이렇게 바꾸어서 동작
    // public void Set(Point this, int a, int b)
    //{
    //     this.x = a;
    //     this.y = b;
    // }
}
class Program
{
    public static void Main()
    {
        Point p1 = new Point();
        Point p2 = new Point();

        // 사용자가 만든 코드
        p1.Set(1, 2);
        p2.Set(1, 2);
        // 실제로는 컴파일러가 이렇게 바꾸어서 동작
        // Set(p1, 1, 2)
        // Set(p2, 1, 2)
    }
}

// c++, c#, java, swift
// => 객체를 전달 받는 코드를 컴파일러가 추가
// void Set(int a, int b) ===> AsyncVoidMethodBuilder Set(Point this, int a, int b)

// Python/Rust
// => 개발자가 직접 코드에 표현
// def set(self, a, b);