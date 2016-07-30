using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ExtruderManagementSystem_Facade
{
    public class MASAStockTread_Facade : BaseCRUD
    {
        public void insertStockTread(ExtruderManagementSystem_Entity.MASAStockTread oMASAStockTread)
        {
            string sql = @"INSERT INTO [MASA2_DB].[dbo].[MASA_Stock_Tread]
                                ([Kode_Lot_Assurance_Back]
                                ,[No_Coin_Fifo])
                            VALUES
                                (@0
                                ,@1)";
            db.Execute(sql, oMASAStockTread.Kode_Lot_Assurance_Back, oMASAStockTread.No_Coin_Fifo);
        }

        public DataTable getViewStokTreadAll()
        {
            string sql = @"SELECT [Kode_Lot_Assurance_Back]
                              ,[Kode_Size_Tread]
                              ,[Machine]
                              ,[Panjang_Tread]
                              ,[No_Coin_Fifo]
                              ,[Create_Date]
                              ,[Expaired_Date]
                          FROM [MASA2_DB].[dbo].[V_Stock_Tread]
                          WHERE [Statuss] = 1
                          ORDER BY [Expaired_Date] ASC";
            return db.ExecuteReader(sql, null);
        }

        public void deleteStockTread(string kodeStockTread)
        {
            string sql = @"DELETE FROM [MASA2_DB].[dbo].[MASA_Stock_Tread]
                           WHERE [Kode_Lot_Assurance_Back]= @0";
            db.Execute(sql,kodeStockTread);
        }
    }
}
