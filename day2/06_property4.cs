// public field vs setter/getter

class Person
{
    private int age;
    public int Age
    {
        // get{ return age; }
        set{ age = value; }
    }
}


class Program
{
    public static void Main()
    {
        Person p = new Person();
        p.Age = 25; //ok
        int n = p.Age; // x (get함수를 안 만들어서)

        string s = "hello";

        bool n2 = s.Length;
        // s.Length = 0; // Length 같은 메소드도 set 함수가 없으므로 입력 불가

    }
}
