using static System.Console;

// 메소드는 다양한 이유로 실패할 수 있다.
// 실패의 이유에 대한 정보를 담을 수 있도록 별도의 타입을 설계하기.
// => 클래스 이름만으로도 좋은 설명이 될 수 있음
// => 이 때 Exception 이라는 클래스에서 파생해야 함.

class FileNotFoundException : Exception
{
    public string filename;
    // 이외에도 다양한 정보 담기
}

class NotWorkDisconnectException : Exception
{
    //
}

class Database
{
    public Database(string dbname) { }

    public void Backup()
    {
        if (실패)
        {
            throw new FileNotFoundException(); 
        } else if (다른 이유로 실패){
            throw new NotWorkDisconnectException();
        }

    }
    public void Remove() => WriteLine("Remove DB");
}

class Program
{
    public static void Main()
    {
        Database db = new Database("product.db");

        // 예외 발생 가능성이 있는 함수(메서드)호출 시 try 블럭 안에서 해야 한다
        try
        {
            db.Backup(); // 예외 발생하면 바로 catch로 이동
            db.Remove();
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("예외발생");
            // 여기서 발생된 문제를 해결할 수 없다면 사용자에게 알리고 프로그램 종료
            // 여기서 종료하지 않으면 프로그램은 계속 실행. 
        }
        catch (NotWorkDisconnectException ex)
        {
            Console.WriteLine("네트워크 연결 안 됨 예외 발생");
        }
        catch (Exception ex) {
            Console.WriteLine("위에서 처리되지 못 한 예외");
        }
    }

        //db.Remove();

    }
}

// 심각한 오류 : 예외 사용
// 간단한 오류 : 반환값으로 알려주는 경우가 많음
