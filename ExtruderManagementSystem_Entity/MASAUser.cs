using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtruderManagementSystem_Entity
{
    [PetaPoco.TableName("MASA_User")]
    [PetaPoco.PrimaryKey("UserID")]
    [PetaPoco.ExplicitColumns]
    [Serializable]

    public class MASAUser
    {
        [PetaPoco.Column]
        public string UserID { get; set; }
        [PetaPoco.Column]
        public string UserName { get; set; }
        [PetaPoco.Column]
        public string Passwords { get; set; }
        [PetaPoco.Column]
        public string Description { get; set; }
        [PetaPoco.Column]
        public string Machine { get; set; }
        [PetaPoco.Column]
        public string Group { get; set; }
        [PetaPoco.Column]
        public int Statuss { get; set; }

    }
}
