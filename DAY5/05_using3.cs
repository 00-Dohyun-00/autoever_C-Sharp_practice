using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        // ~C#(8.0)
        // using(...){}

        // C#(9.0) 아래처럼 가능
        using (FileStream fs = new FileStream("a.txt", FileMode.Create)) // using 만 적으면 {}로 묶지 않아도 이 메소드가 끝나는 즉시 fs.Dispose()

        byte[] data = Encoding.UTF8.GetBytes("ABCD");

        fs.Write(data, 0, data.Length);

    } // <- fs.Dispose()
}

