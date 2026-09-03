using static System.Console;

// try parse 
class Program
{
	public static void Main()
	{
        // 문자열을 정수로 변경하는 방법
        // 방법 1. int.Parse()
        // => 변경할 수 없는 문자열 전달시 예외 발생 - 비정상 종료

        // #1. int.Parse() : 문자열을 정수로 변경
        int n1 = int.Parse("10");    // ok. 성공
        int n2 = int.Parse("Hello"); // 실패. 예외 발생


        // #2. int.TryParse()
        // 성공, 실패 여부는 반환하고 결과는 out parameter에 담아주는 메소드
        // try로 시작하는 함수는 대부분 out parameter
        int value;
        bool b = int.TryParse("10", out value);
        bool b2 = int.TryParse("Hello", out value); // 실패시 vlaue는 0

        // 실패시 무언가 하고싶을때
        if(b2 == false)
        {

        }

    }
}