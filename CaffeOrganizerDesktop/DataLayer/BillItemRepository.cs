using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BillItemRepository
    {
        public string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CaffeOrganizerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public List<CaffeBillItem> GetCaffeBillItems()
        {
            List<CaffeBillItem> caffeBillItems = new List<CaffeBillItem>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandText = "Select * From BillItems";
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    caffeBillItems.Add(new CaffeBillItem(dataReader.GetInt32(0), dataReader.GetInt32(1), dataReader.GetInt32(2)));
                }
                connection.Close();
            }
            return caffeBillItems;
        }
        public int InsertCaffeBillItem(CaffeBillItem caffeBillItem)
        {
            int result;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandText = $"Insert into BillItems(Article_ID, Bill_ID, Quantity) values({caffeBillItem.Article_ID},{caffeBillItem.Bill_ID},{caffeBillItem.Quantity})";
                result = sqlCommand.ExecuteNonQuery();
            }
            return result;
        }
        public int DeleteBillItem(int itemid, int billid)
        {
            int result;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(connectionString);
                sqlCommand.CommandText = "Delete from BillItems where Article_ID = @articleID and Bill_ID= @bill_ID";
                sqlCommand.Parameters.AddWithValue("@article_ID", itemid);
                sqlCommand.Parameters.AddWithValue("@bill_ID", billid);
                result = sqlCommand.ExecuteNonQuery();
            }
            return result;
        }
        public int UpdateBillItem(CaffeBillItem caffeBillItem)
        {
            int result;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(connectionString);
                sqlCommand.CommandText = "Update BillItems SET Quantity=@quantity where Article_ID =@articleID, Bill_ID = @bill_ID,";
                sqlCommand.Parameters.AddWithValue("@quantity", caffeBillItem.Quantity);
                sqlCommand.Parameters.AddWithValue("@numberOfSeats", caffeBillItem.Article_ID);
                sqlCommand.Parameters.AddWithValue("@take", caffeBillItem.Bill_ID);
                result = sqlCommand.ExecuteNonQuery();
            }
            return result;
        }
    }
}
