using System;
using System.Runtime.CompilerServices;

// c# 내부
// namespace System
// {
//     class Console
//     {
//         // 출력, 입려고가 관련된 다양한 정적 메소드..
//     }
// }

Console.Clear(); // 화면 지우기

// // 화면 출력
// Console.Write("input your name >> ");

// // 사용자 입력: ReadLine 메소드
// string s = Console.ReadLine(); 

// Console.WriteLine("입력된 이름 {0}", s);


// 문자열이 아닌 정수/실수를 입력받는 방법
// 입력된 문자열을 직접 정수로 변경해서 사용해야 함.

Console.Write("input your age >> ");

// 10이라고 적어도 문자열로 입력 받음
string s = Console.ReadLine(); // "10"

// 정수로 변경
int n1 = Convert.ToInt32(s);
int n2 = int.Parse(s);

Console.WriteLine("입력된 나이 {0}", n1);



