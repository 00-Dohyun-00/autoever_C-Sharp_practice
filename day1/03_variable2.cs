using static System.Console;

// 핵심 : 초기화되지 않은 변수는 쓰기만 가능.
int n;
int a = 0;

// a = n;			// error
// WriteLine(n);	// error

n = a;	// 쓰는 것은 가능
a = n;  // 위 코드를 통해서 n은 값을 가지고 있다