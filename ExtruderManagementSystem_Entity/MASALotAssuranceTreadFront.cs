using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtruderManagementSystem_Entity
{
    [PetaPoco.TableName("MASA_Lot_Assurance_Tread_Front")]
    [PetaPoco.PrimaryKey("Kode_Lot_Assurance_Front")]
    [PetaPoco.ExplicitColumns]
    [Serializable]

    public class MASALotAssuranceTreadFront
    {
        [PetaPoco.Column]
        public string Kode_Lot_Assurance_Front { get; set; }
        [PetaPoco.Column]
        public string Kode_Order_Tread { get; set; }
        [PetaPoco.Column]
        public string Kode_Spec_Tread { get; set; }
        [PetaPoco.Column]
        public string Kode_Size_Tread { get; set; }
        [PetaPoco.Column]
        public string Kode_Die_Tread { get; set; }
        [PetaPoco.Column]
        public string Kode_Die_Tread_Act { get; set; }
        [PetaPoco.Column]
        public string Machine { get; set; }
        [PetaPoco.Column]
        public string Preformer_No { get; set; }
        [PetaPoco.Column]
        public string Preformer_No_Act { get; set; }
        [PetaPoco.Column]
        public string Insert_No { get; set; }
        [PetaPoco.Column]
        public string Insert_No_Act { get; set; }
        [PetaPoco.Column]
        public string Kode_Compd { get; set; }
        [PetaPoco.Column]
        public string Kode_Compd_Act { get; set; }
        [PetaPoco.Column]
        public string Kode_Stamp_Tread { get; set; }
        [PetaPoco.Column]
        public string Kode_Stamp_Tread_Act { get; set; }
        [PetaPoco.Column]
        public string Compd_Cap { get; set; }
        [PetaPoco.Column]
        public string Compd_Cap_FM { get; set; }
        [PetaPoco.Column]
        public string Compd_Cap_RT { get; set; }
        [PetaPoco.Column]
        public string Compd_Base { get; set; }
        [PetaPoco.Column]
        public string Compd_Base_FM { get; set; }
        [PetaPoco.Column]
        public string Compd_Base_RT { get; set; }
        [PetaPoco.Column]
        public string Compd_Wing { get; set; }
        [PetaPoco.Column]
        public string Compd_Wing_FM { get; set; }
        [PetaPoco.Column]
        public string Compd_Wing_RT { get; set; }
        [PetaPoco.Column]
        public string Compd_Under_Tread { get; set; }
        [PetaPoco.Column]
        public string Compd_Under_Tread_FM { get; set; }
        [PetaPoco.Column]
        public string Compd_Under_Tread_RT { get; set; }
        [PetaPoco.Column]
        public string Speed_Screw_Cap { get; set; }
        [PetaPoco.Column]
        public string Speed_Screw_Cap_Act { get; set; }
        [PetaPoco.Column]
        public string Speed_Screw_Base { get; set; }
        [PetaPoco.Column]
        public string Speed_Screw_Base_Act { get; set; }
        [PetaPoco.Column]
        public string Speed_Screw_Wing { get; set; }
        [PetaPoco.Column]
        public string Speed_Screw_Wing_Act { get; set; }
        [PetaPoco.Column]
        public string Speed_Screw_Undet_Tread { get; set; }
        [PetaPoco.Column]
        public string Speed_Screw_Undet_Tread_Act { get; set; }
        [PetaPoco.Column]
        public string Speed_Line { get; set; }
        [PetaPoco.Column]
        public string Speed_Line_Act { get; set; }
        [PetaPoco.Column]
        public int Total_Width { get; set; }
        [PetaPoco.Column]
        public int Total_Width_Setting { get; set; }
        [PetaPoco.Column]
        public int Total_Width_Setting_Act { get; set; }
        [PetaPoco.Column]
        public int Running_Scalle_1 { get; set; }
        [PetaPoco.Column]
        public int Running_Scalle_1_Act { get; set; }
        [PetaPoco.Column]
        public string UserID { get; set; }
        [PetaPoco.Column]
        public DateTime Create_Date { get; set; }
        [PetaPoco.Column]
        public int Statuss { get; set; }
    }
}
