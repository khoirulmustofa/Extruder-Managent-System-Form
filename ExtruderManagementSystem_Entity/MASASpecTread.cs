using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtruderManagementSystem_Entity
{
    [PetaPoco.TableName("MASA_Spec_Tread")]
    [PetaPoco.PrimaryKey("Kode_Spec_Tread")]
    [PetaPoco.ExplicitColumns]
    [Serializable]

    public class MASASpecTread
    {
        [PetaPoco.Column]
        public string Kode_Spec_Tread { get; set; }
        [PetaPoco.Column]
        public string Kode_Size_Tread { get; set; }
        [PetaPoco.Column]
        public string Kode_Die_Tread { get; set; }
        [PetaPoco.Column]
        public byte[] Gambar_Profile_Line_Dies { get; set; }
        [PetaPoco.Column]
        public string Marking { get; set; }
        [PetaPoco.Column]
        public string Kode_Compd { get; set; }
        [PetaPoco.Column]
        public string Compd_Cap { get; set; }
        [PetaPoco.Column]
        public string Compd_Base { get; set; }
        [PetaPoco.Column]
        public string Compd_Wing { get; set; }
        [PetaPoco.Column]
        public string Compd_Under_Tread { get; set; }
        [PetaPoco.Column]
        public int Statuss { get; set; }

    }
}
