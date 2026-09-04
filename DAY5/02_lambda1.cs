using static System.Console;

// lambda expression - 170 page

class Program
{
    static bool IsEven(int n) { return n % 2 == 0; }

	public static void Main()
    { 
        int[] array = { 1, 3, 6, 4, 5 };

        // 배열을 만들고, 배열에 대한 어떤 연산이 필요하면
        // => Array.정적메소드() 에서 찾기

        // Array.FindIndex(배열, 함수)
        // => 배열의 모든 요소를 차례대로 함수에 전달, 처음으로 true 를 반환하는 요소 검색
        //int idx = Array.FindIndex(array, IsEven);

        // 람다표현식
        // => 메소드 인자로 메소드를 전달할 때
        // => 메소드 이름이 아니라 구현 자체를 전달하는 문법

        // 핵심 1. 만드는 방법
        // => 메소드에서 반환 타입과 이름 제외 나머지 복사
        // => ()와 {} 사이에 => 표기
        // => 익명의 함수를 만드는 문법이라고도 표현

        // 장점 1. 가독성
        // 장점 2. 지역변수 캡쳐 기능 
        int idx = Array.FindIndex(array, (int n) => { return n % 2 == 0; });

        WriteLine($"{idx}");		
    }
}
