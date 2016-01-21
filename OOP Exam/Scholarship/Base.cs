using System.Collections.Generic;

namespace Scholarship
{
    class Base
    {
        static public Room CreateRoom(int roomNumber, bool isOpen)
        {
            List<MapSite> sides = new List<MapSite>(4);

            Door door = new Door(isOpen);
            sides.Add(door);

            MapSite wall1 = new Wall();
            sides.Add(wall1);

            MapSite wall2 = new Wall();
            sides.Add(wall2);

            MapSite wall3 = new Wall();
            sides.Add(wall3);

            if (sides.Count == 4)
                return new Room(roomNumber, sides);
            else
                return null;
        }
    }
}
