using static System.Console;

// 58 page

// int  : 정수 한개 보관
// int? : 정수 한 개 보관 + bool(값 있음/없음) 보관

int n = 0;

// 1. int? <= int 의 경우
int? n1 = n; // ok

// int <= int?
int n2 = n1; // error n1은 null 보관이 가능한 int 타입이므로 n2에 대입할 수 없음

// int? 가 int 보다 크기 때문에.

int n3 = (int)n1; // ok. 단, n1 == null 이었다면 runtime error

// 안전하게 하려면 n1이 null인지 확인 후 대입
if(n1 != null)
{
    int n4 = (int)n1; // ok
} 

int n5 = n1.GetValueOrDefault(0); // n1이 null이면 0을 대입, null이 아니면 n1의 값을 대입

