using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        using (FileStream fs = new FileStream("a.txt", FileMode.Create)) // <<
        {
             byte[] data = Encoding.UTF8.GetBytes("ABCD");

            fs.Write(data, 0, data.Length);

            // 자원의 관리는 메소드 아래 부분에서 사용자가 직접 하는 것은 위험
            //fs.Dispose(); 
        } // <= 이 블럭을 벗어날 때 fs.Dispose()가 자동으로 실행됨.
    }
}

// 위와 같은 기술을 C++/Rust 에서 RAII 라고 함. => 요즘 대부분의 언어의 특징
