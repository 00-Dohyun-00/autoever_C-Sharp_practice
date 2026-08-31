// 핵심 : 변수의 초기값을 지정하는 방법.

int n1;		// 초기화 안됨.

// n2 ~ n5는 동일한 코드
int n2 = 0;
int n3 = new int();

int n4 = default(int); // 
int n5 = default;	   // 

var v1 = default(int); // ok. int v1 = 0
var v2 = default;	   // error. default가 타입 알려주지 않음

