using static System.Console;

class Car
{
    private int speed = 0;
    private int color = 0;

    //public int cnt = 0; // 자동차 갯수 관리를 위한 필드
    //public static int cnt = 0; // 모든 객체가 공유하는 필드. 
    private static int cnt = 0; // 안전하게 하려면 private

    //public int GetCount() { return cnt; } // instance method "객체.GetCount()" 객체가 있어야 호출 가능
    public static int GetCount() { return cnt; } // static method "GetCount()" 객체가 없어도 호출 가능

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