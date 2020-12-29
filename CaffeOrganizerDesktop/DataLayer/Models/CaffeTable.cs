using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class CaffeTable
    {
        private int table_ID;
        private int worker_ID;
        private int number_Of_Seats;
        private bool taken;

        public CaffeTable(int table_ID, int worker_ID, int number_Of_Seats, bool taken)
        {
            this.Table_ID = table_ID;
            this.Worker_ID = worker_ID;
            this.Number_Of_Seats = number_Of_Seats;
            this.Taken = taken;
        }

        public int Table_ID { get => table_ID; set => table_ID = value; }
        public int Worker_ID { get => worker_ID; set => worker_ID = value; }
        public int Number_Of_Seats { get => number_Of_Seats; set => number_Of_Seats = value; }
        public bool Taken { get => taken; set => taken = value; }

        public override string ToString()
        {
            return $"{table_ID}-{worker_ID}-{number_Of_Seats}-{taken}";
        }
    }
}
