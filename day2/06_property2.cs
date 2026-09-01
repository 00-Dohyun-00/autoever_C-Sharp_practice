// public field vs setter/getter

class Person
{
    private int age;

    // Property 핵심
    // 필드도 아니고 메소드도 아님(그냥 문법. 외워야함.)
    public int Age
    {
        get{ return age; }
        set{ age = value; }
    }
}


class Program
{
    public static void Main()
    {
        Person p = new Person();

        // property는 필드처럼 사용
        p.Age = 25; // set
        int n = p.Age;  // get

    }
}
