using System;

// .Net에서 4바이트 정수에 대한 정확한 타입은 Int32
// int라는 타입은 Int32의 별명

// 아래 두 줄 동일함
int   n1 = 0;
System.Int32 n2 = 0;

// Int32는 System 안에 있음
// int는 키워드(컴파일러가 인식하는 글자)
Int32 n3 = 0; // ok. using System이 있으면 System
System.int   n4 = 0;  // error

// C# 키워드 사용 권장
double d1 = 0; // C# 키워드
Double d2 = 0; // CTS에 정의된 이름
System.Double d3 = 0;

string s1 = "A";
String s2 = "A";
System.String s3 = "A";
