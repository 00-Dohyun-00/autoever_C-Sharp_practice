using static System.Console;

// 함수는 실패할 수 있다.
// 실패를 어떻게 처리?

// 방법 4

class Database
{
    public Database(string dbname) { }

    public void Backup()
    {
        if (실패)
        {
            throw new Exception(); // 실패했음을 던져줌
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
        catch(Exception ex)
        {
            Console.WriteLine("예외발생");
            // 여기서 발생된 문제를 해결할 수 없다면 사용자에게 알리고 프로그램 종료
            // 여기서 종료하지 않으면 프로그램은 계속 실행. 
        }

        //db.Remove();

    }
}
