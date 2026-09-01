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

    public int Person() => age = 0;
    public int Person (int a) => age = a;
}


class Program
{
    public static void Main()
    {
        Person p1 = new Person();
        Person p2 = new Person(20);
        Person p3 = new Person{ Age = 20 };
        // 여러개 property가 있으면 아래처럼도 가능
        Person p4 = new Person{ Age = 20, Name = "kim" };

    }
}
