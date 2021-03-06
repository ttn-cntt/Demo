﻿using System;
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
        //private static String ConnectionString = @"Data Source=DESKTOP-1GUAO2R\SQLEXPRESS;Initial Catalog=QuanLyDiem;Integrated Security=True";
        //private static String ConnectionString = @"Data Source=Q3IQ7X3CNRGM2YY\SQLEXPRESS;Initial Catalog=QuanLyDiem;Integrated Security=True";
        private static String ConnectionString = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QuanLyDiem;Integrated Security=True";
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

       //Lấy thông tin lớp
        public DataTable GetLop()
        {
            DataTable info = null;
            if (IsConnected())
            {
                SqlCommand command = new SqlCommand();//command:lấy ,xóa dữ liệu...
                //chổ này nói lên rằng lệnh là lệnh gì?
                command.CommandText = "LopAll";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;


                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                info = new DataTable();
                sqlDataAdapter.Fill(info);//đôe dữ liệu vào
            }
            return info;
        }
        //Thêm lớp
        public bool ThemLop(Class lop)
        {
            bool isInsertted = false;
            if (IsConnected())
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "ThemLop";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                //command.Parameters.AddWithValue("@name", st.maLop);
                command.Parameters.AddWithValue("@tenlop", lop.tenLop);
                
                int i = command.ExecuteNonQuery();
                if (i > 0)
                    isInsertted = true;
            }
            return isInsertted;
        }
        public bool SuaLop(Class lop,int id)
        {
            bool isUpdate = false;
            if (IsConnected())
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "SuaLop";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                //command.Parameters.AddWithValue("@name", st.maLop);
                command.Parameters.AddWithValue("@tenlop", lop.tenLop);
                command.Parameters.AddWithValue("@id", id);
                int i = command.ExecuteNonQuery();
                if (i > 0)
                    isUpdate = true;
            }
            return isUpdate;
        }
        public bool XoaLop(string id)
        {
            bool isDelete = false;
            if (IsConnected())
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "XoaLop";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                command.Parameters.AddWithValue("@id", id);

                int i = command.ExecuteNonQuery();
                if (i > 0)
                    isDelete = true;
            }
            return isDelete;

        }
        public DataTable TimLop(string tenlop)
        {
            DataTable info = null;
            if (IsConnected())
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "TimLop";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                command.Parameters.AddWithValue("@tenlop", tenlop);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                info = new DataTable();
                sqlDataAdapter.Fill(info);
            }
            return info;
        }

        //Lấy thông tin sinh viên
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

        public bool UpdateStudent(SinhVien sv, int MaSV)
        {
            bool isUpdate = false;
            if (IsConnected())
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "UpdateStudent";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = con;
                command.Parameters.AddWithValue("@masv", MaSV);
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
    
    }
}
