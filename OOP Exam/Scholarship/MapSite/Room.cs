using System.Collections.Generic;

namespace Scholarship
{
    class Room : MapSite
    {
        List<MapSite> sides;
        protected int roomNumber;

        public Room(int roomNumber, List<MapSite> sides)
        {
            this.roomNumber = roomNumber;
            this.sides = sides;
        }

        public void AddSide(MapSite side)
        {
            sides.Add(side);
        }
    }
}
