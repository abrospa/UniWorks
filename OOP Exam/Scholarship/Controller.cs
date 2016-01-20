namespace Scholarship
{
    class Controller
    {
        static private Controller uniqueInstance = null;

        private Controller() { }

        static public Controller GetInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new Controller();
            return uniqueInstance;
        }

        public Room CreateRoom(int roomNumber, bool isOpen)
        {
            return (Base.CreateRoom(roomNumber, isOpen));
        }
    }
}
