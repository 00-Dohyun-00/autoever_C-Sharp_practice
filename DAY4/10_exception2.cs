using static System.Console;

// 함수는 실패할 수 있다.
// 실패를 어떻게 처리?

// 2. 메소드가 실패하면 그냥 프로세스 종료
// 단점: 호출자에게 에러를 처리할 기회를 주지 않고, 그냥 종료
// => 호출자에게 좋은 에러 처리 기술이 있었을 수도 있음
// => 메소드가 실패시 항상 호출자에게 보고해야 함.


class Database
{
    public Database(string dbname) { }

    public void Backup()
    {
        // 백업 실패시 아래처럼 프로세스 종료
       Processe p = Processes.GetCurrentProcess();
        p.Kill();

        return true;
    }
    public void Remove() => WriteLine("Remove DB");
}

class Program
{
    public static void Main()
    {
        Database db = new Database("product.db");

        db.Backup();    // A

        db.Remove();
    }
}
