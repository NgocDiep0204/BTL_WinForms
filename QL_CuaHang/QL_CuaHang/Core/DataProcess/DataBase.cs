using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace QL_CuaHang.Core.DataProcess
//{
    public class DataBase
    {
        string conn = "Data Source = LAPTOP-1JQMQFE0\\SQLEXPRESS; Initial Catalog = QuanLyCuaHangBanLaptop;" +
                    "Persist Security Info=True;User ID= sa;Password=ngocdiep020403; ";
        SqlConnection sqlconn = null;

        protected virtual void OpenConnection()
        {
            sqlconn = new SqlConnection(conn);
            if (sqlconn.State != ConnectionState.Open)
            {
                sqlconn.Open();
            }
        }
        protected virtual void CloseConnection()
        {
            if (sqlconn.State != ConnectionState.Closed)
            {
                sqlconn.Close();
                sqlconn.Dispose();
            }
        }

        public DataTable DataReader(string sqlSelect)
        {
            DataTable dt = new DataTable();
            OpenConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlSelect, conn);
            adapter.Fill(dt);
            CloseConnection();
            return dt;
        }
        public void ChangeData(string sql)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = sqlconn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            CloseConnection();
            cmd.Dispose();
        }
    }
//}
