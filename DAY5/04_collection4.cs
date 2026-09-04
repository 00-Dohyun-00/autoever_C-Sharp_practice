using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Console;

class Program
{
    public static void Main()
    {
        List<int> c1 = new List<int>();
        LinkedList<int> c2 = new LinkedList<int>();

        for (int i = 0; i < 10; i++)
        {
            c1.Add(i);
            c2.AddLast(i);
        }
        //---------------------------------------------
        // 컬렉션의 모든 요소에 접근하는 3가지 방법
        // #1. foreach 사용 
        // => 가장 권장
        // => c1의 위치에는 모든 컬렉션 사용 가능 (배열, list, linkedlist...)

        foreach(var e in c1)
        {
            Console.WriteLine(e);
        }

        // #2. 반복자(열거자) 사용 
        // 전체가 아닌 일부만 접근하고싶을 때 
        var e1 = c1.GetEnumerator();

        // 전체
        while (e1.MoveNext())
        {
            int n = e1.Current;
        }

        // 일부만
        e1 = c1.GetEnumerator(); 
        int n1 = e1.Current;
        e1.MoveNext();
        int n2 = e1.Current;


        // #3. for 와 [] 사용..
        // => List는 가능하지만
        // => LinkedList는 안 됨
        // 위의 반복자(열거자)는 모든 컬렉션 가능
        c1[0] = 1;
        c1[1] = 2;

    }
}