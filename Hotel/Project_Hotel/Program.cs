using Project_Hotel.View;

namespace Project_Hotel
{
    public class Program
    {
        static void Main(string[] args)
        {
            MainView mainView = new MainView();
            mainView.initialInterface();
            Console.ReadLine();
        }
    }
}
