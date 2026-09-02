class Animal
{
    public int age = 0;
}

class Dog : Animal
{
    public int color = 0;
}

class Cat : Animal
{
    public int speed = 0;
}

class Program
{
    public static void Main()
    {
        Dog r1 = new Dog(); // ok

        int r2 = new Dog(); // error

        // 핵심1: 기반 클래스 타입의 참조(reference) 변수는 파생 클래스 타입의 객체를 참조할 수 있습니다.
        //        Dog의 메모리에 보면 Animal의 멤버도 포함되어 있고, Dog 본연의 멤버보다 앞 주소에 놓이기 때문에, Dog 객체를 Animal 타입으로 참조할 수 있음.
        Animal r3 = new Dog(); // ok upcasting

        // 핵심2: 컴파일러는 컴파일 시간에는 r3 대상체(Dog)의 타입을 알 수 없다.
        //        r3 자체의 타입이 Animal이라는 것 만 알 수 있다.
        //        이유는 아래 코드와 같이 실행시간 변경 가능 하므로

        if (사용자 입력값 == 1) r3 = new Cat(); // 사용자 입력에 따라 대상체가 바뀔 수 있음

        // 핵심3: Anumal 타입인 r3를 사용해서는 Animal 고유의 멤버만 접근 가능. Dog가 추가한 멤버는 접근 못 함
        //        이유는 static type check를 하기 때문에.

        //        static type check : 타입에 관한 확인을 컴파일 시간에 하는 것
        //        dynamic type check : 타입에 관한 확인을 실행 시간에 하는 것

        r3.age = 10; // ok
        r3.color = 0; // error


        // 핵심4. animal 타입의 reference인 r3을 가지고 dog의 고유 멤버에 접근하려면 r3를 dog 타입으로 캐스팅해서 사용
        // => 컴파일러에게 대상체가 Dog라고 알려주는 것
        ((Dog)r3).color = 1;
        // 단 위 코드는 r3의 대상체가 dog가 아닌 경우 runtime error
        // 확신이 있을 때만 사용

        // 핵심 5. 대상체의 타입에 대해 확신이 없다면 조사 후 케스팅 할 것
        // => is 연산자

        if(r3 is Dog)
        {

            ((Dog)r3).color = 1;

            Dog d = (Dog)r3;
            d.color = 2;
        }

        // 위 코드를 간결하게 하려면
        if(r3 is Dog d)
        {
            d.color = 2;
        }
    }
}