using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtruderManagementSystem_Entity
{
    [PetaPoco.TableName("MASA_Lot_Assurance_Tread_Back")]
    [PetaPoco.PrimaryKey("Kode_Lot_Assurance_Back")]
    [PetaPoco.ExplicitColumns]
    [Serializable]
    public class MASALotAssuranceTreadBack
    {
        [PetaPoco.Column]
        public string Kode_Lot_Assurance_Back { get; set; }
        [PetaPoco.Column]
        public string Kode_Order_Tread { get; set; }
        [PetaPoco.Column]
        public string Kode_Spec_Tread { get; set; }
        [PetaPoco.Column]
        public string Kode_Size_Tread { get; set; }
        [PetaPoco.Column]
        public string Kode_Die_Tread { get; set; }
        [PetaPoco.Column]
        public string Machine { get; set; }
        [PetaPoco.Column]
        public string Kode_Stamp_Tread { get; set; }
        [PetaPoco.Column]
        public string Kode_Stamp_Tread_Act { get; set; }
        [PetaPoco.Column]
        public string Hump_Gauge_Top { get; set; }
        [PetaPoco.Column]
        public string Hump_Gauge_Top_Act { get; set; }
        [PetaPoco.Column]
        public string Center_Gauge { get; set; }
        [PetaPoco.Column]
        public string Center_Gauge_Act { get; set; }
        [PetaPoco.Column]
        public string Hump_Gauge_Bot { get; set; }
        [PetaPoco.Column]
        public string Hump_Gauge_Bot_Act { get; set; }
        [PetaPoco.Column]
        public int Hump_Width { get; set; }
        [PetaPoco.Column]
        public int Hump_Width_Act { get; set; }
        [PetaPoco.Column]
        public int Shoulder_Width { get; set; }
        [PetaPoco.Column]
        public int Shoulder_Width_Act { get; set; }
        [PetaPoco.Column]
        public int Cushion_Width { get; set; }
        [PetaPoco.Column]
        public int Cushion_Width_Act { get; set; }
        [PetaPoco.Column]
        public int Total_Width { get; set; }
        [PetaPoco.Column]
        public int Total_Width_Act { get; set; }
        [PetaPoco.Column]
        public int Running_Scalle_2 { get; set; }
        [PetaPoco.Column]
        public int Running_Scalle_2_Act { get; set; }
        [PetaPoco.Column]
        public int Panjang_Tread { get; set; }
        [PetaPoco.Column]
        public string UserID { get; set; }
        [PetaPoco.Column]
        public DateTime Create_Date { get; set; }
        [PetaPoco.Column]
        public DateTime Expaired_Date { get; set; }
        [PetaPoco.Column]
        public int Statuss { get; set; }

    }
}
