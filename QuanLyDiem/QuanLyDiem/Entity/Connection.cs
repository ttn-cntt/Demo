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
        private static string ConnectionString = @"Data Source=Q3IQ7X3CNRGM2YY\SQLEXPRESS;Initial Catalog=QuanLyDiem;Integrated Security=True";
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

        public bool InsertStudent(SinhVien sv)
        {
            bool isInserted = false;
            if (IsConnected())
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "InsertStudent";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                command.Parameters.AddWithValue("@name", sv.TenSV);
                command.Parameters.AddWithValue("@ngaysinh", sv.Ngaysinh);
                command.Parameters.AddWithValue("@gioitinh", sv.GioiTinh);
                command.Parameters.AddWithValue("@dantoc", sv.Dantoc);
                command.Parameters.AddWithValue("@diachi", sv.Diachi);
                command.Parameters.AddWithValue("@malop", sv.lop);

                int i = command.ExecuteNonQuery();
                if (i > 0)
                    isInserted = true;
            }
            return isInserted;
        }

        public bool UpdateStudent(SinhVien sv, int masv)
        {

            bool isUpdate = false;
            if (IsConnected())
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "UpdateStudent";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                command.Parameters.AddWithValue("@masv", masv);
                command.Parameters.AddWithValue("@name", sv.TenSV);
                command.Parameters.AddWithValue("@ngaysinh", sv.Ngaysinh);
                command.Parameters.AddWithValue("@gioitinh", sv.GioiTinh);
                command.Parameters.AddWithValue("@dantoc", sv.Dantoc);
                command.Parameters.AddWithValue("@diachi", sv.Diachi);
                command.Parameters.AddWithValue("@malop", sv.lop);
                int i = command.ExecuteNonQuery();
                if (i > 0)
                    isUpdate = true;
            }
            return isUpdate;
        }
    }
}
