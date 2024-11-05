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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace APIConsume
{
    public partial class FormPost : Form
    {
        public Product NewProduct { get; private set; }
        public FormPost(List<string> categories)
        {
            InitializeComponent();
            categories.RemoveAt(0);
            comboBoxCategories.DataSource = categories;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product prod = new Product
            {
                Title = TxtBox_Title.Text,
                Price = Convert.ToInt32(TxtBox_Price.Text),
                Category = comboBoxCategories.Text,
                Description = TxtBox_Description.Text
            };

            APIConnection api = new APIConnection();
            api.PostProudct(prod);
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
