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
        APIConnection api = new APIConnection();
        List<string> categories = new List<string>();
        List<Product> filtered = new List<Product>();
        List<Product> apiProducts = new List<Product>();

        public Form1()
        {
            InitializeComponent();


            categories = api.GetAllCategories();
            categories.Insert(0, "All");
            comboBox1.DataSource = categories;

            apiProducts = api.GetAll();
            ProductsGrid.DataSource = apiProducts;
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            if (btn_order.Text == "Descendent")
            {
                ProductsGrid.DataSource = api.SortResults("desc");
                btn_order.Text = "Ascendent";
            }
            else
            {
                ProductsGrid.DataSource = api.SortResults("asc");
                btn_order.Text = "Descendent";
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedCategory = comboBox1.SelectedItem.ToString();

            if (selectedCategory == "All")
            {
                ProductsGrid.DataSource = apiProducts;
            }
            else
            {
                filtered = api.GetInCategory(apiProducts, selectedCategory);
                ProductsGrid.DataSource = filtered;
            }
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxId.Text, out int productId))
            {
                Product prod = api.GetById(productId);

                if (prod != null)
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

        private void btnPost_Click(object sender, EventArgs e)
        {
            Frm_Post form = new Frm_Post();


            if (form.ShowDialog() == DialogResult.OK)
            {
                Product newProduct = form.NewProduct;

                apiProducts.Add(newProduct);

                ProductsGrid.DataSource = null;
                ProductsGrid.DataSource = apiProducts;
            }
        }

        private void btnLimit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxLimit.Text, out int limit))
            {
                List<Product> lista = api.LimitResults(limit);
                ProductsGrid.DataSource = lista;
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (btnOrder.Text == "Descendent")
            {
                ProductsGrid.DataSource = api.SortResults("desc");
                btnOrder.Text = "Ascendent";
            }
            else
            {
                ProductsGrid.DataSource = api.SortResults("asc");
                btnOrder.Text = "Descendent";
            }
        }
    }
}
