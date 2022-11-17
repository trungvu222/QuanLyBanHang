﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyBanHang.Class
{
    class Modify
    {
        public Modify()
        {
        }
        SqlCommand sqlCommand; //dung de truy van cac cau lenh insert,update,dele,...
        SqlDataReader dataReader; //dung de doc du lieu trong bang
        SqlDataAdapter dataAdapter;

        //Datatable tra ve 1 bang
        public DataTable getAllHoaDonBan()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from tblHDBan";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection()) 
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
        public DataTable getAllHang()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from tblHang";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
        public List<TaiKhoan> TaiKhoans(string query) //check tai khoan
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while(dataReader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }
            return taiKhoans;
        }
        public void Command(string query) //dung de dang ky tai khoan
        {
             using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery(); //thuc thi cau truy van
                sqlConnection.Close();
            }
        }
    }
}
