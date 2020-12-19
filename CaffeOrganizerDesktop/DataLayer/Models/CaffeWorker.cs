using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CaffeWorker
    {
        private int worker_ID;
        private string password;
        private string user_Name;
        private string email;
        private string phone;

        public CaffeWorker(int worker_ID, string password, string user_Name, string email, string phone)
        {
            this.Worker_ID = worker_ID;
            this.Password = password;
            this.User_Name = user_Name;
            this.Email = email;
            this.Phone = phone;
        }

        public int Worker_ID { get => worker_ID; set => worker_ID = value; }
        public string Password { get => password; set => password = value; }
        public string User_Name { get => user_Name; set => user_Name = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }

        public override string ToString()
        {
            return $"{worker_ID}-{password}-{user_Name}-{email}-{phone}";
        }
    }
}
