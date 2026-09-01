using static System.Console;

class Car
{
    private int speed = 0;
    private static int cnt = 0; 

    public int GetSpeed() { return speed; } // instance method "객체.GetSpeed()" 객체가 있어야 호출 가능
    public static int GetCount() { return cnt; } // static method "클래스이름.GetCount()" 

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
        Console.WriteLine($"자동차 갯수: {Car.GetCount()}"); // 0

        Car c1 = new Car(50);
        Car c2 = new Car(80);

        Console.WriteLine($"자동차 갯수: {Car.GetCount()}"); // 2

    }
}