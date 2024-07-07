using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceDemo
{
    // 注意: 您可以使用 [重構] 功能表上的 [重新命名] 命令同時變更程式碼、svc 和組態檔中的類別名稱 "Service1"。
    // 注意: 若要啟動 WCF 測試用戶端以便測試此服務，請在 [方案總管] 中選取 Service1.svc 或 Service1.svc.cs，然後開始偵錯。
    public class Service1 : IService1
    {
        public List<string> GetData(string orderno)
        {
            DBBaseSQLite dbBase = new DBBaseSQLite();
            ////完成回傳 Order 所包含 Item 清單
            //string strSQL = string.Empty;

            //dbBase.GetData(strSQL);

            //return new List<string>();

            string strSQL = "SELECT Item FROM SampleTable WHERE orderno = @orderno";


            // 創建 SQLiteParameter 來綁定參數
            SQLiteParameter param = new SQLiteParameter("@orderno", orderno);

            // 傳遞 SQL 查詢和參數到 GetData 方法中
            DataTable resultTable = dbBase.GetData(strSQL, param);

            // 將 DataTable 中的結果轉換為 List<string> 返回
            List<string> itemList = new List<string>();
            foreach (DataRow row in resultTable.Rows)
            {
                itemList.Add(row["item"].ToString());
            }

            return itemList;
            
        }

        public bool InserData(CompositeType composite)
        {
            DBBaseSQLite dbBase = new DBBaseSQLite();
            return dbBase.Insert(composite);
        }
    }
}
