namespace TaskManager1._0
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
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnClearSearch = new Button();
            txtTaskDescriptionUpdate = new TextBox();
            DTPDueDate = new DateTimePicker();
            txtUpdateTaskDescription = new Label();
            label2 = new Label();
            comboStatus = new ComboBox();
            ComboUpdatePriority = new ComboBox();
            label3 = new Label();
            DTPCompletionDate = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(458, 522);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1038, 350);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(580, 522);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(643, 411);
            dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 21);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 4;
            label1.Text = "Task Manager";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(36, 55);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(264, 23);
            txtSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(327, 54);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClearSearch
            // 
            btnClearSearch.Location = new Point(417, 55);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(101, 23);
            btnClearSearch.TabIndex = 7;
            btnClearSearch.Text = "Clear Search";
            btnClearSearch.UseVisualStyleBackColor = true;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // txtTaskDescriptionUpdate
            // 
            txtTaskDescriptionUpdate.Location = new Point(902, 139);
            txtTaskDescriptionUpdate.Name = "txtTaskDescriptionUpdate";
            txtTaskDescriptionUpdate.Size = new Size(211, 23);
            txtTaskDescriptionUpdate.TabIndex = 8;
            // 
            // DTPDueDate
            // 
            DTPDueDate.Location = new Point(902, 245);
            DTPDueDate.Name = "DTPDueDate";
            DTPDueDate.Size = new Size(211, 23);
            DTPDueDate.TabIndex = 10;
            // 
            // txtUpdateTaskDescription
            // 
            txtUpdateTaskDescription.AutoSize = true;
            txtUpdateTaskDescription.Location = new Point(785, 142);
            txtUpdateTaskDescription.Name = "txtUpdateTaskDescription";
            txtUpdateTaskDescription.Size = new Size(95, 15);
            txtUpdateTaskDescription.TabIndex = 11;
            txtUpdateTaskDescription.Text = "Task Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(835, 191);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 12;
            label2.Text = "Status: ";
            // 
            // comboStatus
            // 
            comboStatus.FormattingEnabled = true;
            comboStatus.Location = new Point(902, 191);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(211, 23);
            comboStatus.TabIndex = 13;
            // 
            // ComboUpdatePriority
            // 
            ComboUpdatePriority.FormattingEnabled = true;
            ComboUpdatePriority.Location = new Point(902, 94);
            ComboUpdatePriority.Name = "ComboUpdatePriority";
            ComboUpdatePriority.Size = new Size(211, 23);
            ComboUpdatePriority.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(802, 97);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 15;
            label3.Text = "Priority Level:";
            // 
            // DTPCompletionDate
            // 
            DTPCompletionDate.Location = new Point(902, 304);
            DTPCompletionDate.Name = "DTPCompletionDate";
            DTPCompletionDate.Size = new Size(211, 23);
            DTPCompletionDate.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(822, 251);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 17;
            label4.Text = "Due Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(785, 310);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 18;
            label5.Text = "Completion Date:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 596);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(DTPCompletionDate);
            Controls.Add(label3);
            Controls.Add(ComboUpdatePriority);
            Controls.Add(comboStatus);
            Controls.Add(label2);
            Controls.Add(txtUpdateTaskDescription);
            Controls.Add(DTPDueDate);
            Controls.Add(txtTaskDescriptionUpdate);
            Controls.Add(btnClearSearch);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnClearSearch;
        private TextBox txtTaskDescriptionUpdate;
        private TextBox textBox2;
        private DateTimePicker DTPDueDate;
        private Label txtUpdateTaskDescription;
        private Label label2;
        private ComboBox comboStatus;
        private ComboBox ComboUpdatePriority;
        private Label label3;
        private DateTimePicker DTPCompletionDate;
        private Label label4;
        private Label label5;
    }
}
