using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Web;

namespace WcfServiceDemo
{
    public class DBBaseSQLite
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB = new SQLiteDataAdapter();
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        public DBBaseSQLite()
        {
            Close();   
        }

        private void Close()
        {
            if (sql_cmd != null && sql_con.State.Equals(ConnectionState.Open))
            {
                sql_con.Close();
            }
            sql_con = null;
        }

        private void SetConnection()
        {
            //測試時請自行修改為實體路徑
            string DBPath = "E:\\Project\\WcfServiceDemo";
            sql_con = new SQLiteConnection
                ("Data Source=" + System.IO.Path.Combine(DBPath,"database.db") + ";Version=3;New=False;Compress=True;");
        }

        public DataTable GetData(string command, params SQLiteParameter[] parameters)
        {
            //SetConnection();
            //sql_con.Open();
            //string CommandText = command;
            //sql_cmd = sql_con.CreateCommand();
            //DB = new SQLiteDataAdapter(CommandText, sql_con);
            //DS.Reset();
            //DB.Fill(DS);
            //DB.Dispose();
            //DT = DS.Tables[0];
            //return DT;

            SetConnection();
            using (SQLiteCommand cmd = new SQLiteCommand(command, sql_con))
            {
                // 添加參數到命令中
                cmd.Parameters.AddRange(parameters);

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    return ds.Tables[0];
                }
            }
        }

        public bool Insert(CompositeType composite)
        {
            try
            {
                SetConnection();
                sql_con.Open();


                //請完成資料寫入的動作
                //string strSQL = "INSERT INTO SampleTable (office, item, company, saleQ4, saleQ3, saleQ2, saleQ1, reqdate, orderno, currency, price, msp) "VALUES (@office, @item, @company, @saleQ4, @saleQ3, @saleQ2, @saleQ1, @reqdate, @orderno, @currency, @price, @msp)";

                //string strSQL = "INSERT INTO SampleTable (office, item, company, saleQ4, saleQ3, saleQ2, saleQ1, reqdate, orderno, price, msp) VALUES (@office, @item, @company, @saleQ4, @saleQ3, @saleQ2, @saleQ1, @reqdate, @orderno, @price, @msp)";
                string strSQL = "INSERT INTO SampleTable (office, item, company, saleQ4, saleQ3, saleQ2, saleQ1, reqdate, orderno, Currenry, price, msp) VALUES (@office, @item, @company, @saleQ4, @saleQ3, @saleQ2, @saleQ1, @reqdate, @orderno, @Currenry, @price, @msp)";


                sql_cmd = new SQLiteCommand(strSQL, sql_con);
                sql_cmd.Parameters.AddWithValue("@office", composite.office);
                sql_cmd.Parameters.AddWithValue("@item", composite.item);
                sql_cmd.Parameters.AddWithValue("@company", composite.company);
                sql_cmd.Parameters.AddWithValue("@saleQ4", composite.saleQ4);
                sql_cmd.Parameters.AddWithValue("@saleQ3", composite.saleQ3);
                sql_cmd.Parameters.AddWithValue("@saleQ2", composite.saleQ2);
                sql_cmd.Parameters.AddWithValue("@saleQ1", composite.saleQ1);
                sql_cmd.Parameters.AddWithValue("@reqdate", composite.reqdate);
                sql_cmd.Parameters.AddWithValue("@orderno", composite.orderno);
                sql_cmd.Parameters.AddWithValue("@Currenry", composite.currency);
                sql_cmd.Parameters.AddWithValue("@price", composite.price);
                sql_cmd.Parameters.AddWithValue("@msp", composite.msp);

                sql_cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                // 錯誤處理，可以記錄錯誤日誌
                return false;
            }
            finally
            {
                DB.Dispose();
                Close();
            }
            
        }

        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }


    }
}