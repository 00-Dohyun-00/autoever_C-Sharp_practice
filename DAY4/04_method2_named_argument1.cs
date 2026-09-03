
class Rect
{

    public void Set(int x, int y, int width, int height) { }
}

class Program
{
    public static void Main()
    {
        Rect rc = new Rect();

        // Rect를 보지 않고는 각 인자의 의미를 예측하기 힘들다.
        rc.Set(1, 1, 10, 10);

        // 아래처럼 사용하면?
        // 가능, named argument
        // 대부분의 다른 언어에서는 지원하지 않음
        rc.Set(x: 1, y: 1, width: 10, height: 10);

        // 일부 요소만 named도 가능
        rc.Set( 1, 1, width: 10, height: 10);
    }
}
