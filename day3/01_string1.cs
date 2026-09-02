using System;
using static System.Console;

string s1 = "AB";
string s2 = s1;

WriteLine($"{s2[0]}");

//s2[0] = 'X'; // error : string은 immutable(불변) 타입이기 때문에, 문자열의 특정 문자를 변경할 수 없음.

WriteLine($"{object.ReferenceEquals(s1, s2)}"); // 같은 객체를 가리키는지 확인, true

s2 = "XY"; // s2가 새로운 문자열 객체를 가리키게 됨. s2 = new string(new char[] {'X', 'Y'}); 와 동일함.

WriteLine($"{object.ReferenceEquals(s1, s2)}"); // false

WriteLine($"{s1} {s2}"); 

