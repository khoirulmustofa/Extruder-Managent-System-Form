using ExtruderManagementSystem_Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtruderManagementSystem_Facade
{
    public class MASALotAssuranceTreadFront_Facade : BaseCRUD
    {
        public bool insertLostAssuranceFornt(MASALotAssuranceTreadFront oMASALotAssuranceTreadFront)
        {
            string sql = string.Format(@"INSERT INTO [MASA2_DB].[dbo].[MASA_Lot_Assurance_Tread_Front]
           ([Kode_Lot_Assurance_Front]
           ,[Kode_Order_Tread]
           ,[Kode_Spec_Tread]
           ,[Kode_Size_Tread]
           ,[Kode_Die_Tread]
           ,[Kode_Die_Tread_Act]
           ,[Machine]
           ,[Preformer_No]
           ,[Preformer_No_Act]
           ,[Insert_No]
           ,[Insert_No_Act]
           ,[Kode_Compd]
           ,[Kode_Compd_Act]
           ,[Kode_Stamp_Tread]
           ,[Kode_Stamp_Tread_Act]
           ,[Compd_Cap]
           ,[Compd_Cap_FM]
           ,[Compd_Cap_RT]
           ,[Compd_Base]
           ,[Compd_Base_FM]
           ,[Compd_Base_RT]
           ,[Compd_Wing]
           ,[Compd_Wing_FM]
           ,[Compd_Wing_RT]
           ,[Compd_Under_Tread]
           ,[Compd_Under_Tread_FM]
           ,[Compd_Under_Tread_RT]
           ,[Speed_Screw_Cap]
           ,[Speed_Screw_Cap_Act]
           ,[Speed_Screw_Base]
           ,[Speed_Screw_Base_Act]
           ,[Speed_Screw_Wing]
           ,[Speed_Screw_Wing_Act]
           ,[Speed_Screw_Undet_Tread]
           ,[Speed_Screw_Undet_Tread_Act]
           ,[Speed_Line]
           ,[Speed_Line_Act]
           ,[Total_Width]
           ,[Total_Width_Setting]
           ,[Total_Width_Setting_Act]
           ,[Running_Scalle_1]
           ,[Running_Scalle_1_Act]
           ,[UserID]
           ,[Create_Date]
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
            @28,
            @29,
            @30,
            @31,
            @32,
            @33,
            @34,
            @35,
            @36,
            @37,
            @38,
            @39,
            @40,
            @41,
            @42,
            @43,
            @44)");
            db.Execute(sql, new object[]{
            oMASALotAssuranceTreadFront.Kode_Lot_Assurance_Front,
            oMASALotAssuranceTreadFront.Kode_Order_Tread,
            oMASALotAssuranceTreadFront.Kode_Spec_Tread,
            oMASALotAssuranceTreadFront.Kode_Size_Tread,
            oMASALotAssuranceTreadFront.Kode_Die_Tread,
            oMASALotAssuranceTreadFront.Kode_Die_Tread_Act,
            oMASALotAssuranceTreadFront.Machine,
            oMASALotAssuranceTreadFront.Preformer_No,
            oMASALotAssuranceTreadFront.Preformer_No_Act,
            oMASALotAssuranceTreadFront.Insert_No,
            oMASALotAssuranceTreadFront.Insert_No_Act,
            oMASALotAssuranceTreadFront.Kode_Compd,
            oMASALotAssuranceTreadFront.Kode_Compd_Act,
            oMASALotAssuranceTreadFront.Kode_Stamp_Tread,
            oMASALotAssuranceTreadFront.Kode_Stamp_Tread_Act,
            oMASALotAssuranceTreadFront.Compd_Cap,
            oMASALotAssuranceTreadFront.Compd_Cap_FM,
            oMASALotAssuranceTreadFront.Compd_Cap_RT,
            oMASALotAssuranceTreadFront.Compd_Base,
            oMASALotAssuranceTreadFront.Compd_Base_FM,
            oMASALotAssuranceTreadFront.Compd_Base_RT,
            oMASALotAssuranceTreadFront.Compd_Wing,
            oMASALotAssuranceTreadFront.Compd_Wing_FM,
            oMASALotAssuranceTreadFront.Compd_Wing_RT,
            oMASALotAssuranceTreadFront.Compd_Under_Tread,
            oMASALotAssuranceTreadFront.Compd_Under_Tread_FM,
            oMASALotAssuranceTreadFront.Compd_Under_Tread_RT,
            oMASALotAssuranceTreadFront.Speed_Screw_Cap,
            oMASALotAssuranceTreadFront.Speed_Screw_Cap_Act,
            oMASALotAssuranceTreadFront.Speed_Screw_Base,
            oMASALotAssuranceTreadFront.Speed_Screw_Base_Act,
            oMASALotAssuranceTreadFront.Speed_Screw_Wing,
            oMASALotAssuranceTreadFront.Speed_Screw_Wing_Act,
            oMASALotAssuranceTreadFront.Speed_Screw_Undet_Tread,
            oMASALotAssuranceTreadFront.Speed_Screw_Undet_Tread_Act,
            oMASALotAssuranceTreadFront.Speed_Line,
            oMASALotAssuranceTreadFront.Speed_Line_Act,
            oMASALotAssuranceTreadFront.Total_Width,
            oMASALotAssuranceTreadFront.Total_Width_Setting,
            oMASALotAssuranceTreadFront.Total_Width_Setting_Act,
            oMASALotAssuranceTreadFront.Running_Scalle_1,
            oMASALotAssuranceTreadFront.Running_Scalle_1_Act,
            oMASALotAssuranceTreadFront.UserID,
            oMASALotAssuranceTreadFront.Create_Date,
            oMASALotAssuranceTreadFront.Statuss=1
            });
            return true;
        }

        public DataTable getLotAssuraceCompd(string kodeDies, string startDateTime, string finishDateTime)
        {
            string sql = @"SELECT * FROM ViewAssuranceCompd
                            WHERE Kode_Size_Tread = @0 AND Create_Date BETWEEN @1 AND @2 ";
            return db.ExecuteReader(sql, kodeDies, startDateTime, finishDateTime);
        }



        public DataTable getAllSpeedScrewTreadAsTableBy(string kodeDies, string dateStar, string dateFinish)
        {
            string sql = @"SELECT [Kode_Lot_Assurance_Front]
                              ,[Kode_Order_Tread]
                              ,[Kode_Spec_Tread]
                              ,[Kode_Size_Tread]
                              ,[Kode_Die_Tread]
                              ,[Kode_Die_Tread_Act]
                              ,[Machine]
                              ,[Preformer_No]
                              ,[Preformer_No_Act]
                              ,[Insert_No]
                              ,[Insert_No_Act]
                              ,[Kode_Compd]
                              ,[Kode_Compd_Act]
                              ,[Kode_Stamp_Tread]
                              ,[Kode_Stamp_Tread_Act]
                              ,[Compd_Cap]
                              ,[Compd_Cap_FM]
                              ,[Compd_Cap_RT]
                              ,[Compd_Base]
                              ,[Compd_Base_FM]
                              ,[Compd_Base_RT]
                              ,[Compd_Wing]
                              ,[Compd_Wing_FM]
                              ,[Compd_Wing_RT]
                              ,[Compd_Under_Tread]
                              ,[Compd_Under_Tread_FM]
                              ,[Compd_Under_Tread_RT]
                              ,[Speed_Screw_Cap]
                              ,[Speed_Screw_Cap_Act]
                              ,[Speed_Screw_Base]
                              ,[Speed_Screw_Base_Act]
                              ,[Speed_Screw_Wing]
                              ,[Speed_Screw_Wing_Act]
                              ,[Speed_Screw_Undet_Tread]
                              ,[Speed_Screw_Undet_Tread_Act]
                              ,[Speed_Line]
                              ,[Speed_Line_Act]
                              ,[Total_Width]
                              ,[Total_Width_Setting]
                              ,[Total_Width_Setting_Act]
                              ,[Running_Scalle_1]
                              ,[Running_Scalle_1_Act]
                              ,[UserID]
                              ,[Create_Date]
                              ,[Statuss]
                          FROM [MASA2_DB].[dbo].[MASA_Lot_Assurance_Tread_Front]
                          WHERE [Kode_Die_Tread]= @0 AND [Statuss]= 1
                          AND [Create_Date] BETWEEN @1 AND @2";
            return db.ExecuteReader(sql, kodeDies, dateStar, dateFinish);
        }

        public DataTable getAllUsedCompdTreadAsTableBy(string kodeSizeTread, string dateStar, string dateFinish)
        {
            string sql = @"SELECT [Kode_Lot_Assurance_Front]
                              ,[Kode_Order_Tread]
                              ,[Kode_Spec_Tread]
                              ,[Kode_Size_Tread]
                              ,[Kode_Die_Tread]
                              ,[Kode_Die_Tread_Act]
                              ,[Machine]
                              ,[Preformer_No]
                              ,[Preformer_No_Act]
                              ,[Insert_No]
                              ,[Insert_No_Act]
                              ,[Kode_Compd]
                              ,[Kode_Compd_Act]
                              ,[Kode_Stamp_Tread]
                              ,[Kode_Stamp_Tread_Act]
                              ,[Compd_Cap]
                              ,[Compd_Cap_FM]
                              ,[Compd_Cap_RT]
                              ,[Compd_Base]
                              ,[Compd_Base_FM]
                              ,[Compd_Base_RT]
                              ,[Compd_Wing]
                              ,[Compd_Wing_FM]
                              ,[Compd_Wing_RT]
                              ,[Compd_Under_Tread]
                              ,[Compd_Under_Tread_FM]
                              ,[Compd_Under_Tread_RT]
                              ,[Speed_Screw_Cap]
                              ,[Speed_Screw_Cap_Act]
                              ,[Speed_Screw_Base]
                              ,[Speed_Screw_Base_Act]
                              ,[Speed_Screw_Wing]
                              ,[Speed_Screw_Wing_Act]
                              ,[Speed_Screw_Undet_Tread]
                              ,[Speed_Screw_Undet_Tread_Act]
                              ,[Speed_Line]
                              ,[Speed_Line_Act]
                              ,[Total_Width]
                              ,[Total_Width_Setting]
                              ,[Total_Width_Setting_Act]
                              ,[Running_Scalle_1]
                              ,[Running_Scalle_1_Act]
                              ,[UserID]
                              ,[Create_Date]
                              ,[Statuss]
                          FROM [MASA2_DB].[dbo].[MASA_Lot_Assurance_Tread_Front]
                          WHERE [Kode_Size_Tread]= @0 AND [Statuss]= 1
                          AND [Create_Date] BETWEEN @1 AND @2";
            return db.ExecuteReader(sql, kodeSizeTread, dateStar, dateFinish);
        }
    }
}
