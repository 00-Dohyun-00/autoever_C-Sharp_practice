using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// Sliding Puzzle Game 2
// 전체 그림이 아닌 한 블럭만 출력하기

class MainWindow : Window
{
    // 1. 데이터 관리에 필요한 필드 선언
    private const int CNT = 5;               // 5 * 5 게임
    private const int EMPTY = CNT * CNT - 1; // 24번은 EMPTY

    // 한개 블럭의 크기 관리
    private double block_width;
    private double block_height;


    public MainWindow()
    {
        //Uri uri = new Uri("C:\\Users\\한국전파진흥협회\\source\\repos\\DAY2\\DAY5\\dog.jpg"");
        Uri uri = new Uri("..\\..\\..\\dog.jpg", UriKind.Relative);

        // 그림을 메모리에 load
        BitmapImage bitmap = new BitmapImage(uri);

        // 2. 한 블럭의 크기 계산
        block_width = bitmap.Width / CNT;
        block_height = bitmap.Height / CNT;

        // 3. bitmap 에서 일부 영역을 자른 새로운 비트맵
        Int32Rect rc = new Int32Rect(0, 0, (int)block_width, (int)block_height);

        CroppedBitmap crop = new CroppedBitmap(bitmap, rc);

        // 4. Image 객체 생성시 crop된 비트맵 사용
        Image img = new Image();
        img.Source = crop;
        img.Stretch = System.Windows.Media.Stretch.Fill;


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