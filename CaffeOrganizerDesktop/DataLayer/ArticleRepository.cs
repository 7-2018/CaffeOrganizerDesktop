using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ArticleRepository
    {
        public string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CaffeOrganizerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public List<CaffeArticle>GetCaffeArticles()
        {
            List<CaffeArticle> caffeArticles = new List<CaffeArticle>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandText = "Select * From Articles";
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    caffeArticles.Add(new CaffeArticle(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetInt32(2), dataReader.GetString(3)));
                }
                connection.Close();
            }
            return caffeArticles;
        }
        public int InsertCaffeArticle(CaffeArticle caffeArticle)
        {
            int result;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandText = $"Insert into Articles(Name, Price, Packaging) values('{caffeArticle.Name}',{caffeArticle.Price},'{caffeArticle.Packaging}')";
                result = sqlCommand.ExecuteNonQuery();
            }
            return result;
        }
        public int DeleteArticle(int articleid)
        {
            int result;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandText = "Delete from Articles where Article_ID = @articleID";
                sqlCommand.Parameters.AddWithValue("@articleID", articleid);
                result = sqlCommand.ExecuteNonQuery();
            }
            return result;
        }
        public int UpdateArticle(CaffeArticle caffeArticle)
        {
            int result;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandText = "Update Articles SET Name =@name, Price= @price, Packaging=@package where Article_ID = @articleID";
                sqlCommand.Parameters.AddWithValue("@name", caffeArticle.Name);
                sqlCommand.Parameters.AddWithValue("@price", caffeArticle.Price);
                sqlCommand.Parameters.AddWithValue("@package", caffeArticle.Packaging);
                sqlCommand.Parameters.AddWithValue("@articleID", caffeArticle.Article_ID);
                result = sqlCommand.ExecuteNonQuery();
            }
            return result;
        }
    }
}
