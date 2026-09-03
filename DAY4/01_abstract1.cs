// abstract method : method 앞에 abstract 키워드를 붙인 메소드. 메소드 구현부이 없다.

// abstract class 
// 정의 : abstract method 가 한개 이상있으면 클래스 에도 abstract 를 붙여야 한다 
// 특징 : 객체를 만들 수 없다
// 의도 : 파생 클래스에게 특정 메소드를 반드시 만들어야 한다고 시키는 것
//        모든 도형은 Draw()를 만들어야 한다고 규칙 제공

abstract class Shape
{
    private int color = 0;
    public void SetColor(int c) { color = c; }
    public abstract void Draw(); // <== 핵심
}

class Rect : Shape
{
    // 상속받은 shape 안의 추상메소드 Draq() 구현부를 만들지 않으면 Rect도 추상
    // Draw()의 구현부를 제공하면 Rect는 추상이 아님 - 사용 가능

    public override void Draw()
    {
        Console.WriteLine("draw Rect");
    }
}

class Program
{ 
    public static void Main()
    {
        Shape s = new Shape(); // error
        Rect r = new Rect();
    }
}