using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

// 배열, List, LinkedList
// => key만 보관(데이터만 여러개 보관)

// Dictionary - key 값을 가지고 value 를 보관하는 collection

class Program
{
    public static void Main()
    {
        Dictionary<string, string> dic = new Dictionary<string, string>();

        dic["mon"] = "월요일";
        dic["tue"] = "화요일";
        dic["wed"] = "수요일";

        string s = dic["mon"]; // 월요일

        Console.WriteLine(s);
                
    }
}

// c#에는 20개가 넘는 collection이 있음. 
// => tree, hash, stack, queue 등 자료구조의 표현
