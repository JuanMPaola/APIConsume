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
        public Product NewProduct { get; private set; }

        public Frm_Post()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product prod = new Product
            {
                Id = Convert.ToInt32(TxtBox_Id.Text),
                Title = TxtBox_Title.Text,
                Price = Convert.ToInt32(TxtBox_Price.Text),
                Category = TxtBox_Category.Text,
                Description = TxtBox_Description.Text
            };

            NewProduct = prod;

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
