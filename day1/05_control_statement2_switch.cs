using System;

// �ٽ� : switch ��

int num = 1;

switch (num)
{
    case 1 :
        Console.WriteLine("one");
        break; // c는 생략가능, c#은 생략불가
    case 2 :
        Console.WriteLine("two");
        break;
    default : 
        Console.WriteLine("other");
        break;
}


object obj = 3.4;
// c# switch는 아주 막강함. => 패턴 매칭 기능 있음

switch (obj)
{
    case 1 : break; // 값조사

    case double : // 타입 조사 (C언어에서는 불가능)
        Console.WriteLine("double");
        break;

    // default는 생략 가능
}
