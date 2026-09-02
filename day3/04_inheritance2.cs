// object 이야기

// c# 특징 : 대부분의 타입은 object라는 클래스로부터 상속받는다. (object는 모든 타입의 부모 클래스)
// ": object" 가 없어도 자동으로 상속된다


class Car // 컴파일러가 Car: object 로 바꿔서 컴파일한다
{
}

class Program
{
    public static void Main()
    {
        Car c = new Car();

        string s = c.ToString();

        Console.WriteLine(s) 
    }
}