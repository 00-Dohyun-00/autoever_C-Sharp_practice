using System.Windows;
using System.Windows.Controls;

// Grid Layout

class MainWindow : Window
{
    public MainWindow()
    {
        // 1. Grid 객체 생성
        Grid grid = new Grid();
        Content = grid;

        // 2. grid 의 row와 column은 몇 개인가
        // 아래처럼 하면 쉬워보이지만 각 row, column의 속성 지정이 불편
        //grid.Row = 2;
        //grid.Column = 2;

        RowDefinition r1 = new RowDefinition();
        RowDefinition r2 = new RowDefinition();
        ColumnDefinition c1 = new ColumnDefinition();
        ColumnDefinition c2 = new ColumnDefinition();

        // Row, Column 객체를 grid에 추가
        grid.RowDefinitions.Add(r1);
        grid.RowDefinitions.Add(r2);
        grid.ColumnDefinitions.Add(c1);
        grid.ColumnDefinitions.Add(c2);

        // 3. 컨트롤 만들어서 grid에 놓을 위치 속성 지정
        Button btn1 = new Button { Content = "button1" };
        Button btn2 = new Button { Content = "button2" };

        Grid.SetRow(btn1, 0);
        Grid.SetColumn(btn1, 0);
        Grid.SetRow(btn2, 1);
        Grid.SetColumn(btn2, 1);

        // 4. 각 컨트롤을 grid 자식에 추가
        grid.Children.Add(btn1);
        grid.Children.Add(btn2);

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