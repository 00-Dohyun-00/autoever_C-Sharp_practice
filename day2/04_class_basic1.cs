using static System.Console;

// 핵심. 생성자 이야기 
class Rect
{
    public int left = 0;
    public int top = 0;
    public int rigth = 0;
    public int bottom = 0;

    public int GetArea()
    {
        return (right - left) * (bottom - top);
    }

}

class Program
{
    public static void Main()
    {
        Rect rc = new Rect();
        rc.left = 1;
        rc.top = 1;
        rc.rigth = 10;
        rc.bottom = 10;

        int ret = rc.GetArea();

        Console.WriteLine($"{ret}"); 
    }
}