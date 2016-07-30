using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtruderManagementSystem_Entity
{
    [PetaPoco.TableName("MASA_Stock_Tread")]
    [PetaPoco.PrimaryKey("Kode_Lot_Assurance_Back")]
    [PetaPoco.ExplicitColumns]
    [Serializable]

    public class MASAStockTread
    {
        [PetaPoco.Column]
        public string Kode_Lot_Assurance_Back { get; set; }
        [PetaPoco.Column]
        public int No_Coin_Fifo { get; set; }

    }
}
