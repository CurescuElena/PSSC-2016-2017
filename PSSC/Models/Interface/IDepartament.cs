using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interface
{
    interface IDepartament : IFaculty
    {
        string departamentName
        {
            get;
            set;
        }
    }

}
