using System.Windows;

class Program
{
    [STAThread]
    public static void Main()
    {
        Window w = new Window();
        W.Show();
        
        // 프로그램에서 GUI를 만든 경우
        // => 프로그램을 종료하지 말고 GUI에서 발생하는 이벤트 처리
 
        Application app = new Application();
        app.Run();
}