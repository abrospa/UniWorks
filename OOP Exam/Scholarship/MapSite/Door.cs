namespace Scholarship
{
    class Door : MapSite
    {
        protected bool isOpen;
        protected Room room1;
        protected Room room2;

        public Door(bool isOpen)
        {
            this.isOpen = isOpen;
        }

        public void SetRooms(Room room1, Room room2)
        {
            this.room1 = room1;
            this.room2 = room2;
        }
    }
}
