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
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsGrid
            // 
            this.ProductsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGrid.Location = new System.Drawing.Point(12, 50);
            this.ProductsGrid.Name = "ProductsGrid";
            this.ProductsGrid.Size = new System.Drawing.Size(692, 427);
            this.ProductsGrid.TabIndex = 1;
            this.ProductsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGrid_CellContentClick);
            // 
            // Tbx_Id
            // 
            this.Tbx_Id.Location = new System.Drawing.Point(180, 13);
            this.Tbx_Id.Name = "Tbx_Id";
            this.Tbx_Id.Size = new System.Drawing.Size(28, 20);
            this.Tbx_Id.TabIndex = 2;
            this.Tbx_Id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Btn_GetById
            // 
            this.Btn_GetById.Location = new System.Drawing.Point(93, 12);
            this.Btn_GetById.Name = "Btn_GetById";
            this.Btn_GetById.Size = new System.Drawing.Size(81, 20);
            this.Btn_GetById.TabIndex = 3;
            this.Btn_GetById.Text = "Get by Id";
            this.Btn_GetById.UseVisualStyleBackColor = true;
            this.Btn_GetById.Click += new System.EventHandler(this.Btn_GetById_Click);
            // 
            // Btn_PostProduct
            // 
            this.Btn_PostProduct.Location = new System.Drawing.Point(214, 12);
            this.Btn_PostProduct.Name = "Btn_PostProduct";
            this.Btn_PostProduct.Size = new System.Drawing.Size(80, 20);
            this.Btn_PostProduct.TabIndex = 4;
            this.Btn_PostProduct.Text = "Post Product";
            this.Btn_PostProduct.UseVisualStyleBackColor = true;
            this.Btn_PostProduct.Click += new System.EventHandler(this.Btn_PostProduct_Click);
            // 
            // GetWithLimit
            // 
            this.GetWithLimit.Location = new System.Drawing.Point(300, 11);
            this.GetWithLimit.Name = "GetWithLimit";
            this.GetWithLimit.Size = new System.Drawing.Size(78, 21);
            this.GetWithLimit.TabIndex = 5;
            this.GetWithLimit.Text = "Get with Limit";
            this.GetWithLimit.UseVisualStyleBackColor = true;
            this.GetWithLimit.Click += new System.EventHandler(this.GetWithLimit_Click);
            // 
            // textBox_Limit
            // 
            this.textBox_Limit.Location = new System.Drawing.Point(385, 11);
            this.textBox_Limit.Name = "textBox_Limit";
            this.textBox_Limit.Size = new System.Drawing.Size(30, 20);
            this.textBox_Limit.TabIndex = 6;
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(421, 10);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(75, 23);
            this.btn_order.TabIndex = 7;
            this.btn_order.Text = "Ascendent";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // comboBox_categories
            // 
            this.comboBox_categories.FormattingEnabled = true;
            this.comboBox_categories.Location = new System.Drawing.Point(502, 10);
            this.comboBox_categories.Name = "comboBox_categories";
            this.comboBox_categories.Size = new System.Drawing.Size(96, 21);
            this.comboBox_categories.TabIndex = 9;
            this.comboBox_categories.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 489);
            this.Controls.Add(this.comboBox_categories);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.textBox_Limit);
            this.Controls.Add(this.GetWithLimit);
            this.Controls.Add(this.Btn_PostProduct);
            this.Controls.Add(this.Btn_GetById);
            this.Controls.Add(this.Tbx_Id);
            this.Controls.Add(this.ProductsGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

