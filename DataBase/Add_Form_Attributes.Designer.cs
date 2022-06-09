namespace DataBase
{
    partial class Add_Form_Attributes
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
            this.a_name = new System.Windows.Forms.Label();
            this.textBox_a_name = new System.Windows.Forms.TextBox();
            this.a_value = new System.Windows.Forms.Label();
            this.textBox_a_value = new System.Windows.Forms.TextBox();
            this.btn_aSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.a_name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_a_name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.a_value, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_a_value, 1, 1);
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
            // a_name
            // 
            this.a_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.a_name.AutoSize = true;
            this.a_name.Location = new System.Drawing.Point(79, 20);
            this.a_name.Name = "a_name";
            this.a_name.Size = new System.Drawing.Size(33, 13);
            this.a_name.TabIndex = 0;
            this.a_name.Text = "name";
            // 
            // textBox_a_name
            // 
            this.textBox_a_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_a_name.Location = new System.Drawing.Point(195, 16);
            this.textBox_a_name.Name = "textBox_a_name";
            this.textBox_a_name.Size = new System.Drawing.Size(186, 20);
            this.textBox_a_name.TabIndex = 1;
            // 
            // a_value
            // 
            this.a_value.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.a_value.AutoSize = true;
            this.a_value.Location = new System.Drawing.Point(79, 73);
            this.a_value.Name = "a_value";
            this.a_value.Size = new System.Drawing.Size(33, 13);
            this.a_value.TabIndex = 0;
            this.a_value.Text = "value";
            // 
            // textBox_a_value
            // 
            this.textBox_a_value.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_a_value.Location = new System.Drawing.Point(195, 69);
            this.textBox_a_value.Name = "textBox_a_value";
            this.textBox_a_value.Size = new System.Drawing.Size(186, 20);
            this.textBox_a_value.TabIndex = 1;
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
            // Add_Form_Attributes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Add_Form_Attributes";
            this.Text = "Add_Form";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label a_name;
        private System.Windows.Forms.Label a_value;
        private System.Windows.Forms.TextBox textBox_a_name;
        private System.Windows.Forms.TextBox textBox_a_value;
        private System.Windows.Forms.Button btn_aSave;
    }
}