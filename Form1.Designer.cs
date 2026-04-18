namespace QualifExam
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnCreate = new Button();
            txtYearCreate = new TextBox();
            txtAuthorCreate = new TextBox();
            txtNameCreate = new TextBox();
            lblYearCreate = new Label();
            lblAuthorCreate = new Label();
            lblNameCreate = new Label();
            tabPage2 = new TabPage();
            btnDelete = new Button();
            btnEdit = new Button();
            txtYearEdit = new TextBox();
            txtAuthorEdit = new TextBox();
            txtNameEdit = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.875F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.125F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel1.Controls.Add(tabControl1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(537, 444);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(546, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(251, 444);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnCreate);
            tabPage1.Controls.Add(txtYearCreate);
            tabPage1.Controls.Add(txtAuthorCreate);
            tabPage1.Controls.Add(txtNameCreate);
            tabPage1.Controls.Add(lblYearCreate);
            tabPage1.Controls.Add(lblAuthorCreate);
            tabPage1.Controls.Add(lblNameCreate);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(243, 416);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Добавить";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(19, 278);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(193, 84);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Добавить";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtYearCreate
            // 
            txtYearCreate.Location = new Point(38, 83);
            txtYearCreate.Name = "txtYearCreate";
            txtYearCreate.Size = new Size(199, 23);
            txtYearCreate.TabIndex = 5;
            txtYearCreate.KeyPress += txtYearCreate_KeyPress;
            // 
            // txtAuthorCreate
            // 
            txtAuthorCreate.Location = new Point(71, 48);
            txtAuthorCreate.Name = "txtAuthorCreate";
            txtAuthorCreate.Size = new Size(166, 23);
            txtAuthorCreate.TabIndex = 4;
            // 
            // txtNameCreate
            // 
            txtNameCreate.Location = new Point(71, 15);
            txtNameCreate.Name = "txtNameCreate";
            txtNameCreate.Size = new Size(166, 23);
            txtNameCreate.TabIndex = 3;
            // 
            // lblYearCreate
            // 
            lblYearCreate.AutoSize = true;
            lblYearCreate.Location = new Point(6, 86);
            lblYearCreate.Name = "lblYearCreate";
            lblYearCreate.Size = new Size(26, 15);
            lblYearCreate.TabIndex = 2;
            lblYearCreate.Text = "Год";
            // 
            // lblAuthorCreate
            // 
            lblAuthorCreate.AutoSize = true;
            lblAuthorCreate.Location = new Point(6, 51);
            lblAuthorCreate.Name = "lblAuthorCreate";
            lblAuthorCreate.Size = new Size(61, 15);
            lblAuthorCreate.TabIndex = 1;
            lblAuthorCreate.Text = "Режиссёр";
            // 
            // lblNameCreate
            // 
            lblNameCreate.AutoSize = true;
            lblNameCreate.Location = new Point(6, 18);
            lblNameCreate.Name = "lblNameCreate";
            lblNameCreate.Size = new Size(59, 15);
            lblNameCreate.TabIndex = 0;
            lblNameCreate.Text = "Название";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnDelete);
            tabPage2.Controls.Add(btnEdit);
            tabPage2.Controls.Add(txtYearEdit);
            tabPage2.Controls.Add(txtAuthorEdit);
            tabPage2.Controls.Add(txtNameEdit);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(243, 416);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Редактировать";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(125, 315);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 84);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(7, 315);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 84);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Добавить";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtYearEdit
            // 
            txtYearEdit.Location = new Point(38, 82);
            txtYearEdit.Name = "txtYearEdit";
            txtYearEdit.Size = new Size(199, 23);
            txtYearEdit.TabIndex = 12;
            txtYearEdit.KeyPress += txtYearEdit_KeyPress;
            // 
            // txtAuthorEdit
            // 
            txtAuthorEdit.Location = new Point(71, 47);
            txtAuthorEdit.Name = "txtAuthorEdit";
            txtAuthorEdit.Size = new Size(166, 23);
            txtAuthorEdit.TabIndex = 11;
            // 
            // txtNameEdit
            // 
            txtNameEdit.Location = new Point(71, 14);
            txtNameEdit.Name = "txtNameEdit";
            txtNameEdit.Size = new Size(166, 23);
            txtNameEdit.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 85);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 9;
            label1.Text = "Год";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 50);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 8;
            label2.Text = "Режиссёр";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 17);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 7;
            label3.Text = "Название";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnCreate;
        private TextBox txtYearCreate;
        private TextBox txtAuthorCreate;
        private TextBox txtNameCreate;
        private Label lblYearCreate;
        private Label lblAuthorCreate;
        private Label lblNameCreate;
        private TabPage tabPage2;
        private Button btnEdit;
        private TextBox txtYearEdit;
        private TextBox txtAuthorEdit;
        private TextBox txtNameEdit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnDelete;
    }
}
