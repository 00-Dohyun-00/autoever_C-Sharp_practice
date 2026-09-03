using static System.Console;

// Handler: 함수 호출 정보를 보관하는 타입
delegate void Handler();

class Button
{
    // =, +=, -= 모두 사용 가능
    //public Handler handler = null;
    
    // 함수 등록시 = 안 됨. +=, -= 만 가능
    public event Handler handler = null;


    public void UserPressButton()
    {
        // 버튼을 누르면 등록된 함수를 호출
        if (handler != null) { handler(); }
    }
}

class Program
{
    public static void Main()
    {
        Button btn1 = new Button(); // 이순간 GUI 버튼이 만들어 지고

        //btn1.handler = Foo;
        //btn1.handler = Goo; // 실수로 += 대신 =를 사용하면 이전 등록 함수 Foo 대신 Goo로 덮어씌워짐.

        btn1.handler += Foo;
        btn1.handler += Goo;

        btn1.UserPressButton(); 	
    }

    public static void Foo() => WriteLine("button1 click");
    public static void Goo() => WriteLine("button2 click");
}