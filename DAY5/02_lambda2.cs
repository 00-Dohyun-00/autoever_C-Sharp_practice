using static System.Console;

// lambda expression 장점
class Program
{
    static bool IsMultipleOf(int n) { return n % 3 == 0; }

    public static void Main()
    {
        int[] array = { 1, 3, 6, 4, 5 };

        // 배열에서 처음 나오는 3의 배수를 찾고싶다
        int idx = Array.FindIndex(array, IsMultipleOf);

        // 배열에서 처음 나오는 k의 배수를 찾고싶다
        int k = 4; // 사용자가 입력한 값이라고 생각

        // 일반 메소드 문제점
        // => IsMultifpleOf 에서 main의 지역변수 k를 사용할 수 있는 방법이 없다

        // 람다 표현식 장점
        // => 람다 표현식 안에서 Main의 지역변수 k 사용 가능
        // => 지역변수 캡쳐
        int idx2 = array.FindIndex(array, (int n) => { return n % k == 0; });
    }
}
