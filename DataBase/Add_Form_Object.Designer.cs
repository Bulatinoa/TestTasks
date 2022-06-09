namespace DataBase
{
    partial class Add_Form_Object
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.a_type = new System.Windows.Forms.Label();
            this.a_product = new System.Windows.Forms.Label();
            this.textBox_a_type = new System.Windows.Forms.TextBox();
            this.textBox_a_product = new System.Windows.Forms.TextBox();
            this.btn_aSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.a_type, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_a_type, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.a_product, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_a_product, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_aSave, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 161);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // a_type
            // 
            this.a_type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.a_type.AutoSize = true;
            this.a_type.Location = new System.Drawing.Point(82, 20);
            this.a_type.Name = "a_type";
            this.a_type.Size = new System.Drawing.Size(27, 13);
            this.a_type.TabIndex = 0;
            this.a_type.Text = "type";
            // 
            // a_product
            // 
            this.a_product.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.a_product.AutoSize = true;
            this.a_product.Location = new System.Drawing.Point(74, 73);
            this.a_product.Name = "a_product";
            this.a_product.Size = new System.Drawing.Size(43, 13);
            this.a_product.TabIndex = 0;
            this.a_product.Text = "product";
            // 
            // textBox_a_type
            // 
            this.textBox_a_type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_a_type.Location = new System.Drawing.Point(195, 16);
            this.textBox_a_type.Name = "textBox_a_type";
            this.textBox_a_type.Size = new System.Drawing.Size(186, 20);
            this.textBox_a_type.TabIndex = 1;
            // 
            // textBox_a_product
            // 
            this.textBox_a_product.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_a_product.Location = new System.Drawing.Point(195, 69);
            this.textBox_a_product.Name = "textBox_a_product";
            this.textBox_a_product.Size = new System.Drawing.Size(186, 20);
            this.textBox_a_product.TabIndex = 1;
            // 
            // btn_aSave
            // 
            this.btn_aSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_aSave.Location = new System.Drawing.Point(250, 122);
            this.btn_aSave.Name = "btn_aSave";
            this.btn_aSave.Size = new System.Drawing.Size(75, 23);
            this.btn_aSave.TabIndex = 2;
            this.btn_aSave.Text = "Сохранить";
            this.btn_aSave.UseVisualStyleBackColor = true;
            this.btn_aSave.Click += new System.EventHandler(this.btn_aSave_Click);
            // 
            // Add_Form_Object
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Add_Form_Object";
            this.Text = "Add_Form";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label a_type;
        private System.Windows.Forms.Label a_product;
        private System.Windows.Forms.TextBox textBox_a_type;
        private System.Windows.Forms.TextBox textBox_a_product;
        private System.Windows.Forms.Button btn_aSave;
    }
}