using static System.Console;

// 함수는 실패할 수 있다.
// 실패를 어떻게 처리?

// 방법 3
// 1. 메소드가 실패하면 호출자에게 보고
//      => 호출자가 던져진 예외를 무시하면 프로그램은 더 이상 실행되면 안 된다.
//      => 종료되어야 한다

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

        db.Backup();    // A

        db.Remove();
    }
}
