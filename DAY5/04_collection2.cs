using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Console;

// 핵심 : 다양한 종류의 Collection 이 있다

class Program
{
    public static void Main()
    {
        // List : 동적 배열. 모든 요소를 연속된 메모리에 보관
        //                   모든 요소에 대한 순차 접근이 빠르다.
        //                   중간에 삽입/삭제가 느리다.

        // LinkedList : 모든 요소를 떨어진 메모리 형태로 보관
        //                  모든 요소에 대한 순차 접근이 느리다
        //                   중간에 삽입/삭제가 빠르다.

        // 잘 모른다면 list를 사용
        // => 연속된 메모리가 캐시 적중률이 좋음
        // => CPU의 캐시에 여러 요소가 놓일 확률이 높다는 것(list)는 연속되어있으므로.

        // 자료구조 공부

        List<int>       c1 = new List<int>();
        LinkedList<int> c2 = new LinkedList<int>();

        for (int i = 0; i < 10; i++)
        {
            c1.Add(i); // List는 Add 메소드
            c2.AddLast(i); // LinkedList는 AddLast 메소드

        }
    }
}