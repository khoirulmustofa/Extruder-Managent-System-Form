using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtruderManagementSystem_Facade
{
    public class MASADiesTread_Facade : BaseCRUD
    {
        public DataTable getAllKodeDiesAsTable()
        {
            string sql = @"SELECT [Kode_Die_Tread]
                          ,[Preformer_No]
                          ,[Insert_No]
                          ,[Speed_Screw_Cap]
                          ,[Speed_Screw_Base]
                          ,[Speed_Screw_Wing]
                          ,[Speed_Screw_Undet_Tread]
                          ,[Speed_Line]
                          ,[Running_Scalle_1]
                          ,[Running_Scalle_2]
                          ,[Total_Width_Setting]
                          ,[Center_Gauge]
                          ,[Hump_Gauge_Top]
                          ,[Hump_Gauge_Bot]
                          ,[Shoulder_Gauge_Top]
                          ,[Shoulder_Gauge_Bot]
                          ,[Cushion_Gauge]
                          ,[Hump_Width]
                          ,[Total_Width]
                          ,[Cushion_Width]
                          ,[Statuss]
                      FROM [MASA2_DB].[dbo].[MASA_Dies_Tread]";
            return db.ExecuteReader(sql, null);
        }

        public DataTable getPopUpKodeDiesAsTable()
        {
            string sql = @"SELECT [Kode_Die_Tread]
                          ,[Preformer_No]
                          ,[Insert_No]
                          
                      FROM [MASA2_DB].[dbo].[MASA_Dies_Tread]";
            return db.ExecuteReader(sql, null);
        }

        public DataTable getPopUpKodeDiesAsTable(string kodeDies)
        {
            string sql = @"SELECT [Kode_Die_Tread]
                          ,[Preformer_No]
                          ,[Insert_No]
                          
                      FROM [MASA2_DB].[dbo].[MASA_Dies_Tread]
                      WHERE (Kode_Die_Tread LIKE '%" + kodeDies + "%')";
            return db.ExecuteReader(sql, null);
        }
    }
}
