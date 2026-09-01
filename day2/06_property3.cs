// public field vs setter/getter

class Person
{
    // 이름 관례
    // 필드 모두 소문자, 프라퍼트 첫 글자 대문자
    private int age;

    public int Age
    {
        get => age; // get{ return age; }와 같음
        set{ 
            if(value > 0 && value < 100) age = value;
         }
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
