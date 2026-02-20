using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateGUI
{
    public partial class Form1 : Form
    {
        private BindingSource bsSellers = new BindingSource();

        private const string ConnStr = @"server=localhost;port=3307;uid=root;pwd=;database=ingatlan";
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var sellers = Db.LoadSellers();

            bsSellers.DataSource = sellers;

            listBox1.DataSource = bsSellers;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Id";

            // 13. 
            eladonevlabel.DataBindings.Clear();
            eladonevlabel.DataBindings.Add("Text", bsSellers, "Name");

            // 14.
            teleszamlabel.DataBindings.Clear();
            teleszamlabel.DataBindings.Add("Text", bsSellers, "Phone");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var s = listBox1.SelectedItem as Seller;
            if (s == null)
            {
                hirdblabel.Text = "0";
                return;
            }

            int count = Db.CountRealEstatesBySellerId(s.Id);
            hirdblabel.Text = count.ToString();
        }
    }
}
