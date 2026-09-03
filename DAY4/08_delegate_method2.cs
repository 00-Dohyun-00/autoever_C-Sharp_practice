using static System.Console;

delegate void MyFunc(int arg);

class Program
{
    public static void SMethod(int arg) => WriteLine("SMethod");
    public        void IMethod(int arg) => WriteLine("IMethod");

    public static void Main()
    {
        // 이전 예제 : 다른 클래스의 메소드 호출
        // 이번 예제 : 자신의 메소드 호출에 대해서


        // 1. 자신의 static method 호출하기
        Program.SMethod(1); // 정확한 표기법 : 클래스이름.메소드이름();
        SMethod(); // 자신과 같은 클래스에 있다면 클래스 이름 생략 가능

        // Delegate에 등록시
        MyFunc f1 = Program.SMethod;
        MyFunc f2 = SMethod;

        // 2. 인스턴스 메소드 호출
        //IMethod(1); //error. 객체가 없음
        Program pg = new Program();
        pg.IMethod (1);

        // Delegate 등록스
        MyFunc f3 = pg.IMethod; //ok

        pg.InstanceMethod(1);


    }

	public void InstanceMethod()
	{

        // 3. 자신의 인스턴스 메소드 안에서 다른 인스턴스 메소드 호출
        IMethod(1); // ok this.IMethod(1) 로 컴파일러가 변경함
        this.IMethod(1); // ok

        MyFunc f1 = Program.SMethod;
        MyFunc f2 = SMethod;
        MyFunc f3 = this.IMethod;
        MyFunc f4 = IMethod;

	}
}
