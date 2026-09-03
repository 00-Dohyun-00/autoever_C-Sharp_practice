using static System.Console;


// 인터페이스 : 규칙을 만드는 문법
// 규칙 : 모든 카메라는 아래 인터페이스를 구현해야 한다. 
//        인터페이스 안에 있는 메소드를 만들라는 것

interface ICamera
{
    void Take(); // public 등의 접근지정자를 표기하지 않고, 메소드 구현도 없음.
                 // 메소드 형태(이름, 반환타입, 인자)만 표기
}

// 아직 진짜 카메라는 없지만 규칙이 생김.
// 카메라 사용자는 규칙대로만 사용하면 됨.
class Person
{
    // 핵심: 인자로 구체적 제품의 이름이 아닌 인터페이스를 사용.
    //       => 규칙을 구현한 모든 카메라 객체를 받을 수 있다.
    public void UseCamera(ICamera c) { c.Take(); } // take 함수가 있어야 한다는 규칙
}

// 실제 카메라 제작자는 규칙대로 만들어야 함.
// => 상속과 동일하게 ": 인터페이스이름" 으로 표기

class Camera : ICamera
{
    public void Take() { WriteLine("take picture"); } // take 함수를 만듦.
}

class HDCamera : ICamera
{
    public void Take() { WriteLine("take HD picture"); }
}

class UHDCamera : ICamera
{
    public void Take() { WriteLine("take UHD picture"); }
}

class Program
{
    public static void Main()
    {
        Person p = new Person();
        Camera c = new Camera();

        p.UseCamera(c);

        HDCamera hc = new HDCamera();

        p.UseCamera(hc);

        UHDCamera uhc = new UHDCamera();
        p.UseCamera(uhc); // Person 객체에 새로운 제품 전달. Person 코드를 수정하지 않아도 사용할 수 있음.
    }
}

// 용어

// 인터페이스: 지켜야 하는 규칙만을 가진 것 => 함수 이름만.
// 추상 클래스 : 지켜야 하는 규칙 + 다른 멤버도 있는 것.

// 강한 결합(tightly coupling)
// => 하나의 클래스가 다른 클래스 사용시, 클래스 이름을 직접 사용하는 것
// => Person의 "UserCamera(HDCamera c)"의 경우
// => 경직된, 확장성 없는, 교체 불가능한 디자인. 

// 약한 결합(loosely coupling)
// => 하나의 클래스가 다른 클래스 사용시, 클래스 이름을 직접 사용하지 않고 규칙을 담은 interface 이름을 쓰는 것.
// => Person의 "UserCamera(ICamera c)"의 경우
// => 유연한, 확장성, 교체 가능한 디자인.