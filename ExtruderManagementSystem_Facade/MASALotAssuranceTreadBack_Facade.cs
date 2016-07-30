using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExtruderManagementSystem_Entity;
using System.Data;
using System.Windows.Forms;

namespace ExtruderManagementSystem_Facade
{
    public class MASALotAssuranceTreadBack_Facade : BaseCRUD
    {
        public bool insertMASALotAssuranceTreadBack(MASALotAssuranceTreadBack oMASALotAssuranceTreadBack)
        {
            string sql = @"INSERT INTO [MASA2_DB].[dbo].[MASA_Lot_Assurance_Tread_Back]
                               ([Kode_Lot_Assurance_Back]
                               ,[Kode_Order_Tread]
                               ,[Kode_Spec_Tread]
                               ,[Kode_Size_Tread]
                               ,[Kode_Die_Tread]
                               ,[Machine]
                               ,[Kode_Stamp_Tread]
                               ,[Kode_Stamp_Tread_Act]
                               ,[Hump_Gauge_Top]
                               ,[Hump_Gauge_Top_Act]
                               ,[Center_Gauge]
                               ,[Center_Gauge_Act]
                               ,[Hump_Gauge_Bot]
                               ,[Hump_Gauge_Bot_Act]
                               ,[Hump_Width]
                               ,[Hump_Width_Act]
                               ,[Shoulder_Width]
                               ,[Shoulder_Width_Act]
                               ,[Cushion_Width]
                               ,[Cushion_Width_Act]
                               ,[Total_Width]
                               ,[Total_Width_Act]
                               ,[Running_Scalle_2]
                               ,[Running_Scalle_2_Act]
                               ,[Panjang_Tread]
                               ,[UserID]
                               ,[Create_Date]
                               ,[Expaired_Date]
                               ,[Statuss])
                         VALUES
                               (@0,
                                @1,
                                @2,
                                @3,
                                @4,
                                @5,
                                @6,
                                @7,
                                @8,
                                @9,
                                @10,
                                @11,
                                @12,
                                @13,
                                @14,
                                @15,
                                @16,
                                @17,
                                @18,
                                @19,
                                @20,
                                @21,
                                @22,
                                @23,
                                @24,
                                @25,
                                @26,
                                @27,
                                @28)";
            db.Execute(sql, new object[]{
                    oMASALotAssuranceTreadBack.Kode_Lot_Assurance_Back,
                    oMASALotAssuranceTreadBack.Kode_Order_Tread,
                    oMASALotAssuranceTreadBack.Kode_Spec_Tread,
                    oMASALotAssuranceTreadBack.Kode_Size_Tread,
                    oMASALotAssuranceTreadBack.Kode_Die_Tread,
                    oMASALotAssuranceTreadBack.Machine,
                    oMASALotAssuranceTreadBack.Kode_Stamp_Tread,
                    oMASALotAssuranceTreadBack.Kode_Stamp_Tread_Act,
                    oMASALotAssuranceTreadBack.Hump_Gauge_Top,
                    oMASALotAssuranceTreadBack.Hump_Gauge_Top_Act,
                    oMASALotAssuranceTreadBack.Center_Gauge,
                    oMASALotAssuranceTreadBack.Center_Gauge_Act,
                    oMASALotAssuranceTreadBack.Hump_Gauge_Bot,
                    oMASALotAssuranceTreadBack.Hump_Gauge_Bot_Act,
                    oMASALotAssuranceTreadBack.Hump_Width,
                    oMASALotAssuranceTreadBack.Hump_Width_Act,
                    oMASALotAssuranceTreadBack.Shoulder_Width,
                    oMASALotAssuranceTreadBack.Shoulder_Width_Act,
                    oMASALotAssuranceTreadBack.Cushion_Width,
                    oMASALotAssuranceTreadBack.Cushion_Width_Act,
                    oMASALotAssuranceTreadBack.Total_Width,
                    oMASALotAssuranceTreadBack.Total_Width_Act,
                    oMASALotAssuranceTreadBack.Running_Scalle_2,
                    oMASALotAssuranceTreadBack.Running_Scalle_2_Act,
                    oMASALotAssuranceTreadBack.Panjang_Tread,
                    oMASALotAssuranceTreadBack.UserID,
                    oMASALotAssuranceTreadBack.Create_Date,
                    oMASALotAssuranceTreadBack.Expaired_Date,
                    oMASALotAssuranceTreadBack.Statuss
                    });
            return true;
        }

        public DataTable getAllGaugeProfileTreadAsTableBy(string kodeDies, string dateStar, string dateFinish)
        {
            string sql = @"SELECT [Kode_Lot_Assurance_Back]
                          ,[Kode_Order_Tread]
                          ,[Kode_Spec_Tread]
                          ,[Kode_Size_Tread]
                          ,[Kode_Die_Tread]
                          ,[Machine]
                          ,[Kode_Stamp_Tread]
                          ,[Kode_Stamp_Tread_Act]
                          ,[Hump_Gauge_Top]
                          ,[Hump_Gauge_Top_Act]
                          ,[Center_Gauge]
                          ,[Center_Gauge_Act]
                          ,[Hump_Gauge_Bot]
                          ,[Hump_Gauge_Bot_Act]
                          ,[Shoulder_Width]
                          ,[Shoulder_Width_Act]
                          ,[Total_Width]
                          ,[Total_Width_Act]
                          ,[Running_Scalle_2]
                          ,[Running_Scalle_2_Act]
                          ,[UserID]
                          ,[Create_Date]
                          ,[Expaired_Date]
                          ,[Statuss]
                      FROM [MASA2_DB].[dbo].[MASA_Lot_Assurance_Tread_Back]
                      WHERE [Kode_Die_Tread]= @0 AND [Statuss]= 1 AND
                      [Create_Date] BETWEEN @1 AND @2";
            return db.ExecuteReader(sql, kodeDies, dateStar, dateFinish);
        }
    }
}
