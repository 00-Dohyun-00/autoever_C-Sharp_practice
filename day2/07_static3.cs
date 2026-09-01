using static System.Console;

class Car
{
    private int speed = 0;
    private int color = 0;

    //public int cnt = 0; // 자동차 갯수 관리를 위한 필드
    public static int cnt = 0; // 모든 객체가 공유하는 필드. 
                               // 자동차를 만들지 않아도 메모리에 있고
                               // 자동차를 여러개 만들어도 각각의 객체 메모리에는 포함x
                               // 접근시 "Car.cnt"로 접근해야함

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
        Console.WriteLine($"자동차 갯수: {Car.cnt}"); // 0

        Car c1 = new Car(50);
        Car c2 = new Car(80);

        Console.WriteLine($"자동차 갯수: {Car.cnt}"); // 2

    }
}