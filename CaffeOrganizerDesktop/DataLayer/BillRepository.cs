using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BillRepository
    {
        public string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CaffeOrganizerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public List<CaffeBill> GetCaffeBills()
        {
            List<CaffeBill> caffeBills = new List<CaffeBill>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandText = "Select * From Bills";
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    caffeBills.Add(new CaffeBill(dataReader.GetInt32(0), dataReader.GetInt32(1), dataReader.GetInt32(2), dataReader.GetDateTime(3), dataReader.GetBoolean(4)));
                }
                connection.Close();
            }
            return caffeBills;
        }
        public int InsertCaffeBill(CaffeBill caffeBill)
        {
            int result;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandText = $"Insert into Bills( Table_ID, Total_Price, Date_And_Time, Paid) values({caffeBill.Table_ID},{caffeBill.Total_Price},{caffeBill.Date_And_Time.ToShortDateString()},0)";
                result = sqlCommand.ExecuteNonQuery();
            }
            return result;
        }
        public int DeleteCaffeBill(int billid)
        {
            int result;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(connectionString);
                sqlCommand.CommandText = "Delete from Bills where Bill_ID = @Bill_ID";
                sqlCommand.Parameters.AddWithValue("@Bill_ID", billid);
                result = sqlCommand.ExecuteNonQuery();
            }
            return result;
        }
        public int UpdateCaffeBill(CaffeBill caffeBill)
        {
            int result;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandText = "Update Bills SET Table_ID =@tableID, Total_Price = @totalPrice, Date_And_Time = @dateAndTime where Bill_ID = @billID";
                sqlCommand.Parameters.AddWithValue("@tableID", caffeBill.Table_ID);
                sqlCommand.Parameters.AddWithValue("@totalPrice", caffeBill.Total_Price);
                sqlCommand.Parameters.AddWithValue("@dateAndTime", caffeBill.Date_And_Time);
                sqlCommand.Parameters.AddWithValue("@billID", caffeBill.Bill_ID);
                result = sqlCommand.ExecuteNonQuery();
            }
            return result;
        }
    }
}
