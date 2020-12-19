using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaffeOrganizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WorkerBusiness wokrerBusiness = new WorkerBusiness();
            List<CaffeWorker> caffeWorkers = wokrerBusiness.GetCaffeWorkers();
            foreach(CaffeWorker caffeWorker in caffeWorkers)
            {
                listBox1.Items.Add(caffeWorker.ToString());
            }
        }
    }
}
