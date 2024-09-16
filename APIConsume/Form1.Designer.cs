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
            this.Call_API = new System.Windows.Forms.Button();
            this.ProductsGrid = new System.Windows.Forms.DataGridView();
            this.Tbx_Id = new System.Windows.Forms.TextBox();
            this.Btn_GetById = new System.Windows.Forms.Button();
            this.Btn_PostProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Call_API
            // 
            this.Call_API.Location = new System.Drawing.Point(12, 12);
            this.Call_API.Name = "Call_API";
            this.Call_API.Size = new System.Drawing.Size(75, 20);
            this.Call_API.TabIndex = 0;
            this.Call_API.Text = "Get from API";
            this.Call_API.UseVisualStyleBackColor = true;
            this.Call_API.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductsGrid
            // 
            this.ProductsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGrid.Location = new System.Drawing.Point(12, 48);
            this.ProductsGrid.Name = "ProductsGrid";
            this.ProductsGrid.Size = new System.Drawing.Size(539, 429);
            this.ProductsGrid.TabIndex = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 489);
            this.Controls.Add(this.Btn_PostProduct);
            this.Controls.Add(this.Btn_GetById);
            this.Controls.Add(this.Tbx_Id);
            this.Controls.Add(this.ProductsGrid);
            this.Controls.Add(this.Call_API);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.button1_aClick);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Call_API;
        private System.Windows.Forms.DataGridView ProductsGrid;
        private System.Windows.Forms.TextBox Tbx_Id;
        private System.Windows.Forms.Button Btn_GetById;
        private System.Windows.Forms.Button Btn_PostProduct;
    }
}

