namespace APIConsume
{
    partial class Frm_Post
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Add = new System.Windows.Forms.Button();
            this.TxtBox_Id = new System.Windows.Forms.TextBox();
            this.TxtBox_Title = new System.Windows.Forms.TextBox();
            this.TxtBox_Price = new System.Windows.Forms.TextBox();
            this.TxtBox_Description = new System.Windows.Forms.TextBox();
            this.TxtBox_Category = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(78, 239);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(55, 23);
            this.Btn_Add.TabIndex = 0;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtBox_Id
            // 
            this.TxtBox_Id.Location = new System.Drawing.Point(78, 21);
            this.TxtBox_Id.Name = "TxtBox_Id";
            this.TxtBox_Id.Size = new System.Drawing.Size(113, 20);
            this.TxtBox_Id.TabIndex = 1;
            // 
            // TxtBox_Title
            // 
            this.TxtBox_Title.Location = new System.Drawing.Point(78, 62);
            this.TxtBox_Title.Name = "TxtBox_Title";
            this.TxtBox_Title.Size = new System.Drawing.Size(113, 20);
            this.TxtBox_Title.TabIndex = 2;
            // 
            // TxtBox_Price
            // 
            this.TxtBox_Price.Location = new System.Drawing.Point(78, 110);
            this.TxtBox_Price.Name = "TxtBox_Price";
            this.TxtBox_Price.Size = new System.Drawing.Size(113, 20);
            this.TxtBox_Price.TabIndex = 3;
            // 
            // TxtBox_Description
            // 
            this.TxtBox_Description.Location = new System.Drawing.Point(78, 198);
            this.TxtBox_Description.Name = "TxtBox_Description";
            this.TxtBox_Description.Size = new System.Drawing.Size(113, 20);
            this.TxtBox_Description.TabIndex = 4;
            // 
            // TxtBox_Category
            // 
            this.TxtBox_Category.Location = new System.Drawing.Point(78, 153);
            this.TxtBox_Category.Name = "TxtBox_Category";
            this.TxtBox_Category.Size = new System.Drawing.Size(113, 20);
            this.TxtBox_Category.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Description";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(139, 239);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(52, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Frm_Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 274);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBox_Category);
            this.Controls.Add(this.TxtBox_Description);
            this.Controls.Add(this.TxtBox_Price);
            this.Controls.Add(this.TxtBox_Title);
            this.Controls.Add(this.TxtBox_Id);
            this.Controls.Add(this.Btn_Add);
            this.Name = "Frm_Post";
            this.Text = "Frm_Post";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.TextBox TxtBox_Id;
        private System.Windows.Forms.TextBox TxtBox_Title;
        private System.Windows.Forms.TextBox TxtBox_Price;
        private System.Windows.Forms.TextBox TxtBox_Description;
        private System.Windows.Forms.TextBox TxtBox_Category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
    }
}