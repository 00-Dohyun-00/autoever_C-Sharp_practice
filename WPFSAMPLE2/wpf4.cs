using System.Windows;
using System.Windows.Input;

class MainFrame : Window
{

}


class App : Application
{

}


class Program
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