// wpf1,cs

using System.Windows;
using System.Windows.Controls;

// 4. Layout 개념
// => Content 속성에는 "한 개 객체만 연결" 가능


class MainFrame : Window
{

    private Button btn1 = null;
    private Button btn2 = null;
    private Button btn3 = null;


    public MainFrame()
    {

        Title = "Hello, WPF";
        Width = 300;
        Height = 600;

        // 1. Layout 생성
        StackPanel sp = new StackPanel();

        //sp.Orientation = Orientation.Horizontal;

        // 2. 윈도우의 Content로 sp 연결
        Content =sp;

        // 3. 이제 layout 위에 다양한 컨트롤 연결
        //sp.Children.Add(new Button { Content = "button1" });
        //sp.Children.Add(new Button { Content = "button2" });
        //sp.Children.Add(new Button { Content = "button3" });

        btn1 = new Button { Content = "button1" };
        btn2 = new Button { Content = "button2" };
        btn3 = new Button { Content = "button3" };

        sp.Children.Add(btn1);
        sp.Children.Add(btn2);
        sp.Children.Add(btn3);

        btn1.Click += buttonClick;
        btn2.Click += button2Click;
        btn3.Click += button3Click;

    }

    private void buttonClick(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("Button Clicked");
    }
    private void button2Click(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("Button2 Clicked");

        // 버튼 3의 글자를 변경
        btn3.Content = "Hello";
    }

    private void button3Click(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("Button3 Clicked");
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