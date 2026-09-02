using static System.Console;

// #1. reference type 의 변수는 null 로 초기화 될수 있습니다.
string s1 = "hello";
string s2 = null; // ok	힙에 객체 없음을 의미

// #2.value type 의 변수는 null 로 초기화  될수 없습니다.
int n1 = 0;
int n2 = null;	// error n2는 주소를 보관하는 변수가 아닌 정수값을 보관하는 변수

// #3. nullable value type
Nullable<int> n3 = null; // ok null 보관이 가능한 int 타입
int? n3 = null; // ok

// 정리
int n5 = null; // error
int? n6 = null; // ok

// stack에 이렇게 저장되어있는 것
struct Nullable<int>
{
    private bool hasValue;
    public int value;
}


