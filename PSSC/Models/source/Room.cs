using Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.source
{
    class Room : Faculty, IRoom
    {
        int capacityRoom;
        int idRoom;
        string nameRoom;
        public int roomCapacity
        {
            get
            {
                return capacityRoom;
            }

            set
            {
                capacityRoom = value;
            }
        }

        public int roomId
        {
            get
            {
                return idRoom;
            }

            set
            {
                idRoom = value;
            }
        }

        public string roomName
        {
            get
            {
               return nameRoom;
            }

            set
            {
                nameRoom = value;
            }
        }
        public Room(int facultyId, string facultyName, int roomId, string roomName) : base(facultyId, facultyName)
        {
            idRoom = roomId;
            nameRoom = roomName;
        }
    }
}
