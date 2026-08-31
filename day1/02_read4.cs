using System;

// 핵심 : 입력 버퍼가 아닌 키보드로 부터 직접 입력 받기

Console.Write("press any key >> ");

// ReadLine : 문자열 입력
// Read : 문자 하나 입력
int n = Console.Read();	 //"ABCD"입력

Console.WriteLine(n); // 65 (A 아스키코드)

n = Console.Read();	 // 입력 대기하지 않고 버퍼에 있던 다음 문자 꺼냄

Console.WriteLine(n); // 66 (B 아스키코드)

// 위 두 개 함수는 모두 입력을 종료하기 위해 enter 필요

