
using static System.Console;
class Rect
{
    public int left = 0;
    public int top = 0;
    public int right = 0;
    public int bottom = 0;

    public Rect(int x1, int y1, int x2, int y2) => (left, top, right, bottom) = (x1, y1, x2, y2);


    public Rect() => (left, top, right, bottom) = (0, 0, 0, 0);

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