using System.Windows;
using System.Windows.Input;

// WPF의 핵심 클래스 2개

class MainFrame : Window
{
    protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
    {
        // this : 현재 객체(윈도우)의 포인터
        Point pt = e.GetPosition(this);    // 내 윈도우를 기준으로 좌표를 알려달라

        Console.WriteLine("LButtonDown : {0}, {1}", pt.X, pt.Y);
    }

    // 잘되신 분은 마우스 오른쪽 버튼 누를때 로깅해 보세요

    protected override void OnMouseRightButtonDown(MouseButtonEventArgs e)
    {
        Console.WriteLine("RButtonDown");
    }
}

class Program
{
    [STAThread]
    public static void Main()
    {
        //      Window w = new Window();
        MainFrame w = new MainFrame();
        w.Show();

        Application app = new Application();
        app.Run();
    }
}