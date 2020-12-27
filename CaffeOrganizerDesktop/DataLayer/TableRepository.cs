using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class TableRepository
    {
        public string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CaffeOrganizerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public List<CaffeTable> GetCaffeTables()
        {
            List<CaffeTable> caffeTables = new List<CaffeTable>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandText = "Select * From Tables";
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    caffeTables.Add(new CaffeTable(dataReader.GetInt32(0), dataReader.GetInt32(1), dataReader.GetInt32(2), dataReader.GetBoolean(3)));
                }
                connection.Close();
            }
            return caffeTables;
        }
        public int InsertCaffeTable(CaffeTable caffeTable)
        {
            int result;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(connectionString);
                sqlCommand.CommandText = $"Insert into Tables(Table_ID, Worker_ID, Number_Of_Seats, Taken) values({caffeTable.Table_ID},{caffeTable.Worker_ID},{caffeTable.Number_Of_Seats},{caffeTable.Taken})";
                result = sqlCommand.ExecuteNonQuery();
            }
            return result;
        }
        public int DeleteTable(int tableid)
        {
            int result;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(connectionString);
                sqlCommand.CommandText = "Delete from Tables where Table_ID = @tableID";
                sqlCommand.Parameters.AddWithValue("@tableID", tableid);
                result = sqlCommand.ExecuteNonQuery();
            }
            return result;
        }
        public int UpdateTable(CaffeTable caffeTable)
        {
            int result;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandText = "Update Tables SET Worker_ID =@workerID, Number_Of_Seats = @numberOfSeats, Taken=@take where Table_ID = @tableID";
                sqlCommand.Parameters.AddWithValue("@workerID", caffeTable.Worker_ID);
                sqlCommand.Parameters.AddWithValue("@numberOfSeats", caffeTable.Number_Of_Seats);
                sqlCommand.Parameters.AddWithValue("@take", caffeTable.Taken);
                sqlCommand.Parameters.AddWithValue("@tableID", caffeTable.Table_ID);
                result = sqlCommand.ExecuteNonQuery();
            }
            return result;
        }
    }
}
