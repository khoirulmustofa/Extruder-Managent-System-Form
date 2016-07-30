using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtruderManagementSystem_Entity;

namespace ExtruderManagementSystem_Facade
{
    public class MASASpecTread_Facade : BaseCRUD
    {
        public DataTable getAllSpecTreadDepanAsTable()
        {
            string sql = string.Format(@"SELECT  Kode_Spec_Tread, Kode_Size_Tread, Kode_Die_Tread, Marking, Kode_Compd, Compd_Cap, Compd_Base, 
                                        Compd_Wing, Compd_Under_Tread
                                        FROM MASA_Spec_Tread
                                        WHERE Statuss = 1");
            return db.ExecuteReader(sql, null);
        }

        public DataTable getAllSpecTreadDepanAsTableBy(string kodeSize)
        {
            string sql = string.Format(@"SELECT  Kode_Spec_Tread, Kode_Size_Tread, Kode_Die_Tread, Marking, Kode_Compd, Compd_Cap, Compd_Base, 
                                        Compd_Wing, Compd_Under_Tread
                                        FROM MASA_Spec_Tread
                                        WHERE Kode_Size_Tread LIKE '%" + kodeSize + "%'");
            return db.ExecuteReader(sql, null);
        }

        public DataTable getSpecTreadDepanByKodeSpecTread(string KodeSpecTread)
        {
            string sql = string.Format(@"SELECT [Kode_Spec_Tread]
                                        ,[Kode_Size_Tread]
                                        ,[Size]
                                        ,[Pattren]
                                        ,[Brand]
                                        ,[Kode_Die_Tread]
                                        ,[Preformer_No]
                                        ,[Insert_No]
                                        ,[Kode_Compd]
                                        ,[Compd_Cap]
                                        ,[Compd_Base]
                                        ,[Compd_Wing]
                                        ,[Compd_Under_Tread]
                                        ,[Speed_Screw_Cap]
                                        ,[Speed_Screw_Base]
                                        ,[Speed_Screw_Wing]
                                        ,[Speed_Screw_Undet_Tread]
                                        ,[Speed_Line]
                                        ,[Running_Scalle_1]
                                        ,[Total_Width_Setting]
                                        ,[Total_Width]
                                        ,[Cushion_Width]
                                        ,[Gambar_Profile_Line_Dies]
                                    FROM [MASA2_DB].[dbo].[V_Spec_Tread_Front]
                                    WHERE [Kode_Spec_Tread] = @0 AND [Statuss] = 1");
            return db.ExecuteReader(sql, KodeSpecTread);
        }

        public DataTable getSpecTreadBelakangByKodeSpecTread(string KodeSpecTread)
        {
            string sql = string.Format(@"SELECT [Kode_Spec_Tread]
                                          ,[Kode_Size_Tread]
                                          ,[Size]
                                          ,[Pattren]
                                          ,[Brand]
                                          ,[Kode_Die_Tread]
                                          ,[Hump_Gauge_Top]
                                          ,[Center_Gauge]
                                          ,[Hump_Gauge_Bot]
                                          ,[Hump_Width]
                                          ,[Shoulder_Width]
                                          ,[Cushion_Width]
                                          ,[Total_Width]
                                          ,[Running_Scalle_2]
                                          ,[Gambar_Profile_Line_Dies]
                                      FROM [MASA2_DB].[dbo].[V_Spec_Tread_Back]
                                      WHERE [Kode_Spec_Tread] = @0 AND [Statuss] = 1");
            return db.ExecuteReader(sql, KodeSpecTread);
        }

        public string getKodeCompundByKodeSpec(string KodeSpecTread)
        {
            string sql = string.Format(@"SELECT 
                                          [Kode_Compd]
                                      FROM [MASA2_DB].[dbo].[MASA_Spec_Tread]
                                      WHERE Kode_Spec_Tread = @0");
            return db.ExecuteScalar<string>(sql, KodeSpecTread);
        }

        public MASASpecTread getSpecTreadByKodeSpecTread(string kodeSpecTread)
        {
            string sql = @"SELECT [Kode_Spec_Tread]
                              ,[Kode_Size_Tread]
                              ,[Kode_Die_Tread]
                              ,[Gambar_Profile_Line_Dies]
                              ,[Marking]
                              ,[Kode_Compd]
                              ,[Compd_Cap]
                              ,[Compd_Base]
                              ,[Compd_Wing]
                              ,[Compd_Under_Tread]
                              ,[Statuss]
                          FROM [MASA2_DB].[dbo].[MASA_Spec_Tread]
                          WHERE [Kode_Spec_Tread] = @0 ";
            return db.SingleOrDefault<MASASpecTread>(sql, kodeSpecTread);
        }

        public bool insertSpecTread(MASASpecTread oMASASpecTread)
        {
            string sql = @"INSERT INTO [MASA2_DB].[dbo].[MASA_Spec_Tread]
                               ([Kode_Spec_Tread]
                               ,[Kode_Size_Tread]
                               ,[Kode_Die_Tread]
                               ,[Gambar_Profile_Line_Dies]
                               ,[Marking]
                               ,[Kode_Compd]
                               ,[Compd_Cap]
                               ,[Compd_Base]
                               ,[Compd_Wing]
                               ,[Compd_Under_Tread]
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
                                @10)";
            db.Execute(sql, oMASASpecTread.Kode_Spec_Tread,
                            oMASASpecTread.Kode_Size_Tread,
                            oMASASpecTread.Kode_Die_Tread,
                            oMASASpecTread.Gambar_Profile_Line_Dies,
                            oMASASpecTread.Marking,
                            oMASASpecTread.Kode_Compd,
                            oMASASpecTread.Compd_Cap,
                            oMASASpecTread.Compd_Base,
                            oMASASpecTread.Compd_Wing,
                            oMASASpecTread.Compd_Under_Tread,
                            oMASASpecTread.Statuss);
            return true;
        }

        public bool updateSpecTread(MASASpecTread oMASASpecTread)
        {
            string sql = @"UPDATE [MASA2_DB].[dbo].[MASA_Spec_Tread]
                           SET [Kode_Size_Tread] = @1
                              ,[Kode_Die_Tread] = @2
                              ,[Gambar_Profile_Line_Dies] = @3
                              ,[Marking] = @4
                              ,[Kode_Compd] = @5
                              ,[Compd_Cap] = @6
                              ,[Compd_Base] = @7
                              ,[Compd_Wing] = @8
                              ,[Compd_Under_Tread] = @9
                              ,[Statuss] = @10
                         WHERE [Kode_Spec_Tread] = @0";
            db.Execute(sql, oMASASpecTread.Kode_Spec_Tread,
                            oMASASpecTread.Kode_Size_Tread,
                            oMASASpecTread.Kode_Die_Tread,
                            oMASASpecTread.Gambar_Profile_Line_Dies,
                            oMASASpecTread.Marking,
                            oMASASpecTread.Kode_Compd,
                            oMASASpecTread.Compd_Cap,
                            oMASASpecTread.Compd_Base,
                            oMASASpecTread.Compd_Wing,
                            oMASASpecTread.Compd_Under_Tread,
                            oMASASpecTread.Statuss);
            return true;
        }
    }
}
