using static System.Console;

// 객체지향 프로그래밍의 기본 개념. 

// 아래 함수는 int 변수가 4개나 있어서 복잡해 보임
// => 사각형 개념이 필요하면 "Rect" 타입 먼저 만들기
// => 날짜 개념이 필요하면 "Date" 타입 먼저 만들기
// => 필요한 타입을 먼저 설계 == 객체지향 프로그램의 핵심!

// 사각형의 면적을 구하는 함수 
// int GetRectArea(int x1, int y1, int x2, int y2)
// {
//     return (x2 - x1) * (y2 - y1);
// }

// int area = GetRectArea(1, 1, 10, 10);


class Rect
{
    // 사각형의 정보를 보관할 데이터
    int x1 = 0;
    int y1 = 0;
    int x2 = 0; 
    int y2 = 0; 

    // 사각형에 관련된 기능을 제공하는 함수
    public int GetRectArea()
    {
        return (x2 - x1) * (y2 - y1);
    }

}

// Rect라는 타입이 있으면 사용자는 아래처럼 사용함
// top level 방식의 코드는 class 문법 지원 못 함. => 메인 메소드 직접 만들기, 또는 코드 맨 위에 배치
// Rect rc = new Rect();
// int area = rc.GetRectArea();

class Program
{
    public static void Main()
    {
        Rect rc = new Rect();
        int area = rc.GetRectArea();

        Console.WriteLine("면적 : {0}", area);
    }
}
