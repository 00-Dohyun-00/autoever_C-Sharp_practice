
// namespace 개념
// => 프로그램 또는 라이브러리의 요소를 논리적으로 분할해서 이름 충돌을 막을 때 사용

Audio.Card c1;
Video.Card c2;
namespace Audio
{
    class Card
    {
        
    }
}

namespace Video
{
    class Card
    {
        
    }
}


 
// c# 의 모든 기본요소는 system namespace 안에 있음
// c# 내부 코드

// namespace System
// {
//     // .. 모든 c# 기본 라이브러리들..
//     class Console
//     {
//         public static void WriteLine(string s){...}
//     }
// }

// System.Console.WriteLine("aa")
  
  
   