using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.Entity
{
    class Connection
    {
        private static string ConnectionString = @"Data Source=DESKTOP-M4FC1D7\SQLEXPRESS;Initial Catalog=QuanLyDiem;Integrated Security=True";
        private SqlConnection con;

        public Connection()
        {
            con = new SqlConnection(ConnectionString);
        }

        public bool IsConnected()
        {
            bool IsConnect = false;
            try
            {
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                    IsConnect = true;
                else
                    IsConnect = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return IsConnect;
        }

        public DataTable GetStudentInfo()
        {
            DataTable info = null;
            if (IsConnected())
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "GetAllStudentInfo";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                info = new DataTable();
                sqlDataAdapter.Fill(info);
            }
            return info;
        }
    }
}
