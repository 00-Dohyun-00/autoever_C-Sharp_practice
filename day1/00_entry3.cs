// 엔트리 포인트

// Top Level Programming 방식 원리(교제 6p)

using System.Diagnostics.Contracts;

System.Console.WriteLine("hello, C#");

// 위 한 줄을 컴파일러가 아래처럼 수정한 것

class CompilerGeneratedName
{
    public static void Main()
    {
        System.Console.WriteLine("hello, C#");
    }
}