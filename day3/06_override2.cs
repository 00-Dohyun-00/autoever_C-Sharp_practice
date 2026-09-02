using static System.Console;

class Animal
{
    public void Cry() { WriteLine("1. Animal Cry"); }
}
class Dog : Animal
{
    public new void Cry() { WriteLine("2. Dog Cry"); }
}

class Program
{
    public static void Main()
    {
        Animal ad = new Dog();

        // ad 자체의 타입 : Animal
        // ad 가 가리키는 대상체 타입 :  Dog

        // 아래 코드는 어느 메소드를 호출?
        ad.Cry(); // Anumal Cry

        // C#, C++ : Animal Cry => but virtural function 써서 dynamic binding으로 만들 수 있음.
        // Java, Python, Swift, Kotlin, Objective-C... 대부분의 언어 :  Dog Cry
    }
}
