using static System.Console;

class Animal
{
    // non-virtual : 기본 정책은 static binding으로 동작
    //               대상체 타입이 아닌 reference 변수 타입으로 결정
    //               new를 사용해서 재정의
    public void Cry1() { WriteLine("Animal Cry1"); }

    // virtual : dynamic binding 해달라는 뜻
    //           대상체 타입에 따라 메소드 결정
    //           new 가 아닌 override를 붙여서 재정의
    public void Cry2() { WriteLine("Animal Cry2"); }
}

class Dog : Animal
{
    public new void Cry1() { WriteLine("Dog Cry1"); }
    public override void Cry2() { WriteLine("Dog Cry2"); } // => 약간의 성능 저하 (실행시간에 실행되므로)
}

class Program
{
    public static void Main()
    {
        Animal ad = new Dog();

        ad.Cry1();  // Animal Cry
        ad.Cry2();  // Dog Cry 
    }
}

