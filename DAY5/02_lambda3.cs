using static System.Console;

class Program
{
    public static void Main()
    {
        int[] array = { 1, 3, 6, 4, 5 };

        int k = 3;
        // 람다표현식 기본 모양
        int idx1 = Array.FindIndex(array, (int n) => { return n % k == 0; });

        // 람다표현식 구현시 {} 생략 가능 - expression bodied
        int idx2 = Array.FindIndex(array, (int n) => n % k == 0; );

        // 대부분의 경우 컴파일러가 인자 타입도 추론 가능
        // => 1번째 인자인 array의 요소 타입으로 추론
        // => (int n)에서 int 제거 가능
        int idx2 = Array.FindIndex(array, (n) => n % k == 0; );

        // 인자가 한 개라면 괄호도 생략 가능
        // 단, 인자가 두 개면 생략 안 됨 (a, b) 형태로 표현
        int idx2 = Array.FindIndex(array, n => n % k == 0; );




    }
}
