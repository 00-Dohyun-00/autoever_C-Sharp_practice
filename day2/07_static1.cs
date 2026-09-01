using static System.Console;

// Car 객체(자동차)를 몇대나 만들었는지 알고 싶다


class Car 
{
    private int speed = 0;  

    public Car(int s)
    {
        speed = s;
    }
}

class Program
{
    public static void Main()
    {
        Car c1 = new Car(50);
        Car c2 = new Car(80);

    }
}