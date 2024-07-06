namespace To_Do_List
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtSalary = new TextBox();
            txtWork = new TextBox();
            txtSkills = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDel = new Button();
            btnAddCol = new Button();
            txtTextCol = new TextBox();
            txtNameCol = new TextBox();
            label7 = new Label();
            label8 = new Label();
            dgv = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            salary = new DataGridViewTextBoxColumn();
            work = new DataGridViewTextBoxColumn();
            skills = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Tai Le", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(552, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(217, 56);
            label1.TabIndex = 0;
            label1.Text = "To do list";
            label1.UseMnemonic = false;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(77, 165);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 29);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(77, 246);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(108, 29);
            label3.TabIndex = 2;
            label3.Text = "Address:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(77, 331);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 29);
            label4.TabIndex = 3;
            label4.Text = "Salary:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(77, 416);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 29);
            label5.TabIndex = 4;
            label5.Text = "Work:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(77, 516);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(77, 29);
            label6.TabIndex = 5;
            label6.Text = "Skills:";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(224, 224, 224);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(193, 165);
            txtName.Name = "txtName";
            txtName.Size = new Size(336, 30);
            txtName.TabIndex = 6;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(224, 224, 224);
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Location = new Point(193, 245);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(336, 30);
            txtAddress.TabIndex = 7;
            txtAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSalary
            // 
            txtSalary.BackColor = Color.FromArgb(224, 224, 224);
            txtSalary.BorderStyle = BorderStyle.FixedSingle;
            txtSalary.Location = new Point(193, 332);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(336, 30);
            txtSalary.TabIndex = 8;
            txtSalary.TextAlign = HorizontalAlignment.Center;
            // 
            // txtWork
            // 
            txtWork.BackColor = Color.FromArgb(224, 224, 224);
            txtWork.BorderStyle = BorderStyle.FixedSingle;
            txtWork.Location = new Point(193, 417);
            txtWork.Name = "txtWork";
            txtWork.Size = new Size(336, 30);
            txtWork.TabIndex = 9;
            txtWork.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSkills
            // 
            txtSkills.BackColor = Color.FromArgb(224, 224, 224);
            txtSkills.BorderStyle = BorderStyle.FixedSingle;
            txtSkills.Location = new Point(193, 515);
            txtSkills.Name = "txtSkills";
            txtSkills.Size = new Size(336, 30);
            txtSkills.TabIndex = 10;
            txtSkills.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(734, 154);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(239, 69);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.Yellow;
            btnEdit.Location = new Point(1026, 154);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(239, 69);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDel
            // 
            btnDel.Cursor = Cursors.Hand;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.ForeColor = Color.FromArgb(192, 0, 0);
            btnDel.Location = new Point(734, 291);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(239, 69);
            btnDel.TabIndex = 13;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnAddCol
            // 
            btnAddCol.Cursor = Cursors.Hand;
            btnAddCol.FlatStyle = FlatStyle.Flat;
            btnAddCol.ForeColor = Color.Lime;
            btnAddCol.Location = new Point(1026, 291);
            btnAddCol.Name = "btnAddCol";
            btnAddCol.Size = new Size(239, 69);
            btnAddCol.TabIndex = 14;
            btnAddCol.Text = "Add Column";
            btnAddCol.UseVisualStyleBackColor = true;
            btnAddCol.Click += btnAddCol_Click;
            // 
            // txtTextCol
            // 
            txtTextCol.BackColor = Color.FromArgb(224, 224, 224);
            txtTextCol.BorderStyle = BorderStyle.FixedSingle;
            txtTextCol.Location = new Point(1116, 445);
            txtTextCol.Name = "txtTextCol";
            txtTextCol.Size = new Size(151, 30);
            txtTextCol.TabIndex = 18;
            txtTextCol.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNameCol
            // 
            txtNameCol.BackColor = Color.FromArgb(224, 224, 224);
            txtNameCol.BorderStyle = BorderStyle.FixedSingle;
            txtNameCol.Location = new Point(1116, 392);
            txtNameCol.Name = "txtNameCol";
            txtNameCol.Size = new Size(151, 30);
            txtNameCol.TabIndex = 17;
            txtNameCol.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.SpringGreen;
            label7.Location = new Point(1026, 444);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(66, 29);
            label7.TabIndex = 16;
            label7.Text = "Text:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.SpringGreen;
            label8.Location = new Point(1026, 391);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(84, 29);
            label8.TabIndex = 15;
            label8.Text = "Name:";
            label8.Click += label8_Click;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = Color.Silver;
            dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { name, address, salary, work, skills });
            dgv.Dock = DockStyle.Bottom;
            dgv.Location = new Point(0, 603);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgv.RowTemplate.Height = 29;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(1389, 291);
            dgv.TabIndex = 19;
            dgv.CellContentClick += dataGridView1_CellContentClick;
            dgv.SelectionChanged += dgv_SelectionChanged;
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // address
            // 
            address.HeaderText = "Address";
            address.MinimumWidth = 6;
            address.Name = "address";
            address.ReadOnly = true;
            // 
            // salary
            // 
            salary.HeaderText = "Salary";
            salary.MinimumWidth = 6;
            salary.Name = "salary";
            salary.ReadOnly = true;
            // 
            // work
            // 
            work.HeaderText = "Work";
            work.MinimumWidth = 6;
            work.Name = "work";
            work.ReadOnly = true;
            // 
            // skills
            // 
            skills.HeaderText = "Skills";
            skills.MinimumWidth = 6;
            skills.Name = "skills";
            skills.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1389, 894);
            Controls.Add(dgv);
            Controls.Add(txtTextCol);
            Controls.Add(txtNameCol);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(btnAddCol);
            Controls.Add(btnDel);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtSkills);
            Controls.Add(txtWork);
            Controls.Add(txtSalary);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Aqua;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "To Do List";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtSalary;
        private TextBox txtWork;
        private TextBox txtSkills;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDel;
        private Button btnAddCol;
        private TextBox txtTextCol;
        private TextBox txtNameCol;
        private Label label7;
        private Label label8;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn salary;
        private DataGridViewTextBoxColumn work;
        private DataGridViewTextBoxColumn skills;
    }
}