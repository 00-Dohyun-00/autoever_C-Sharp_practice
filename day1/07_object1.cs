using System;

// 메소드 개념

// 1. 모든 변수는 "값"을 보관
int n1 = 10;
string s1 = "hello";

// 2. 모든 변수는 자신이 보관하는 "값"을 사용해서 연산을 수행하는 메소드를 제공한다
// 변수가 제공하는 함수는 "메소드"라고 한다
string s = n1.ToString();
bool b = s1.Contains('a');

Console.WriteLine(b);


string s2 = "  AAABB  "; // 앞뒤 공백 2개씩
string s3 = s2.Trim();

Console.WriteLine(s3);

// 변수 뿐 아니라 리터럴도 메소드 사용 가능
string s4 = 10.ToString();
