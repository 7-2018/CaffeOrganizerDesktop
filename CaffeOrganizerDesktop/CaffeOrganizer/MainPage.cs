using BusinessLayer;
using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace CaffeOrganizer
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BillBusiness b11 = new BillBusiness();
            TableBusiness tb = new TableBusiness();
            CaffeTable t = tb.getCaffeTables().Where(x => x.Table_ID == Convert.ToInt32(button3.Text)).ToList()[0];
            TableBusiness.curentTable = t;
            t.Taken = true;
            tb.UpdateTable(t);
            try
            {
                BillBusiness.currentBill = b11.getCaffeBills().Where(x => x.Paid == false && t.Table_ID == x.Table_ID).ToList()[0];
            }
            catch (Exception ex)
            {
                b11.InsertCaffeBill(new CaffeBill(999, t.Table_ID, 0, DateTime.Now, false));
                BillBusiness.currentBill = b11.getCaffeBills().Where(x => x.Paid == false && t.Table_ID == x.Table_ID).ToList()[0];
            }
            Bill b = new Bill();
            b.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            BillBusiness b11 = new BillBusiness();
            TableBusiness tb = new TableBusiness();
            CaffeTable t = tb.getCaffeTables().Where(x => x.Table_ID == Convert.ToInt32(button7.Text)).ToList()[0];
            TableBusiness.curentTable = t;
            t.Taken = true;
            tb.UpdateTable(t);
            try
            {
                BillBusiness.currentBill = b11.getCaffeBills().Where(x => x.Paid == false && t.Table_ID == x.Table_ID).ToList()[0];
            }
            catch (Exception ex)
            {
                b11.InsertCaffeBill(new CaffeBill(999, t.Table_ID, 0, DateTime.Now, false));
                BillBusiness.currentBill = b11.getCaffeBills().Where(x => x.Paid == false && t.Table_ID == x.Table_ID).ToList()[0];
            }
            Bill b = new Bill();
            b.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            BillBusiness b11 = new BillBusiness();
            TableBusiness tb = new TableBusiness();
            CaffeTable t = tb.getCaffeTables().Where(x => x.Table_ID == Convert.ToInt32(button13.Text)).ToList()[0];
            TableBusiness.curentTable = t;
            t.Taken = true;
            tb.UpdateTable(t);
            try
            {
                BillBusiness.currentBill = b11.getCaffeBills().Where(x => x.Paid == false && t.Table_ID == x.Table_ID).ToList()[0];
            }
            catch (Exception ex)
            {
                b11.InsertCaffeBill(new CaffeBill(999, t.Table_ID, 0, DateTime.Now, false));
                BillBusiness.currentBill = b11.getCaffeBills().Where(x => x.Paid == false && t.Table_ID == x.Table_ID).ToList()[0];
            }
            Bill b = new Bill();
            b.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BillBusiness b11 = new BillBusiness();
            TableBusiness tb = new TableBusiness();
            CaffeTable t = tb.getCaffeTables().Where(x => x.Table_ID == Convert.ToInt32(button6.Text)).ToList()[0];
            TableBusiness.curentTable = t;
            t.Taken = true;
            tb.UpdateTable(t);
            try
            {
                BillBusiness.currentBill = b11.getCaffeBills().Where(x => x.Paid == false && t.Table_ID == x.Table_ID).ToList()[0];
            }
            catch (Exception ex)
            {
                b11.InsertCaffeBill(new CaffeBill(999, t.Table_ID, 0, DateTime.Now, false));
                BillBusiness.currentBill = b11.getCaffeBills().Where(x => x.Paid == false && t.Table_ID == x.Table_ID).ToList()[0];
            }
            Bill b = new Bill();
            b.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BillBusiness b11 = new BillBusiness();
            TableBusiness tb = new TableBusiness();
            CaffeTable t = tb.getCaffeTables().Where(x => x.Table_ID == Convert.ToInt32(button5.Text)).ToList()[0];
            TableBusiness.curentTable = t;
            t.Taken = true;
            tb.UpdateTable(t);
            try
            {
                BillBusiness.currentBill = b11.getCaffeBills().Where(x => x.Paid == false && t.Table_ID == x.Table_ID).ToList()[0];
            }
            catch (Exception ex)
            {
                b11.InsertCaffeBill(new CaffeBill(999, t.Table_ID, 0, DateTime.Now, false));
                BillBusiness.currentBill = b11.getCaffeBills().Where(x => x.Paid == false && t.Table_ID == x.Table_ID).ToList()[0];
            }
            Bill b = new Bill();
            b.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            BillBusiness b11 = new BillBusiness();
            TableBusiness tb = new TableBusiness();
            CaffeTable t = tb.getCaffeTables().Where(x => x.Table_ID == Convert.ToInt32(button1.Text)).ToList()[0];
            TableBusiness.curentTable = t;
            t.Taken = true;
            tb.UpdateTable(t);
            try
            {
                BillBusiness.currentBill = b11.getCaffeBills().Where(x => x.Paid == false && t.Table_ID == x.Table_ID).ToList()[0];
            }
            catch (Exception ex)
            {
                b11.InsertCaffeBill(new CaffeBill(999, t.Table_ID, 0, DateTime.Now, false));
                BillBusiness.currentBill = b11.getCaffeBills().Where(x => x.Paid == false && t.Table_ID == x.Table_ID).ToList()[0];
            }
            Bill b = new Bill();
            b.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            BillBusiness b11 = new BillBusiness();
            TableBusiness tb = new TableBusiness();
            CaffeTable t = tb.getCaffeTables().Where(x => x.Table_ID == Convert.ToInt32(button11.Text)).ToList()[0];
            TableBusiness.curentTable = t;
            t.Taken = true;
            tb.UpdateTable(t);
            try
            {
                BillBusiness.currentBill = b11.getCaffeBills().Where(x => x.Paid == false && t.Table_ID == x.Table_ID).ToList()[0];
            }
            catch (Exception ex)
            {
                b11.InsertCaffeBill(new CaffeBill(999, t.Table_ID, 0, DateTime.Now, false));
                BillBusiness.currentBill = b11.getCaffeBills().Where(x => x.Paid == false && t.Table_ID == x.Table_ID).ToList()[0];
            }
            Bill b = new Bill();
            b.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            BillBusiness b11 = new BillBusiness();
            TableBusiness tb = new TableBusiness();
            CaffeTable t = tb.getCaffeTables().Where(x => x.Table_ID == Convert.ToInt32(button12.Text)).ToList()[0];
            TableBusiness.curentTable = t;
            t.Taken = true;
            tb.UpdateTable(t);
            try
            {
                BillBusiness.currentBill = b11.getCaffeBills().Where(x => x.Paid == false && t.Table_ID == x.Table_ID).ToList()[0];
            }
            catch (Exception ex)
            {
                b11.InsertCaffeBill(new CaffeBill(999, t.Table_ID, 0, DateTime.Now, false));
                BillBusiness.currentBill = b11.getCaffeBills().Where(x => x.Paid == false && t.Table_ID == x.Table_ID).ToList()[0];
            }
            Bill b = new Bill();
            b.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            BillBusiness b11 = new BillBusiness();
            TableBusiness tb = new TableBusiness();
            CaffeTable t = tb.getCaffeTables().Where(x => x.Table_ID == Convert.ToInt32(button14.Text)).ToList()[0];
            TableBusiness.curentTable = t;
            t.Taken = true;
            tb.UpdateTable(t);
            try
            {
                BillBusiness.currentBill = b11.getCaffeBills().Where(x => x.Paid == false && t.Table_ID == x.Table_ID).ToList()[0];
            }
            catch (Exception ex)
            {
                b11.InsertCaffeBill(new CaffeBill(999, t.Table_ID, 0, DateTime.Now, false));
                BillBusiness.currentBill = b11.getCaffeBills().Where(x => x.Paid == false && t.Table_ID == x.Table_ID).ToList()[0];
            }
            Bill b = new Bill();
            b.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            BillBusiness b11 = new BillBusiness();
            TableBusiness tb = new TableBusiness();
            CaffeTable t = tb.getCaffeTables().Where(x => x.Table_ID == Convert.ToInt32(button17.Text)).ToList()[0];
            TableBusiness.curentTable = t;
            t.Taken = true;
            tb.UpdateTable(t);
            try
            {
                BillBusiness.currentBill = b11.getCaffeBills().Where(x => x.Paid == false && t.Table_ID == x.Table_ID).ToList()[0];
            }
            catch (Exception ex)
            {
                b11.InsertCaffeBill(new CaffeBill(999, t.Table_ID, 0, DateTime.Now, false));
                BillBusiness.currentBill = b11.getCaffeBills().Where(x => x.Paid == false && t.Table_ID == x.Table_ID).ToList()[0];
            }
            Bill b = new Bill();
            b.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            BillBusiness b11 = new BillBusiness();
            TableBusiness tb = new TableBusiness();
            CaffeTable t = tb.getCaffeTables().Where(x => x.Table_ID == Convert.ToInt32(button16.Text)).ToList()[0];
            TableBusiness.curentTable = t;
            t.Taken = true;
            tb.UpdateTable(t);
            try
            {
                BillBusiness.currentBill = b11.getCaffeBills().Where(x => x.Paid == false && t.Table_ID == x.Table_ID).ToList()[0];
            }
            catch (Exception ex)
            {
                b11.InsertCaffeBill(new CaffeBill(999, t.Table_ID, 0, DateTime.Now, false));
                BillBusiness.currentBill = b11.getCaffeBills().Where(x => x.Paid == false && t.Table_ID == x.Table_ID).ToList()[0];
            }
            Bill b = new Bill();
            b.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            BillBusiness b11 = new BillBusiness();
            TableBusiness tb = new TableBusiness();
            CaffeTable t = tb.getCaffeTables().Where(x => x.Table_ID == Convert.ToInt32(button15.Text)).ToList()[0];
            TableBusiness.curentTable = t;
            t.Taken = true;
            tb.UpdateTable(t);
            try
            {
                BillBusiness.currentBill = b11.getCaffeBills().Where(x => x.Paid == false && t.Table_ID == x.Table_ID).ToList()[0];
            }
            catch (Exception ex)
            {
                b11.InsertCaffeBill(new CaffeBill(999, t.Table_ID, 0, DateTime.Now, false));
                BillBusiness.currentBill = b11.getCaffeBills().Where(x => x.Paid == false && t.Table_ID == x.Table_ID).ToList()[0];
            }
            Bill b = new Bill();
            b.Show();
        }
    }
}
