using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer.Models;
using System.Linq;

namespace CaffeOrganizer
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        

        private void Bill_Load(object sender, EventArgs e)
        {

            ArticleBusiness ab = new ArticleBusiness();
            refresh();
            textBox1.Text = BillBusiness.currentBill.Total_Price.ToString();
            List<CaffeArticle> pica = ab.GetCaffeArticles();
            foreach (CaffeArticle c in pica.Where(x => x.Packaging == "Bezalkoholna pića").ToList()) 
            {
                comboBox1.Items.Add(c.ToString());
            }
            foreach (CaffeArticle c in pica.Where(x => x.Packaging == "Žestina").ToList())
            {
                comboBox2.Items.Add(c.ToString());
            }
            foreach (CaffeArticle c in pica.Where(x => x.Packaging == "Pivo").ToList())
            {
                comboBox3.Items.Add(c.ToString());
            }
            foreach (CaffeArticle c in pica.Where(x => x.Packaging == "Topli napici").ToList())
            {
                comboBox4.Items.Add(c.ToString());
            }
        }

        public void refresh()
        {
            comboBox1.Text = "Bezalkoholna pica";
            comboBox2.Text = "Zestina";
            comboBox3.Text = "Pivo";
            comboBox4.Text = "Topli napici";
            listBox1.Items.Clear();
            textBox1.Text = BillBusiness.currentBill.Total_Price.ToString();
            ArticleBusiness ab = new ArticleBusiness();
            BillItemBusiness bib = new BillItemBusiness();

            foreach (CaffeBillItem b in bib.GetCaffeBillItems())
            {
                if (b.Bill_ID == BillBusiness.currentBill.Bill_ID)
                {
                    CaffeArticle temp = ab.GetCaffeArticles().Where(x => x.Article_ID == b.Article_ID).ToList()[0];
                    listBox1.Items.Add(temp.ToString() + " x" + b.Quantity);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BillBusiness billb = new BillBusiness();
            BillItemBusiness bb = new BillItemBusiness();
            ArticleBusiness ab = new ArticleBusiness();
            if (comboBox1.Text != "Bezalkoholna pica")
            {
                string tempname = comboBox1.Text.Split('-')[0];
                CaffeArticle ca = ab.GetCaffeArticles().Where(x => x.Name == tempname).ToList()[0];
                BillBusiness.currentBill.Total_Price += ca.Price;
                billb.UpdateCaffeBill(BillBusiness.currentBill);
                try
                {
                    CaffeBillItem cb = new CaffeBillItem(ca.Article_ID, BillBusiness.currentBill.Bill_ID, 1);
                    bb.InsertBillItem(cb);
                }
                catch
                {
                    CaffeBillItem zeka = bb.GetCaffeBillItems().Where(x => x.Article_ID == ca.Article_ID && x.Bill_ID == BillBusiness.currentBill.Bill_ID).ToList()[0];
                    zeka.Quantity++;
                    bb.UpdateBillItem(zeka);
                }
                refresh();
            }
            if (comboBox2.Text != "Zestina")
            {
                string tempname = comboBox2.Text.Split('-')[0];
                CaffeArticle ca = ab.GetCaffeArticles().Where(x => x.Name == tempname).ToList()[0];
                BillBusiness.currentBill.Total_Price += ca.Price;
                billb.UpdateCaffeBill(BillBusiness.currentBill);
                try
                {
                    CaffeBillItem cb = new CaffeBillItem(ca.Article_ID, BillBusiness.currentBill.Bill_ID, 1);
                    bb.InsertBillItem(cb);
                }
                catch
                {
                    CaffeBillItem zeka = bb.GetCaffeBillItems().Where(x => x.Article_ID == ca.Article_ID && x.Bill_ID == BillBusiness.currentBill.Bill_ID).ToList()[0];
                    zeka.Quantity++;
                    bb.UpdateBillItem(zeka);
                }
                refresh();
            }
            if (comboBox3.Text != "Pivo")
            {
                string tempname = comboBox3.Text.Split('-')[0];
                CaffeArticle ca = ab.GetCaffeArticles().Where(x => x.Name == tempname).ToList()[0];
                BillBusiness.currentBill.Total_Price += ca.Price;
                billb.UpdateCaffeBill(BillBusiness.currentBill);
                try
                {
                    CaffeBillItem cb = new CaffeBillItem(ca.Article_ID, BillBusiness.currentBill.Bill_ID, 1);
                    bb.InsertBillItem(cb);
                }
                catch
                {
                    CaffeBillItem zeka = bb.GetCaffeBillItems().Where(x => x.Article_ID == ca.Article_ID && x.Bill_ID == BillBusiness.currentBill.Bill_ID).ToList()[0];
                    zeka.Quantity++;
                    bb.UpdateBillItem(zeka);
                }
                refresh();
            }
            if (comboBox4.Text != "Topli napici")
            {
                string tempname = comboBox4.Text.Split('-')[0];
                CaffeArticle ca = ab.GetCaffeArticles().Where(x => x.Name == tempname).ToList()[0];
                BillBusiness.currentBill.Total_Price += ca.Price;
                billb.UpdateCaffeBill(BillBusiness.currentBill);
                try
                {
                    CaffeBillItem cb = new CaffeBillItem(ca.Article_ID, BillBusiness.currentBill.Bill_ID, 1);
                    bb.InsertBillItem(cb);
                }
                catch
                {
                    CaffeBillItem zeka = bb.GetCaffeBillItems().Where(x => x.Article_ID == ca.Article_ID && x.Bill_ID == BillBusiness.currentBill.Bill_ID).ToList()[0];
                    zeka.Quantity++;
                    bb.UpdateBillItem(zeka);
                }
                refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TableBusiness tb = new TableBusiness();
            TableBusiness.curentTable.Taken = false;
            tb.UpdateTable(TableBusiness.curentTable);
            BillBusiness bb = new BillBusiness();
            BillBusiness.currentBill.Paid = true;
            bb.UpdateCaffeBill(BillBusiness.currentBill);
            this.Hide();
        }
    }
}
