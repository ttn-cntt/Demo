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
        private static string ConnectionString = @"Data Source=DESKTOP-M4FC1D7\SQLEXPRESS;Initial Catalog = QuanLyDiem; Integrated Security = True";
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
        public bool DeleteStudent(int masv)
        {
            bool isDelete = false;
            if (IsConnected())
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "Deletestudent";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                command.Parameters.AddWithValue("@masv", masv);
                int i = command.ExecuteNonQuery();
                if (i > 0)
                    isDelete = true;
            }
            return isDelete;
        }


        public DataTable Search(string tensvm)
        {
            DataTable info = null;
            if (IsConnected())
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "SearchStudent";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                command.Parameters.AddWithValue("@tensv", tensvm);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                info = new DataTable();
                sqlDataAdapter.Fill(info);
            }
            return info;
        }
        //Lấy thông tin lớp
        public DataTable GetLop()
        {
            DataTable info = null;
            if (IsConnected())
            {
                SqlCommand command = new SqlCommand();//command:lấy ,xóa dữ liệu...
                //chổ này nói lên rằng lệnh là lệnh gì?
                command.CommandText = "GetLop";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;


                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                info = new DataTable();
                sqlDataAdapter.Fill(info);//đôe dữ liệu vào
            }
            return info;
        }
    }
}
