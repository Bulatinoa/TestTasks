namespace DataBase
{
    partial class MainForm
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
            this.btnCommuns = new System.Windows.Forms.Button();
            this.btnObjects = new System.Windows.Forms.Button();
            this.btnAttributes = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Controls.Add(this.btnCommuns, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnObjects, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAttributes, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(441, 112);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCommuns
            // 
            this.btnCommuns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCommuns.Location = new System.Drawing.Point(35, 44);
            this.btnCommuns.Name = "btnCommuns";
            this.btnCommuns.Size = new System.Drawing.Size(75, 23);
            this.btnCommuns.TabIndex = 0;
            this.btnCommuns.Text = "Связи";
            this.btnCommuns.UseVisualStyleBackColor = true;
            this.btnCommuns.Click += new System.EventHandler(this.btnCommuns_Click);
            // 
            // btnObjects
            // 
            this.btnObjects.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObjects.Location = new System.Drawing.Point(180, 44);
            this.btnObjects.Name = "btnObjects";
            this.btnObjects.Size = new System.Drawing.Size(75, 23);
            this.btnObjects.TabIndex = 1;
            this.btnObjects.Text = "Объекты";
            this.btnObjects.UseVisualStyleBackColor = true;
            this.btnObjects.Click += new System.EventHandler(this.btnObjects_Click);
            // 
            // btnAttributes
            // 
            this.btnAttributes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAttributes.Location = new System.Drawing.Point(328, 44);
            this.btnAttributes.Name = "btnAttributes";
            this.btnAttributes.Size = new System.Drawing.Size(75, 23);
            this.btnAttributes.TabIndex = 2;
            this.btnAttributes.Text = "Атрибуты";
            this.btnAttributes.UseVisualStyleBackColor = true;
            this.btnAttributes.Click += new System.EventHandler(this.btnAttributes_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 112);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Выбор таблицы";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCommuns;
        private System.Windows.Forms.Button btnObjects;
        private System.Windows.Forms.Button btnAttributes;
    }
}