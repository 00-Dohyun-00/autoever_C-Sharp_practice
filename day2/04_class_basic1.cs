using static System.Console;

// 핵심. 생성자 이야기 
class Rect
{
    public int left = 0;
    public int top = 0;
    public int right = 0;
    public int bottom = 0;

    // 생성자: 클래스 이름과 동일한 이름의 함수
    public Rect(int x1, int y1, int x2, int y2)
    {
        left = x1;
        top = y1;
        right = x2;
        bottom = y2;
    }

    public int GetArea()
    {
        return (right - left) * (bottom - top);
    }

}

class Program
{
    public static void Main()
    {
        // Rect rc = new Rect();
        // rc.left = 1;
        // rc.top = 1;
        // rc.right = 10;
        // rc.bottom = 10;

        Rect rc = new Rect(1, 1, 10, 10);

        int ret = rc.GetArea();

        Console.WriteLine($"{ret}"); 
    }
}