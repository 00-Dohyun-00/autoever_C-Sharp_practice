using static System.Console;

abstract class Shape
{
    private int color = 0;
    public void SetColor(int c) { color = c; }

    // 가상 메소드 : 기반 클래스가 기본 구현을 제공하는 것
    //               파생 클래스가 반드시 다시 만들어야 하는 것은 아니다
    // 추상 메소드 : 파생 클래스에게 반드시 만들라고 지시하는 것
    //public virtual void Draw() { WriteLine("draw Shape"); }
    public abstract void Draw(); // 도형 만들기 예제의 경우 abstract로 파생 클래스에게 시키는 것이 나음
    public abstract Shape Clone();

    // GetArea()
    // 1. abstact로 해도 됨. 
    // => 파생 클래스가 반드시 만들어야 함. 만들지 않으면 사용 못 함.
    
    // 2, 중요한 메소드가 아니라면
    // => 기반 클래스에서 기본 구현을 제공하고,
    // => 면적 구할 수 없음을 의미하는 -1 같은 값을 반환하는 것이 좋음.
    // => 도움말로 -1이 반환되면 면적 구할 수 없는 상태라고 설명 하는 등.
    // => 파생 클래스는 필요한 경우에만 override 하는 기술도 가능

    public virtual Shape Clone()
    {
        Shape s = new Shape();
        s.color = color;
        return s;
    }
    public virtual int GetArea() { return -1; }
}


class Rect : Shape
{
    public override void Draw() { WriteLine("draw Rect"); }
    public override Shape Clone() { return new Rect(); }
}

class Circle : Shape
{
    public override void Draw() { WriteLine("draw Circle"); }
    public override Shape Clone() { return new Circle(); }
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
                    e.Draw();
                }

            }
            else if (cmd == 8)
            {
                Console.Write("몇번째 도형의 복사본을 생성 할까요 >> ");

                int k = int.Parse(Console.ReadLine());

                Shape t = s[k].Clone();

                s.Add(t);

            }

        }
    }
}