using static System.Console;

class Camera
{
    public void Take() { WriteLine("take picture");  }
}

class HDCamera
{
    public void Take() { WriteLine("take HD picture"); }
}

class Person
{
    public void UseCamera(Camera c) {  c.Take(); }
    public void UseCamera(HDCamera c) { c.Take(); }
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
    }
}

// 위 코드는 잘 동작하지만 ocp를 위반한 디자인.
// 카메라가 추가 될 때 마다 Person에 카메라를 추가해야 함.
