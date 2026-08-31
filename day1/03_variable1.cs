// #1. Data type
int    n = 0;
double d = 3.4;
char   c = 'A'; //''
string s = "hello"; //""

// #2. var
// 데이터 타입ㅇㄹ 생략하고 var
// 초기값으로 타입을 추론해 달라고 하는 것
// C# 에서 많이 쓰임
var v1 = 10;		// int v1 = 10;
var v2 = 3.4;		// double v3 = 3.4;
var v3 = "hello";	// string v3 = "hello";

// #3. literal
int a1 = 10;		// 10진수
int a2 = 0x10;		// 16진수
int a3 = 0b10;		// 2진수
int a4 = 010;       // 8진수

// 큰 리터럴 표기시 읽기 좋게 하기 위해 digit separator 사용가능
int a4 = 1000000;	
int a5 = 1_000_000; // 컴파일 하면 _는 제거됨


