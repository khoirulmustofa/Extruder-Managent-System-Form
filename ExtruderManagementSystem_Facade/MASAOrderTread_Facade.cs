using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtruderManagementSystem_Entity;

namespace ExtruderManagementSystem_Facade
{
    public class MASAOrderTread_Facade : BaseCRUD
    {
        public DataTable getOrderTreadDepanAsTabel()
        {
            string sql = string.Format(@"SELECT [Kode_Order_Tread]
                                          ,[Kode_Spec_Tread]
                                          ,[Preformer_No]
                                          ,[Insert_No]
                                          ,[Kode_Die_Tread]
                                          ,[Kode_Compd]
                                          ,[Compd_Cap]
                                          ,[Compd_Base]
                                          ,[Compd_Wing]
                                          ,[Compd_Under_Tread]
                                          ,[Marking]
                                          ,[Planing]
                                          ,[Keterangan]
                                      FROM [MASA2_DB].[dbo].[V_Order_Tread_Front]
                                      WHERE (Statuss = 1)
                                      ORDER BY [Keterangan] DESC");
            return db.ExecuteReader(sql, null);
        }

        public DataTable getViewOrderTreadDepanAsTabelByline(string line)
        {
            string sql = string.Format(@"SELECT * FROM V_Order_Tread_Front
                                        WHERE Kode_Die_Tread LIKE '" + line + "%' ORDER BY Keterangan DESC , Kode_Compd");
            return db.ExecuteReader(sql, null);
        }

        public bool saveOrderTread(MASAOrderTread oMASAOrderTread)
        {
            string sql = string.Format(@"INSERT INTO [MASA2_DB].[dbo].[MASA_Order_Tread]
                                               ([Kode_Order_Tread]
                                               ,[Kode_Spec_Tread]
                                               ,[Planing]
                                               ,[Keterangan]
                                               ,[Statuss])
                                         VALUES
                                               (@0
                                               ,@1
                                               ,@2
                                               ,@3
                                               ,@4)");
            db.Execute(sql, oMASAOrderTread.Kode_Order_Tread,
                            oMASAOrderTread.Kode_Spec_Tread,
                            oMASAOrderTread.Planing,
                            oMASAOrderTread.Keterangan,
                            oMASAOrderTread.Statuss);
            return true;
        }

        public MASAOrderTread getOrdertreadBy(string kodeOrderTread)
        {
            string sql = @"SELECT [Kode_Order_Tread]
                              ,[Kode_Spec_Tread]
                              ,[Planing]
                              ,[Keterangan]
                              ,[Statuss]
                          FROM [MASA2_DB].[dbo].[MASA_Order_Tread]
                          WHERE [Kode_Order_Tread]= @0";
            return db.SingleOrDefault<MASAOrderTread>(sql, kodeOrderTread);
        }

        public bool updateOrderTread(MASAOrderTread oMASAOrderTread)
        {
            string sql = @"UPDATE [MASA2_DB].[dbo].[MASA_Order_Tread]
                               SET [Kode_Spec_Tread] = @1
                                  ,[Planing] = @2
                                  ,[Keterangan] = @3
                                  ,[Statuss] = @4
                             WHERE [Kode_Order_Tread] = @0";
             db.Execute(sql, oMASAOrderTread.Kode_Order_Tread,
                            oMASAOrderTread.Kode_Spec_Tread,
                            oMASAOrderTread.Planing,
                            oMASAOrderTread.Keterangan,
                            oMASAOrderTread.Statuss);
             return true;
        }

        public void deleteOrderTread(string kodeOrderTread)
        {
            string sql = @"DELETE FROM [MASA2_DB].[dbo].[MASA_Order_Tread]
                            WHERE Kode_Order_Tread = @0";
            db.Execute(sql, kodeOrderTread);
        }
    }
}
