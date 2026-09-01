// 편의표기법.cs

using System.Drawing;

// #1. C#에서 모든 종류의 객체(변수)를 만들때는 new를 사용합니다.

int n = new int();
double d = new double();
string s = new string("ABC");

Rectangle r = new Rectangle(0,0,5,5);

// #2. 일부 표준 타입에 대해서, 다른 언어와 유사하게 간략히 사용할 수 있도록 편의 표기법을 제공

int n1 = 0; // int n1 = new int(); 와 동일
double d1 = 0.0;
string s2 = "ABC";

// Rectangle 등은 컴파일러가 인식하는 표준 타입이 아닌 class 문법으로 만든 타입. => 편의 표기법 안 됨. new 필요.
// c/c++ 사용자 참고 : new를 사용했다고 항상 "동적할당" 되는 것은 아님(힙에 무조건 올라가는건 아님).