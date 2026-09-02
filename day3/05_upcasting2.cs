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
        // upcasting은 언제 사용하는가?

        List<Dog> s1 = new List<Dog>; // Dog만 보관 가능한 collection

        s1.add(new Dog());
        s1.add(new Dog());

        List<Animal> s2 = new List<Animal>; // 파생변수까지 참조 가능
                                            // 모든 동물(동종)을 보관하는 collection. 
                                            // 동종 : 동일 기반 클래스를 사용하는 타입
        s2.add(new Dog());
        s2.add(new Cat());

        // 활용 2. 동종을 처리하는 함수 만들기.
        void NewYear(Animal d) // 인자로 모든 동물 객체를 전달 가능
        {
            ++d.age;
        }

        NewYear(new Dog());
        NewYear(new Cat());
    }
}