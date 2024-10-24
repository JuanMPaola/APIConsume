namespace APIConsume
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductsGrid = new System.Windows.Forms.DataGridView();
            this.Tbx_Id = new System.Windows.Forms.TextBox();
            this.Btn_GetById = new System.Windows.Forms.Button();
            this.Btn_PostProduct = new System.Windows.Forms.Button();
            this.GetWithLimit = new System.Windows.Forms.Button();
            this.textBox_Limit = new System.Windows.Forms.TextBox();
            this.btn_order = new System.Windows.Forms.Button();
            this.comboBox_categories = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductsGrid
            // 
            this.ProductsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.ProductsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsGrid.Location = new System.Drawing.Point(30, 51);
            this.ProductsGrid.Name = "ProductsGrid";
            this.ProductsGrid.Size = new System.Drawing.Size(658, 398);
            this.ProductsGrid.TabIndex = 1;
            // 
            // Tbx_Id
            // 
            this.Tbx_Id.Location = new System.Drawing.Point(216, 15);
            this.Tbx_Id.Name = "Tbx_Id";
            this.Tbx_Id.Size = new System.Drawing.Size(28, 20);
            this.Tbx_Id.TabIndex = 2;
            // 
            // Btn_GetById
            // 
            this.Btn_GetById.Location = new System.Drawing.Point(129, 14);
            this.Btn_GetById.Name = "Btn_GetById";
            this.Btn_GetById.Size = new System.Drawing.Size(81, 20);
            this.Btn_GetById.TabIndex = 3;
            this.Btn_GetById.Text = "Get by Id";
            this.Btn_GetById.UseVisualStyleBackColor = true;
            this.Btn_GetById.Click += new System.EventHandler(this.Btn_GetById_Click);
            // 
            // Btn_PostProduct
            // 
            this.Btn_PostProduct.Location = new System.Drawing.Point(250, 14);
            this.Btn_PostProduct.Name = "Btn_PostProduct";
            this.Btn_PostProduct.Size = new System.Drawing.Size(80, 20);
            this.Btn_PostProduct.TabIndex = 4;
            this.Btn_PostProduct.Text = "Post Product";
            this.Btn_PostProduct.UseVisualStyleBackColor = true;
            this.Btn_PostProduct.Click += new System.EventHandler(this.Btn_PostProduct_Click);
            // 
            // GetWithLimit
            // 
            this.GetWithLimit.Location = new System.Drawing.Point(336, 13);
            this.GetWithLimit.Name = "GetWithLimit";
            this.GetWithLimit.Size = new System.Drawing.Size(78, 21);
            this.GetWithLimit.TabIndex = 5;
            this.GetWithLimit.Text = "Get with Limit";
            this.GetWithLimit.UseVisualStyleBackColor = true;
            this.GetWithLimit.Click += new System.EventHandler(this.GetWithLimit_Click);
            // 
            // textBox_Limit
            // 
            this.textBox_Limit.Location = new System.Drawing.Point(421, 13);
            this.textBox_Limit.Name = "textBox_Limit";
            this.textBox_Limit.Size = new System.Drawing.Size(30, 20);
            this.textBox_Limit.TabIndex = 6;
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(457, 12);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(75, 23);
            this.btn_order.TabIndex = 7;
            this.btn_order.Text = "Descendent\r\n";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // comboBox_categories
            // 
            this.comboBox_categories.FormattingEnabled = true;
            this.comboBox_categories.Location = new System.Drawing.Point(538, 12);
            this.comboBox_categories.Name = "comboBox_categories";
            this.comboBox_categories.Size = new System.Drawing.Size(96, 21);
            this.comboBox_categories.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.comboBox_categories);
            this.panel1.Controls.Add(this.Tbx_Id);
            this.panel1.Controls.Add(this.Btn_GetById);
            this.panel1.Controls.Add(this.btn_order);
            this.panel1.Controls.Add(this.Btn_PostProduct);
            this.panel1.Controls.Add(this.textBox_Limit);
            this.panel1.Controls.Add(this.GetWithLimit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 51);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(718, 67);
            this.panel2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(28, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "Get by Id";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Descendent\r\n";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(232, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 20);
            this.button3.TabIndex = 4;
            this.button3.Text = "Post Product";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(403, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(30, 20);
            this.textBox2.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(318, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 21);
            this.button4.TabIndex = 5;
            this.button4.Text = "Get with Limit";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 438);
            this.panel3.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(688, 51);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(30, 438);
            this.panel7.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(30, 449);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(658, 40);
            this.panel4.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(520, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 489);
            this.Controls.Add(this.ProductsGrid);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView ProductsGrid;
        private System.Windows.Forms.TextBox Tbx_Id;
        private System.Windows.Forms.Button Btn_GetById;
        private System.Windows.Forms.Button Btn_PostProduct;
        private System.Windows.Forms.Button GetWithLimit;
        private System.Windows.Forms.TextBox textBox_Limit;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.ComboBox comboBox_categories;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

