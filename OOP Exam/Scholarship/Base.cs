namespace Scholarship
{
    class Base
    {
        static public Room CreateRoom(int roomNumber, bool isOpen)
        {
            Room room = new Room(roomNumber);

            Door door = new Door(isOpen);
            door.SetRooms(room, new Room(2));
            room.AddSide(door);

            MapSite wall1 = new Wall();
            room.AddSide(wall1);

            MapSite wall2 = new Wall();
            room.AddSide(wall2);

            MapSite wall3 = new Wall();
            room.AddSide(wall3);

            return room;
        }
    }
}
