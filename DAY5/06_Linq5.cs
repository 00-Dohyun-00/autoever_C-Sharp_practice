using System;
using System.Collections.Generic;
using System.Linq;

// Linq 선수 지식 #2. coroutine
// => C#은 coroutine을 반복자 기반으로 설계함

class Program
{
    // coroutine을 만들려면
    // 1. 반환 타입은 IEnumearable<int>
    // 2. 호출자에게 돌아가고싶을 때 "yield return"
    public static IEnumerable<int> foo()
    {
        // 사용자 코드 앞 부분에 컴파일러가 추가한 코드 있음.
        // 이 코드가 coroutine을 위한 준비를 하고
        // IEnumerable 객체 생성해서 반환

        Console.WriteLine("foo #1");
        yield return 1;
       
        Console.WriteLine("foo #2"); 
        yield return 2;
    }
    public static void Main()
    {
        /*
        var ret = foo();

        var e = ret.GetEnumerator();

        e.MoveNext(); // 이 순간 최초로 foo 안의 사용자 코드 실행
        Console.WriteLine("Main #1. foo 반환값 : {0}", e.Current);

        e.MoveNext(); // 중단된 이후부터 실행
        Console.WriteLine("Main #1. foo 반환값 : {0}", e.Current);
        */

        // 위 코드는 아래와 동일
        foreach (int i in foo())
        {
            Console.WriteLine("Main : {0}, i");
        }
    }
}