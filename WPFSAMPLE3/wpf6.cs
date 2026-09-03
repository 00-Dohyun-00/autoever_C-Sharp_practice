// wpf1,cs

using System.Windows;
using System.Windows.Controls;

// 4. Layout 개념
// => Content 속성에는 "한 개 객체만 연결" 가능


class MainFrame : Window
{

    // 1. 필요한 컨트롤을 모두 필드로 선언
    private TextBox txtbox = null;
    private Button button = null;
    private Slider slider = null;


    public MainFrame()
    {

        // 2. 필요한 layout을 만들고 메인 윈도우에 부착
        StackPanel sp = new StackPanel();
        Content = sp;

        // 3. 각 컨트롤 객체를 생성 후, 기본 속성 설정, layout 자식으로 등록
        txtbox = new TextBox();
        button = new Button { Content = "확인"};
        slider = new Slider { Minimum = 20, Maximum = 100};

        sp.Children.Add(button);
        sp.Children.Add(txtbox);
        sp.Children.Add(slider);

        // 4. 컨트롤 이벤트를 처리하기 위한 함수 연결'

        button.Click += Button_Click;
        slider.ValueChanged += Slider_ValueChanged;
        

    }

    private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
        double val = slider.Value;
        txtbox.FontSize = val;
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        string s = txtbox.Text;
        Console.WriteLine(s);
        txtbox.Text = "";
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