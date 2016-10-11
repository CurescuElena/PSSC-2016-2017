using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interface
{
    interface IRoom : IFaculty
    {
        int roomId
        { 
            get;
            set;
        }
        string roomName
        {
            get;
            set;
        }
    }
}
