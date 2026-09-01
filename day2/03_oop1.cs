using static System.Console;

// 객체지향 프로그래밍의 기본 개념. 

// 아래 함수는 int 변수가 4개나 있어서 복잡해 보임
// => 사각형 개념이 필요하면 "Rect" 타입 먼저 만들기
// => 날짜 개념이 필요하면 "Date" 타입 먼저 만들기
// => 필요한 타입을 먼저 설계 == 객체지향 프로그램의 핵심!

// 사각형의 면적을 구하는 함수 
int GetRectArea(int x1, int y1, int x2, int y2)
{
    return (x2 - x1) * (y2 - y1);
}

int area = GetRectArea(1, 1, 10, 10);
