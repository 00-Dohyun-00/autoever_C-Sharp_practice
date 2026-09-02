using static System.Console;

// 파워 포인트 같은 프로그램을 객체지향 프로그램으로 설계해 봅시다.

// 핵심 1. 필요한 도형타입을 클래스로 설계

// 핵심 2. 모든 도형의 공통의 기반클래스 Shpe가 있다면 
// => color 같은 모든 동형의 공통의 특징을 한 곳에서 관리할 수 있다.
// => List<Shape> 같이 사용해서 모든 도형을 하나의 컬렉션에 보관 가능

class Shape
{
    private int color = 0;
}

class Rect : Shape
{
    public void Draw() { WriteLine("draw Rect"); }
}

class Circle : Shape
{
    public void Draw() { WriteLine("draw Circle"); }
}


class Program
{
    public static void Main()
    {

        // 여러개의 도형 객체를 보관할 공간이 필요
        //List<Rect> s = new List<Rect>();    // Rect 객체만 보관
        List<Shape> s = new List<Shape>(); // 모든 도형 보관 가능

    }
}