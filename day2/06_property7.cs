// public field vs setter/getter

using System.Security.Cryptography.X509Certificates;

class Person
{
    // private int age;
    // public int Age
    // {
    //     get{ return age; }
    //     set{ age = value; }
    // }

    // 위처럼 별도의 logic을 추가로 가지지 않은 프라퍼티가 필요하면 아래처럼 한 줄만 만들면 됨. 
    // 아래 한 줄이 위 주석 코드와 동일.
    public int Age {get; set;} = 0;
}


class Program
{
    public static void Main()
    {
        Person p = new Person();
        p.Age = 10;

    }
}
