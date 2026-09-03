using static System.Console;

// 함수는 실패할 수 있다.
// 실패를 어떻게 처리?

// 1. 반환값으로 알려주기 - C언어의 대표적인 기술
// 단점: 호출자가 반드시 에러를 처리해야 하는 것은 아니다. 무시할수도 있다. Main함수의 A 부분
// 발생된 에러를 무시하고 계속 실행하면 더 큰 문제 발생 가능


class Database
{
    public Database(string dbname) { }

    public void Backup()
    {
        //if (실패) return false;

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
