using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtruderManagementSystem_Facade
{
    public class BaseCRUD
    {
        public PetaPoco.Database db = null;

        public BaseCRUD()
        {
            db = new PetaPoco.Database("ExtruderManagementSystem_Conn");
        }
    }
}
