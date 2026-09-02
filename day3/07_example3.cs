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
                    //e.Draw(); // shape 안에는 Draw()가 없으므로 error
            }
        }

    }
}