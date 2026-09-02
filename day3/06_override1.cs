using static System.Console;

class Animal
{
    public void Cry() { WriteLine("1. Animal Cry"); }
}
class Dog : Animal
{
    // override: 기반 클래스의 메소드를 파생 클래스가 다시 만드는 것
    // new : 기반 클래스 메소드를 의도적으로 다시 만든다고 알리는 것 - 생략하면 겅고 발생. 빌드는 됨.
    public new void Cry() { WriteLine("2. Dog Cry"); }
}

class Program
{
    public static void Main()
    {
        Animal a = new Animal();
        Dog d = new Dog();

        a.Cry();    // Anummal Cry 호출
        d.Cry();    // Dog Cry 호출

        //----------------------------------
        //Animal ad = d;


        //ad.Cry(); // ?
    }
}
