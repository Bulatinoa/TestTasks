namespace DataBase
{
    partial class AttributesForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNew1 = new System.Windows.Forms.Button();
            this.btnRefresh1 = new System.Windows.Forms.Button();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.treeView3 = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnNew1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRefresh1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSave1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.treeView3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 307);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnNew1
            // 
            this.btnNew1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNew1.Location = new System.Drawing.Point(12, 19);
            this.btnNew1.Name = "btnNew1";
            this.btnNew1.Size = new System.Drawing.Size(101, 23);
            this.btnNew1.TabIndex = 8;
            this.btnNew1.Text = "Новая запись";
            this.btnNew1.UseVisualStyleBackColor = true;
            this.btnNew1.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnRefresh1
            // 
            this.btnRefresh1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh1.Location = new System.Drawing.Point(150, 19);
            this.btnRefresh1.Name = "btnRefresh1";
            this.btnRefresh1.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh1.TabIndex = 1;
            this.btnRefresh1.Text = "Обновить";
            this.btnRefresh1.UseVisualStyleBackColor = true;
            this.btnRefresh1.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave1
            // 
            this.btnSave1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave1.Location = new System.Drawing.Point(275, 19);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(75, 23);
            this.btnSave1.TabIndex = 10;
            this.btnSave1.Text = "Сохранить";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnDelete1
            // 
            this.btnDelete1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete1.Location = new System.Drawing.Point(400, 19);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(75, 23);
            this.btnDelete1.TabIndex = 9;
            this.btnDelete1.Text = "Удалить";
            this.btnDelete1.UseVisualStyleBackColor = true;
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // treeView3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.treeView3, 4);
            this.treeView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView3.Location = new System.Drawing.Point(3, 64);
            this.treeView3.Name = "treeView3";
            this.treeView3.Size = new System.Drawing.Size(494, 240);
            this.treeView3.TabIndex = 11;
            // 
            // AttributesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 307);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AttributesForm";
            this.Text = "Таблица \"Связи\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNew1;
        private System.Windows.Forms.Button btnDelete1;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.TreeView treeView3;
        private System.Windows.Forms.Button btnRefresh1;
    }
}

