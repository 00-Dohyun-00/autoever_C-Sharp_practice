using static System.Console;
class Rect
{
    public int left = 0;
    public int top = 0;
    public int right = 0;
    public int bottom = 0;

    // 생성자규칙1. 여러개 만들 수 있음
    // 생성자규칙2. 사용자가 만들지 않으면 컴파일러가 인자 없는 생성자 제공(아무 일도 안 함). 따라서 Rect r = new Rect() 가 가능한 것.
    //             하나라도 만들면 Rect r = new Rect() 불가
    public Rect(int x1, int y1, int x2, int y2)
    {
        left = x1;
        top = y1;
        right = x2;
        bottom = y2;

        WriteLine("Rect(int, int, int, int)");
    }

    public Rect()
    {
        left = 0;
        top = 0;
        right = 0;
        bottom = 0;
        WriteLine("Rect()");
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

        Rect rc1 = new Rect(1, 1, 10, 10);
        Rect rc2 = new Rect();

    }
}