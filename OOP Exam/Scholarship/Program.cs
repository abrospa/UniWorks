using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = Controller.GetInstance();
            MapSite room = controller.CreateRoom(1, false);

            if (room != null)
                Console.WriteLine("Комната создана.");
            else
                Console.WriteLine("Комната не создана.");
            Console.ReadKey();
        }
    }
}
