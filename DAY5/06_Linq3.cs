using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] arr = { "kim", "park", "choi", "lee", "jung" };

        var c = arr.Where(s => s.Contains('i')) // "kim", "choi"
                   .OrderBy(s => s.Length)      // "kim", "choi"
                   .Select(s => s.ToUpper());   // "KIM", "CHOI"

        // 위 코드는 아직 람다표현식이 실행되지 않은 것
        // c 안에 배열의 참조와 3개의 람다표현식 만 보관한 것.
        // 열거할 때 적용 

        foreach (var n in c)
        {
            Console.WriteLine(n);
        }
    
    }
}

// 위 코드는 "SQL" 처럼 보임
// 그래서 이 기술의 이름이 Language Integrated Query 라고 해서 LINQ 라고 함.

// C# : 2007년에 LINQ 소개 - 배열 뿐만 아니라 대부분의 Collection에 사용 가능
// Java Stream : 2014년에 도입 - LINQ와 거의 동일 개념
// Rust Iterator : 2015년 - 반복자 자체에 위와 동일 개념 제공
// C++ Views : 2020년 - C++20 기술의 std::views 라이브러리
