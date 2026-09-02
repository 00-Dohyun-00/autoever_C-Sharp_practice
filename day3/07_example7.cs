using static System.Console;

// 핵심 8. 디자인 패턴이란?
// => 1994 년에 발간된 책 제목. 4명의 개발자가 당시 유행하는 오픈소스를 분석해서 공통으로 사용되던 스타일의 코드에 이름을 부여. 23개. 

// 핵심 9. Prototype 디자인 패턴
// 견본이 되는 객체를 만들고 복사를 통해 새로운 객체 생성
// Clone() 가상함수를 만들어서 사용하는 기술



class Shape
{
    private int color = 0;
    public virtual void Draw() { WriteLine("draw Shape"); }

    public void SetColor(int c) { color = c; }

    public virtual int GetArea() { return -1; }

    public virtual Shape Clone()
    {
        Shape s = new Shape();
        s.color = color;
        return s;
    }
}

class Rect : Shape
{
    public override void Draw() { WriteLine("draw Rect"); }

    public override Shape Clone()
    {
        return new Rect();
    }
}

class Circle : Shape
{
    public override void Draw() { WriteLine("draw Circle"); }

    public override Shape Clone()
    {
        return new Circle();
    }

}


class Program
{
    public static void Main()
    {

        List<Shape> s = new List<Shape>(); 

        while (true)
        {
            int cmd = int.Parse(Console.ReadLine());

            if (cmd == 1) s.Add(new Rect());
            else if (cmd == 2) s.Add(new Circle());
            else if (cmd == 9)
            {
                foreach (var e in s) 

                {
                    e.Draw(); // 다형성(Polymorphism)
                              // 동일한 표현식(코드)가 상황(실제 객체 종류)에 따라 다르게 동작
                              

                    // 객체지향 프로그래밍 언어의 3대 특징
                    // 캡슐화, 상속, 다형성
                }

            }
            else if(cmd == 8)
            {
                Console.Write("몇 번째 도형의 복사본을 생성할까요 >>");

                itn k = int.Parse(Console.ReadLine());

                // k 번째 도형의 복사본을 생성해서 s에 추가합니다.

                // 좋지 않은 디자인
                //if (s[k] is Rect)
                //{

                //} else if (s[k] is Circle)
                //{

                //}


                // 좋은 디자인
                // Don't ask, do it

                Shape t = s[k].Clone();
                s.Add(t);
                
            }
        }

    }
}