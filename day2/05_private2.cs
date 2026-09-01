using static System.Console;

// 캡슐화 (encapsulation)
// => 타입을 만들 때 상태를 나타내는 데이터는 private에 놓아서 외부에 잘못된 사용으로 객체의 상태가 불안해지는 것을 막는다. 
// => 객체의 상태는 잘 정의된 메소드에 의해서만 변경될 수 있다.

// 정보 은닉(information hiding)
// => Bike 사용자는 필드(gear)에 대해서는 알 필요 없다.
// => 메소드만 알면 된다.


class Bike
{
    // private: 자신의 메소드 안에서만 접근 가능하고 외부 함수에서는 접근 불가
    private int gear = 0;

    // public 다른 곳에서도 호출 가능 
    public void SetGear(int g)
    {
        // 자신의 상태를 변경하기 전에 인자값의 유효성을 먼저 확인
        if(g > 0 && g < 20)
        {
            gear = g;
        }
        
    }
}

class Program
{
    public static void Main()
    {
        Bike b = new Bike();

        // b.gear = -10; // gear를 private로 설정해서 b가 죽음. 컴파일 에러.
        b.SetGear(-10);

    }
}