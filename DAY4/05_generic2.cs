class Program
{
    // generic 문법

    // 아래 swap은 메소드가 아닌 메소드를 만드는 틀
    // 사용법: swap<원하는 타입>(ref n1, ref n2)

    public static void Swap<T>(ref T a, ref T b)
    {
        T tmp = a;
        a = b;
        b = tmp;
    }


    public static void Main()
    {
        int n1 = 10,  n2 = 20;
        double d1 = 1.1, d2 = 2.3;
                
        // Generic을 사용하는 정확한 표기법
        Swap<int>(ref n1, ref n2); // 1. Swap 틀의 T를 int 로 변경한 메소드 생성
                                   // 2. 생성된 메소드를 호출하는 기계어 코드 생성
        Swap<double>(ref d1, ref d2);

        // Generic 사용시 타입인자 생략 가능
        // => 이 경우 메소등 ㅣㄴ자를 보고 컴파일러가 타입 추론
        Swap(ref n1, ref n2);
        Swap(ref d1, ref d2);
    }
}