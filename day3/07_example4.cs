using static System.Console;

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

        List<Shape> s = new List<Shape>(); // 모든 도형 보관 가능

        while (true)
        {
            int cmd = int.Parse(Console.ReadLine()); // 정수 입력받기

            if (cmd == 1) s.Add(new Rect());
            else if (cmd == 2) s.Add(new Circle());
            else if (cmd == 9)
            {
                foreach (var e in s) // e는 shape 타입
                {
                    //e.Draw(); // shape 안에는 Draw()가 없으므로 error

                    // 해결책 1. 캐스팅 => but 도형의 개수가 많아지면 관리 어려움
                    //if(e is Rect)
                    //{
                    //    ((Rect)e).Draw();
                    //} else
                    //{
                    //    ((Circle)e).Draw();
                    //}

                    if (e is Rect r)
                    {
                        r.Draw();
                    }
                    else if (e is Circle c)
                    {
                        c.Draw();
                    }

                    // 핵심 5. ocp 규칙 - 객체지향 프로그래밍 설계의 핵심 원리 5개 중 한 개
                    // => 기능 확장에는 열려있고,
                    // => 코드 수정에는 닫혀야 함
                    // => 모듈, 클래스 등이 추가되어도 기존 코드는 수정되지 않도록
                    
                }
            }
        }
    }
}