// wpf1,cs

using System.Windows;
using System.Windows.Controls;

// 3. Content 속성
// => WPF 핵심
// => 모든 ui는 자신의 content에 지정된 요소를 적절한 방식으로 보여준다.
class MainFrame : Window
{
    public MainFrame()
    {
        // 윈도우 생성시 자신을 초기화
        // 즉, 다양한 속성을 여기서 설정
        //this.Title = "Hello, WPF";
        Title = "Hello, WPF";
        Width = 300;
        Height = 600;
        //Content = "ABCD";
        
        // content에 버튼 연결
        Button btn = new Button();
        btn.Content = "확인";
        Content = btn; 
        
    }
}

class App : Application
{
    [STAThread]
    public static void Main()
    {
        MainFrame w = new MainFrame();
        
        w.Show();

        App app = new App();
        app.Run();  

    }
}