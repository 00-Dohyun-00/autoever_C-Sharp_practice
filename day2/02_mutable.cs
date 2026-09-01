// mutable.cs

// 변수와 객체
// 객체: 메모리에 만들어지는 모든 것을 부르는 용어
//      결국 변수도 객체

// mutable   : 객체의 상태를 변경할수 있는것
// immutable : 객체의 상태를 변경할수 없는것

// #1. int 타입의 객체(변수)는 mutable 합니다.
int n = 10;
n = 20;    // ok


// #2. string 타입의 객체는 immutable 합니다.

string s1 = "abcd";

char c = s1[0]; // ok
s1[0] = 'x';    // error

// string의 메소드 중에서 자신의 상태를 변경할 수 있는 메소드는 없음

string s2 = s1.ToUpper();

// ToUpper 메소드
// s1은 변경 안 됨. 대신 s1의 모든 문자를 대문자로 만든 새로운 문자열 반환

Console.WriteLine(s1); // "abcd"
Console.WriteLine(s2); // "ABCD"


// #3. 변수에 담긴 문자열을 변경하려면?
// string : immutable. 변경불가
// StringBuilder : mutable. 변경가능



