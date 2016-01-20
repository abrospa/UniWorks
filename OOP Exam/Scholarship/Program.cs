using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = Controller.GetInstance();
            MapSite room = controller.CreateRoom(1, false);

            Console.WriteLine("Комната создана.");
            Console.ReadKey();
        }
    }
}
