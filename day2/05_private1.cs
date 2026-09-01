using static System.Console;


// class Bike
// {
//     public int gear = 0;
// }

// class Program
// {
//     public static void Main()
//     {
//         Bike b = new Bike();

//         b.gear = -10; // -10단 기어는 없음. Bike에서 마이너스 못 만들게 해야함.

//     }
// }


class Bike
{
    // private: 자신의 메소드 안에서만 접근 가능하고 외부 함수에서는 접근 불가
    private int gear = 0;
}

class Program
{
    public static void Main()
    {
        Bike b = new Bike();

        b.gear = -10; // gear를 private로 설정해서 b가 죽음. 컴파일 에러.

    }
}


