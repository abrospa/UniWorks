using System.Collections.Generic;
namespace Scholarship
{
    class Room : MapSite
    {
        List<MapSite> sides;

        protected int roomNumber;

        public Room(int roomNumber)
        {
            this.roomNumber = roomNumber;
            sides = new List<MapSite>(4);
        }

        public void AddSide(MapSite side)
        {
            sides.Add(side);
        }
    }
}
