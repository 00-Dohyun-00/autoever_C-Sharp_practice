using System.Windows;

// WPF 프로그램의 핵심은 2개 클래스
// 1. Window 로부터 파생된 클래스 : 아래 코드의 MainFrame
//    => 주된 UI 를 책임

// 2. Application 에서 파생된 클래스 : 아래 코드의 App
//    => 프로그램 시작, 종료, event 루프 담당
//    => Main 함수도 이곳에서 작성

class MainFrame : Window
{
	public MainFrame() 
	{
	}
}

class App : Application
{
    [STAThread]
    public static void Main()
    {
		App app = new App();

        MainFrame w = new MainFrame();
        w.Title = "Hello, WPF";
        w.Show();
        
        app.Run();
    }
}