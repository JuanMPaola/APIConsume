using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIConsume
{
    public partial class Frm_Post : Form
    {
        public Frm_Post()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product prod = new Product();

            prod.Id = Convert.ToInt32(TxtBox_Id.Text);
            prod.Title = TxtBox_Title.Text;
            prod.Price = Convert.ToInt32(TxtBox_Price.Text);
            prod.Category = TxtBox_Category.Text;
            prod.Description = TxtBox_Description.Text;

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
