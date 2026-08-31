using static System.Console;

// 메소드와 프라퍼티
// 메소드 : "변수이름.이름()" 을 사용해서 호출
// 프라퍼티: "변수이름.이름"으로 접근 - 괄호 없음

string s = "abcd";

bool b = s.Contains('b'); // s의 메소드 호출, ()를 사용해서 인자 전달 가능
int  n = s.Length;       // s의 프라퍼티 사용. 인자 전달 x

WriteLine($"{b} {n}");


