// public field vs setter/getter

// 프라퍼티(property) 문법
// 다른 언어에는 없음

// #1. public 필드
// 외부에서 age에 접근 가능 => age 상태 안전하지 않음
class Person1
{
    public int age;
}

// #2. private field, get/set 메소드 제공
class Person2
{
    private int age;

    public int GetAge() => age;

    public void SetAge(int value)
    {
        if (value > 0)
            age = value;
    }
}

class Program
{
    public static void Main()
    {
        Person1 p1 = new Person1();
        Person2 p2 = new Person2();

        // private field, get/set 메소드 제공하는 상태가 안전하지만
        // 가독성 측면에서 아래 #1이 가독성이 좋음
        // 안전한 #1 => property

        // #1. publie field
        p1.age = 10;
        int n1 = p1.age;

        p1.age = -10;


        // #2.setter/getter 사용
        p2.SetAge(10);
        int n2 = p2.GetAge();

        p2.SetAge(-10);


    }
}
