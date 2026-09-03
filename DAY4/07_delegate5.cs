using System;
using System.Security.Cryptography.X509Certificates;
using static System.Console;


//delegate bool Predicate<T>(int n); // 이미 C# 표준에 있음

// delegate는 언제 사용하나
// 1. GUI의 event 처리 - 버튼 누를 때 이벤트 처리
// 2. 메소드 인자로 다시 메소드(함수)를 받고싶을 때

// delegate 사용자가 만들어 사용하기도 하고 미리 만들어진 것도 있음
class Program
{

    public static int MyFindIndex(int[] arr, Predicate<int> f)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            // 모든 요소를 차례대로 2번째 인자로 받은 함수에 전달해서 true를 반환하는 것을 찾음
            if (f(arr[i]) == true) return i;
        }
        return -1;
    }

    public static void Main()
    {
        int[] x = { 1, 2, 3, 4, 5 }; 

        // FindIndex 직접 구현해보기
        //int ret2 = Array.FindIndex(x, Foo);

        int ret2 = MyFindIndex(x, Foo);

        Console.WriteLine("{0}", ret2);

    }

    public static bool Foo(int n)
    {
        return n % 3 == 0;
    }

}
