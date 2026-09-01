using static System.Console;

class Car
{
    private int speed = 0;
    private static int cnt = 0;

    // 다음 코드에서 컴파일 에러를 모두 찾으세요
    public void foo()
    {
        speed = 0; 
        cnt = 0;  
        goo(); 
    }

   public static void goo()
    {
        speed = 0; // 컴파일 에러. static 메서드에서는 인스턴스 멤버에 접근할 수 없다.
        cnt = 0;
        foo(); // 컴파일 에러. static 메서드에서는 인스턴스 멤버에 접근할 수 없다.
    }

}

class Program
{
    public static void Main()
    {
        Car.goo()

    }
}