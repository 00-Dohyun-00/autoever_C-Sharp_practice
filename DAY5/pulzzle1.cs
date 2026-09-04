using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

// Sliding Puzzle Game 1
// 화면에 그림 출력하기

class MainWindow : Window
{
    public MainWindow()
    {
        // 1. 자원의 위치를 관리하는 객체 생성
        // universal resource identiffy
        // 그림파일을 현재 프로젝트 폴더에 놓기
        //Uri uri = new Uri("C:\\Users\\한국전파진흥협회\\source\\repos\\DAY2\\DAY5\\dog.jpg"");
        Uri uri = new Uri("..\\..\\..\\dog.jpg", UriKind.Relative);

        // 그림을 메모리에 load
        BitmapImage bitmap = new BitmapImage(uri);

        // 3. bitmap 안에 있는 그림을 화면에 그릴 때 사용하는 image 객체 생성
        // BitmapImage : 그림 데이터 자체의 관리
        // Image : BitmapImage가 관리하는 데이터를 화면 출력
        // => 역할을 분리한 것
        Image img = new Image();
        img.Source = bitmap;
        img.Stretch = System.Windows.Media.Stretch.Fill;

        // 4. Image 객체를 MainWindow Content 로 연결
        Content = img;
       

    }
}

class App : Application
{
    [STAThread]
    public static void Main()
    {
        App app = new App();

        MainWindow w = new MainWindow();
        w.Title = "Hello, WPF";
        w.Show();

        app.Run();
    }
}