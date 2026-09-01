using static System.Console;

// Car 객체(자동차)를 몇대나 만들었는지 알고 싶다

// 방법 1. 모든 객체는 생성될때 생성자가 호출된다.
// => 갯수를 관리하는 필드를 만들고 생성자에서 ++하면 어떨까?
// => 실패
// 원인 : cnt 필드는 객체마다 별도로 존재하기 때문에, c1.cnt와 c2.cnt는 서로 다른 값을 가진다.

class Car
{
    private int speed = 0;
    private int color = 0;

    public int cnt = 0; // 자동차 갯수 관리를 위한 필드

    public Car(int s)
    {
        ++cnt;
        speed = s;
    }
}

class Program
{
    public static void Main()
    {
        Car c1 = new Car(50);
        Car c2 = new Car(80);

        Console.WriteLine($"자동차 갯수: {c1.cnt}"); // 1

    }
}