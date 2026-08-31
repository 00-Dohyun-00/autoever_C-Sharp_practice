using System;

// 핵심 : 입력 버퍼가 아닌 키보드로 부터 직접 입력 받기

Console.ReadLine();
Console.Read();

// 위 두 개는 입력 버퍼에서 가지고 오는 것. 
// 사용자 -> 입력 버퍼. enter를 해야 종료

// 입력 버퍼가 아닌 사용자로부터 직접 입력
// enter 필요없ㅇㅁ 
// ConsoleKeyInfo key = Console.ReadKey(); // 입력 자체도 화면에 echo
ConsoleKeyInfo key = Console.ReadKey(true); // 입력 자체는 echo 안 함

Console.WriteLine("입력된 키보드 {0}", key.KeyChar);

