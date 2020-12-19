using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer 
{
    public class WorkerRepository
    {
        public string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CaffeOrganizerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public List<CaffeWorker> GetCaffeWorkers()
        {
            List<CaffeWorker> caffeWorkers = new List<CaffeWorker>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandText = "Select * From Workers";
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                while(dataReader.Read())
                {
                    caffeWorkers.Add(new CaffeWorker(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4)));
                }
                connection.Close();
            }
            return caffeWorkers;
        }
        public int InsertCaffeWorker(CaffeWorker caffeWorker)
        {
            int result;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(connectionString);
                sqlCommand.CommandText = $"Insert into Workers(Worker_ID, Password, User_Name, Email, Phone) values({caffeWorker.Worker_ID},{caffeWorker.Password},{caffeWorker.User_Name},{caffeWorker.Email},{caffeWorker.Phone})";
                result = sqlCommand.ExecuteNonQuery();
            }
            return result;
        }
    }
}
