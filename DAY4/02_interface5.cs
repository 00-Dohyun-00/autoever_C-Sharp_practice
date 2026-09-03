using static System.Console;

class Label : IComparable
{
    private string title;
    public Label(string s) => title = s;


    // IComparable 안에 있는 CompareTo 는 인자가
    // "object" 타입 입니다.
    // 자신에 타입에 맞게 캐스팅해서 사용
    public int CompareTo(object? obj)
    {
        Label other = (Label)obj;

        return title.CompareTo(other.title);
    }
}



class Program
{
    public static void Main()
    {
        Label d1 = new Label("GOOD");
        Label d2 = new Label("BAD");

        // 사용자 정의 타입인 Label 도 크기 비교가 되도록 해봅시다.
        int ret = d1.CompareTo(d2);

        M1(d1); 
    }
    public static void M1(IComparable obj)
    {
    }
}