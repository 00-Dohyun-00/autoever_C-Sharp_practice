// Class 도 Generic으로 할 수 있음

class Point<T>
{
    private T x = 0; // error => 임의의 타입이므로 string 등이 올 수 있어 0으로 초기화 될 수 없음
    private T y = 0; // error

    private T x = default;
    private T y = default; // 수치 타입이면 0
                           // Reference 타입이면 null
                           // 그 외 타입이면 인자없는 생성자 호출

    public Point(T a, T b)
    {
        (x, y) = (a, b);
    }
}

class Program
{
    public static void Main()
    {
        // Generic method : 타입 인자 생략 가능
        // Generic class : 타입 인자 생략 불가 - 반드시 표기
        Point<int> p1 = new Point<int>(1, 2);
        Point<double> p2 = new Point<double>(1.1, 2.2);

        // 단, 우변은 간편하게 사용 가능 - 타입 자체의 생략
        Point<double> p3 = new (1.1, 2.2);

       List<int> s1 = new List<int>(); // 어제 사용한 코드
       List<int> s1 = new (); // 이렇게도 사용 가능

        // Collection 만들 때 가장 많이 사용됨.
        // 저장할 요소의 타입을 사용자가 결정하도록
    }
}