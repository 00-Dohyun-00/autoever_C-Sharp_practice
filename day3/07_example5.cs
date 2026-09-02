using static System.Console;

// 핵심 6. 모든 파생 클래스(도형)의 공통 규칙은 기반 클라스(Shape)에도 있어야 한다.
// => 문법적 제약 아님, 디자인 규칙. (디자인 패턴)
// => 그래야 Shape 타입으로 해당 특징(Draw()) 사용 가능

// 핵심 7. 기반 클래스 메소드중에서 파생 클래스가 다시 만들게 된다면 대부분 virtual로 만들어야 함.
class Shape
{
    private int color = 0;
    public virtual void Draw() { WriteLine("draw Shape"); }

    // 파생 클래스가 다시 만들 필요 없으므로 non-virtual
    public void SetColor(int c) { color = c; }

    // 파생 클래스가 다시 만들어야 하므로 virtual
    // (도형마다 크기 계산식 다름)
    public virtual int GetArea() { return -1; }
}

class Rect : Shape
{
    public override void Draw() { WriteLine("draw Rect"); }
}

class Circle : Shape
{
    public override void Draw() { WriteLine("draw Circle"); }
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
                    e.Draw();
                }
                    
            }
        }

    }
}