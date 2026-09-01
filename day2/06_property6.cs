// public field vs setter/getter

using System.Security.Cryptography.X509Certificates;

class Person
{
    private int age;
    public int Age
    {
        get{ return age; }
        set{ age = value; }
    }

    // 프라퍼티의 원리 
    // => 위 코드를 보고 컴파일러가 set_Age(), get_Age()라는 2개의 메소드를 자동 생성.
    // 그래서 해당 이름의 메소드 생성 불가함.
}


class Program
{
    public static void Main()
    {
        Person p = new Person();
        p.Age = 10;

    }
}
