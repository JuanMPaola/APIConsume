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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.btnGetById = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.textBoxLimit = new System.Windows.Forms.TextBox();
            this.btnLimit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
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
            this.ProductsGrid.Size = new System.Drawing.Size(658, 423);
            this.ProductsGrid.TabIndex = 1;
            // 
            // Tbx_Id
            // 
            this.Tbx_Id.Location = new System.Drawing.Point(0, 0);
            this.Tbx_Id.Name = "Tbx_Id";
            this.Tbx_Id.Size = new System.Drawing.Size(100, 20);
            this.Tbx_Id.TabIndex = 12;
            // 
            // Btn_GetById
            // 
            this.Btn_GetById.Location = new System.Drawing.Point(0, 0);
            this.Btn_GetById.Name = "Btn_GetById";
            this.Btn_GetById.Size = new System.Drawing.Size(75, 23);
            this.Btn_GetById.TabIndex = 13;
            // 
            // Btn_PostProduct
            // 
            this.Btn_PostProduct.Location = new System.Drawing.Point(0, 0);
            this.Btn_PostProduct.Name = "Btn_PostProduct";
            this.Btn_PostProduct.Size = new System.Drawing.Size(75, 23);
            this.Btn_PostProduct.TabIndex = 15;
            // 
            // GetWithLimit
            // 
            this.GetWithLimit.Location = new System.Drawing.Point(0, 0);
            this.GetWithLimit.Name = "GetWithLimit";
            this.GetWithLimit.Size = new System.Drawing.Size(75, 23);
            this.GetWithLimit.TabIndex = 14;
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
            this.btn_order.Location = new System.Drawing.Point(0, 0);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(75, 23);
            this.btn_order.TabIndex = 14;
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
            this.panel2.Controls.Add(this.textBoxId);
            this.panel2.Controls.Add(this.btnGetById);
            this.panel2.Controls.Add(this.btnOrder);
            this.panel2.Controls.Add(this.btnPost);
            this.panel2.Controls.Add(this.textBoxLimit);
            this.panel2.Controls.Add(this.btnLimit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(718, 67);
            this.panel2.TabIndex = 11;
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
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(198, 15);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(28, 20);
            this.textBoxId.TabIndex = 2;
            // 
            // btnGetById
            // 
            this.btnGetById.Location = new System.Drawing.Point(111, 14);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(81, 20);
            this.btnGetById.TabIndex = 3;
            this.btnGetById.Text = "Get by Id";
            this.btnGetById.UseVisualStyleBackColor = true;
            this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(439, 12);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 7;
            this.btnOrder.Text = "Descendent\r\n";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(232, 14);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(80, 20);
            this.btnPost.TabIndex = 4;
            this.btnPost.Text = "Post Product";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // textBoxLimit
            // 
            this.textBoxLimit.Location = new System.Drawing.Point(403, 13);
            this.textBoxLimit.Name = "textBoxLimit";
            this.textBoxLimit.Size = new System.Drawing.Size(30, 20);
            this.textBoxLimit.TabIndex = 6;
            // 
            // btnLimit
            // 
            this.btnLimit.Location = new System.Drawing.Point(318, 13);
            this.btnLimit.Name = "btnLimit";
            this.btnLimit.Size = new System.Drawing.Size(78, 21);
            this.btnLimit.TabIndex = 5;
            this.btnLimit.Text = "Get with Limit";
            this.btnLimit.UseVisualStyleBackColor = true;
            this.btnLimit.Click += new System.EventHandler(this.btnLimit_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 463);
            this.panel3.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(688, 51);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(30, 463);
            this.panel7.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(30, 474);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(658, 40);
            this.panel4.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 514);
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
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.TextBox textBoxLimit;
        private System.Windows.Forms.Button btnLimit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

