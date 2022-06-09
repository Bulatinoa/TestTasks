namespace DataBase
{
    partial class Add_Form_Commun
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
            this.a_idparrent = new System.Windows.Forms.Label();
            this.textBox_a_idparent = new System.Windows.Forms.TextBox();
            this.a_idchild = new System.Windows.Forms.Label();
            this.a_linkname = new System.Windows.Forms.Label();
            this.textBox_a_idchild = new System.Windows.Forms.TextBox();
            this.textBox_a_linkname = new System.Windows.Forms.TextBox();
            this.btn_aSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.a_idparrent, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_a_idparent, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.a_idchild, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.a_linkname, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_a_idchild, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_a_linkname, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_aSave, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 161);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // a_idparrent
            // 
            this.a_idparrent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.a_idparrent.AutoSize = true;
            this.a_idparrent.Location = new System.Drawing.Point(73, 13);
            this.a_idparrent.Name = "a_idparrent";
            this.a_idparrent.Size = new System.Drawing.Size(45, 13);
            this.a_idparrent.TabIndex = 0;
            this.a_idparrent.Text = "idparent";
            // 
            // textBox_a_idparent
            // 
            this.textBox_a_idparent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_a_idparent.Location = new System.Drawing.Point(195, 10);
            this.textBox_a_idparent.Name = "textBox_a_idparent";
            this.textBox_a_idparent.Size = new System.Drawing.Size(186, 20);
            this.textBox_a_idparent.TabIndex = 1;
            // 
            // a_idchild
            // 
            this.a_idchild.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.a_idchild.AutoSize = true;
            this.a_idchild.Location = new System.Drawing.Point(77, 53);
            this.a_idchild.Name = "a_idchild";
            this.a_idchild.Size = new System.Drawing.Size(37, 13);
            this.a_idchild.TabIndex = 0;
            this.a_idchild.Text = "idchild";
            // 
            // a_linkname
            // 
            this.a_linkname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.a_linkname.AutoSize = true;
            this.a_linkname.Location = new System.Drawing.Point(71, 93);
            this.a_linkname.Name = "a_linkname";
            this.a_linkname.Size = new System.Drawing.Size(49, 13);
            this.a_linkname.TabIndex = 0;
            this.a_linkname.Text = "linkname";
            // 
            // textBox_a_idchild
            // 
            this.textBox_a_idchild.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_a_idchild.Location = new System.Drawing.Point(195, 50);
            this.textBox_a_idchild.Name = "textBox_a_idchild";
            this.textBox_a_idchild.Size = new System.Drawing.Size(186, 20);
            this.textBox_a_idchild.TabIndex = 1;
            // 
            // textBox_a_linkname
            // 
            this.textBox_a_linkname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_a_linkname.Location = new System.Drawing.Point(195, 90);
            this.textBox_a_linkname.Name = "textBox_a_linkname";
            this.textBox_a_linkname.Size = new System.Drawing.Size(186, 20);
            this.textBox_a_linkname.TabIndex = 1;
            // 
            // btn_aSave
            // 
            this.btn_aSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_aSave.Location = new System.Drawing.Point(250, 129);
            this.btn_aSave.Name = "btn_aSave";
            this.btn_aSave.Size = new System.Drawing.Size(75, 23);
            this.btn_aSave.TabIndex = 2;
            this.btn_aSave.Text = "Сохранить";
            this.btn_aSave.UseVisualStyleBackColor = true;
            this.btn_aSave.Click += new System.EventHandler(this.btn_aSave_Click);
            // 
            // Add_Form_Commun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Add_Form_Commun";
            this.Text = "Add_Form";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label a_idparrent;
        private System.Windows.Forms.TextBox textBox_a_idparent;
        private System.Windows.Forms.Label a_idchild;
        private System.Windows.Forms.Label a_linkname;
        private System.Windows.Forms.TextBox textBox_a_idchild;
        private System.Windows.Forms.TextBox textBox_a_linkname;
        private System.Windows.Forms.Button btn_aSave;
    }
}