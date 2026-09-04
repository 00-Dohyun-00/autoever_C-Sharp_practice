using System;
using System.Collections.Generic;
using System.Linq;

// LINQ

class Program
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // 아래 코드의 원리
        // c 안에 '배열의 참조(복사본x)' 와 '람다표현식'을 보관한 것
        // 람다표현식은 아직 실행 안 됨. 즉, 조사한 것 아님
        var c = arr.Where(n => n % 2 == 1);

        arr[0] = 99;

        // 결과 예측해보기. 1 or 99 ?
        foreach( var n in c) // c가 보관한 arr의 모든 요소를 차례대로
                             // c가 보관한 함수에 보내서 true인 것 만 n으로
                             // 즉, 열거할 때 연산되는 것. >>지연된 실행<<.
        {
            Console.WriteLine(n);
        }

    }
}
