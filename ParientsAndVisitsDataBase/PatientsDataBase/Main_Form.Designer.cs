namespace PatientsDataBase
{
    partial class Main_Form
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
            this.btnPatients = new System.Windows.Forms.Button();
            this.btnVisits = new System.Windows.Forms.Button();
            this.btnPandV = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Controls.Add(this.btnPatients, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnVisits, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPandV, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(382, 85);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnPatients
            // 
            this.btnPatients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPatients.Location = new System.Drawing.Point(13, 22);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(100, 40);
            this.btnPatients.TabIndex = 0;
            this.btnPatients.Text = "Пациенты";
            this.btnPatients.UseVisualStyleBackColor = true;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // btnVisits
            // 
            this.btnVisits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVisits.Location = new System.Drawing.Point(139, 22);
            this.btnVisits.Name = "btnVisits";
            this.btnVisits.Size = new System.Drawing.Size(100, 40);
            this.btnVisits.TabIndex = 1;
            this.btnVisits.Text = "Посещения";
            this.btnVisits.UseVisualStyleBackColor = true;
            this.btnVisits.Click += new System.EventHandler(this.btnVisits_Click);
            // 
            // btnPandV
            // 
            this.btnPandV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPandV.Location = new System.Drawing.Point(267, 22);
            this.btnPandV.Name = "btnPandV";
            this.btnPandV.Size = new System.Drawing.Size(100, 40);
            this.btnPandV.TabIndex = 2;
            this.btnPandV.Text = "Пациенты и посещения";
            this.btnPandV.UseVisualStyleBackColor = true;
            this.btnPandV.Click += new System.EventHandler(this.btnPandV_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 85);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Button btnVisits;
        private System.Windows.Forms.Button btnPandV;
    }
}