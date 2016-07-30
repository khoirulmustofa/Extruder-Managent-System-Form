using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtruderManagementSystem_Entity
{
    [PetaPoco.TableName("MASA_Order_Tread")]
    [PetaPoco.PrimaryKey("Kode_Order_Tread")]
    [PetaPoco.ExplicitColumns]
    [Serializable]

    public class MASAOrderTread
    {
        [PetaPoco.Column]
        public string Kode_Order_Tread { get; set; }
        [PetaPoco.Column]
        public string Kode_Spec_Tread { get; set; }
        [PetaPoco.Column]
        public int Planing { get; set; }
        [PetaPoco.Column]
        public string Keterangan { get; set; }
        [PetaPoco.Column]
        public int Statuss { get; set; }
    }
}
