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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkerBusiness wb = new WorkerBusiness();
            foreach (CaffeWorker w in wb.GetCaffeWorkers())
            {
                if (textBox1.Text.Equals(w.User_Name) && textBox2.Text.Equals(w.Password))
                {
                    MainPage mp = new MainPage();
                    mp.Show();
                    this.Hide();
                }
            }
        }
    }
}
