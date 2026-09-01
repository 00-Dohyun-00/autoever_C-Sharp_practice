//this2.cs 

using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

class Point
{
    private int x = 0;
    private int y = 0;

    // this 활용 2. this를 반환하는 함수
    // => 자바에서 널리 사용하는 "빌더 기술"

    public void SetX(int a)
    {
        x = a;
        return this;
    }
    public void SetY(int a)
    {
        y = a;
        return this;
    }

}
class Program
{
    public static void Main()
    {
        Point p = new Point();

        // 메소드가 this를 반환하면 메소드 호출을 연속적으로 할 수 있음. 
        // => Method chaining
        // 요즘 다양한 언어에서 사용됨
        p.SetX(3).SetY(3).SetX(3).SetY(5);

        // java에서 아래처럼 많이 사용
        // Person p2 = new Person();
        // p2.SetName("kim").SetAge(30).SetHeight(180);
      
    }
}
