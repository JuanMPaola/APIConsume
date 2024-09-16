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
    public partial class Form1 : Form
    {
        private string url = "https://fakestoreapi.com";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Product> list = Product.GetAll(url);
            ProductsGrid.DataSource = list;
        }

        private void Btn_GetFromAPI(object sender, EventArgs e)
        {            
            List<Product> list = Product.GetAll(url);
            ProductsGrid.DataSource = list;
        }

        private void button1_aClick(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_GetById_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Tbx_Id.Text, out int productId))
            {
                Product prod = Product.GetById(url, productId);

                if(prod != null)
                {
                    List<Product> productos = new List<Product> { prod };
                    ProductsGrid.DataSource = productos;
                }
                else
                {
                    MessageBox.Show("Product not found");
                }
            }
        }

        private void Btn_PostProduct_Click(object sender, EventArgs e)
        {
            Frm_Post form = new Frm_Post();
            form.ShowDialog();
        }
    }
}
