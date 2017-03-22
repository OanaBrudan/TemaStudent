namespace database1
{
    partial class Form1
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
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.dtpStudentBirthDate = new System.Windows.Forms.DateTimePicker();
            this.labelIDC = new System.Windows.Forms.Label();
            this.labelNameC = new System.Windows.Forms.Label();
            this.labelTeacher = new System.Windows.Forms.Label();
            this.labelSY = new System.Windows.Forms.Label();
            this.textIdC = new System.Windows.Forms.TextBox();
            this.textTeacher = new System.Windows.Forms.TextBox();
            this.textSY = new System.Windows.Forms.TextBox();
            this.textNameC = new System.Windows.Forms.TextBox();
            this.gridCourse = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnSaveStudent = new System.Windows.Forms.Button();
            this.gridStudents = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(92, 94);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(100, 20);
            this.txtStudentName.TabIndex = 0;
            this.txtStudentName.Click += new System.EventHandler(this.lbl);
            this.txtStudentName.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
            // 
            // txtStudentAddress
            // 
            this.txtStudentAddress.Location = new System.Drawing.Point(92, 164);
            this.txtStudentAddress.Name = "txtStudentAddress";
            this.txtStudentAddress.Size = new System.Drawing.Size(100, 20);
            this.txtStudentAddress.TabIndex = 2;
            this.txtStudentAddress.TextChanged += new System.EventHandler(this.txtStudentAddress_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.lblStudentName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Birthday";
            this.label2.Click += new System.EventHandler(this.lblStudentBd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            this.label3.Click += new System.EventHandler(this.lblStudentAddress_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(92, 56);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(100, 20);
            this.txtStudentID.TabIndex = 6;
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged);
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(12, 59);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(58, 13);
            this.lblStudentID.TabIndex = 7;
            this.lblStudentID.Text = "ID Student";
            this.lblStudentID.Click += new System.EventHandler(this.lblStudentID_Click);
            // 
            // dtpStudentBirthDate
            // 
            this.dtpStudentBirthDate.Location = new System.Drawing.Point(92, 132);
            this.dtpStudentBirthDate.Name = "dtpStudentBirthDate";
            this.dtpStudentBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStudentBirthDate.TabIndex = 8;
            this.dtpStudentBirthDate.ValueChanged += new System.EventHandler(this.dtpStudentBirthDate_ValueChanged);
            // 
            // labelIDC
            // 
            this.labelIDC.AutoSize = true;
            this.labelIDC.Location = new System.Drawing.Point(16, 330);
            this.labelIDC.Name = "labelIDC";
            this.labelIDC.Size = new System.Drawing.Size(54, 13);
            this.labelIDC.TabIndex = 11;
            this.labelIDC.Text = "ID Course";
            this.labelIDC.Click += new System.EventHandler(this.labelIDC_Click);
            // 
            // labelNameC
            // 
            this.labelNameC.AutoSize = true;
            this.labelNameC.Location = new System.Drawing.Point(35, 366);
            this.labelNameC.Name = "labelNameC";
            this.labelNameC.Size = new System.Drawing.Size(35, 13);
            this.labelNameC.TabIndex = 12;
            this.labelNameC.Text = "Name";
            this.labelNameC.Click += new System.EventHandler(this.labelNameC_Click);
            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Location = new System.Drawing.Point(23, 408);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(47, 13);
            this.labelTeacher.TabIndex = 13;
            this.labelTeacher.Text = "Teacher";
            this.labelTeacher.Click += new System.EventHandler(this.labelTeacher_Click);
            // 
            // labelSY
            // 
            this.labelSY.AutoSize = true;
            this.labelSY.Location = new System.Drawing.Point(11, 445);
            this.labelSY.Name = "labelSY";
            this.labelSY.Size = new System.Drawing.Size(59, 13);
            this.labelSY.TabIndex = 14;
            this.labelSY.Text = "Study Year";
            this.labelSY.Click += new System.EventHandler(this.labelSY_Click);
            // 
            // textIdC
            // 
            this.textIdC.Location = new System.Drawing.Point(92, 323);
            this.textIdC.Name = "textIdC";
            this.textIdC.Size = new System.Drawing.Size(100, 20);
            this.textIdC.TabIndex = 15;
            this.textIdC.TextChanged += new System.EventHandler(this.textIdC_TextChanged);
            // 
            // textTeacher
            // 
            this.textTeacher.Location = new System.Drawing.Point(92, 401);
            this.textTeacher.Name = "textTeacher";
            this.textTeacher.Size = new System.Drawing.Size(100, 20);
            this.textTeacher.TabIndex = 16;
            this.textTeacher.TextChanged += new System.EventHandler(this.textTeacher_TextChanged);
            // 
            // textSY
            // 
            this.textSY.Location = new System.Drawing.Point(92, 438);
            this.textSY.Name = "textSY";
            this.textSY.Size = new System.Drawing.Size(100, 20);
            this.textSY.TabIndex = 17;
            this.textSY.TextChanged += new System.EventHandler(this.textSY_TextChanged);
            // 
            // textNameC
            // 
            this.textNameC.Location = new System.Drawing.Point(92, 359);
            this.textNameC.Name = "textNameC";
            this.textNameC.Size = new System.Drawing.Size(100, 20);
            this.textNameC.TabIndex = 18;
            this.textNameC.TextChanged += new System.EventHandler(this.textNameC_TextChanged);
            // 
            // gridCourse
            // 
            this.gridCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.gridCourse.Location = new System.Drawing.Point(433, 308);
            this.gridCourse.Name = "gridCourse";
            this.gridCourse.Size = new System.Drawing.Size(443, 150);
            this.gridCourse.TabIndex = 20;
            this.gridCourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCourse_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Teacher";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Study Year";
            this.Column4.Name = "Column4";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(207, 53);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 21;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(515, 199);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(75, 23);
            this.btnRetrieve.TabIndex = 22;
            this.btnRetrieve.Text = "Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.Location = new System.Drawing.Point(207, 91);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(75, 23);
            this.btnEditStudent.TabIndex = 23;
            this.btnEditStudent.Text = "Edit Student";
            this.btnEditStudent.UseMnemonic = false;
            this.btnEditStudent.UseVisualStyleBackColor = true;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(319, 54);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(87, 23);
            this.btnDeleteStudent.TabIndex = 24;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnSaveStudent
            // 
            this.btnSaveStudent.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnSaveStudent.Location = new System.Drawing.Point(515, 256);
            this.btnSaveStudent.Name = "btnSaveStudent";
            this.btnSaveStudent.Size = new System.Drawing.Size(75, 23);
            this.btnSaveStudent.TabIndex = 25;
            this.btnSaveStudent.Text = "Save";
            this.btnSaveStudent.UseVisualStyleBackColor = true;
            this.btnSaveStudent.Click += new System.EventHandler(this.btnSaveStudent_Click);
            // 
            // gridStudents
            // 
            this.gridStudents.AllowUserToAddRows = false;
            this.gridStudents.AllowUserToDeleteRows = false;
            this.gridStudents.AllowUserToResizeColumns = false;
            this.gridStudents.AllowUserToResizeRows = false;
            this.gridStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.BirthDate,
            this.Address});
            this.gridStudents.Location = new System.Drawing.Point(433, 18);
            this.gridStudents.MultiSelect = false;
            this.gridStudents.Name = "gridStudents";
            this.gridStudents.RowHeadersVisible = false;
            this.gridStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStudents.Size = new System.Drawing.Size(443, 166);
            this.gridStudents.TabIndex = 4;
            this.gridStudents.SelectionChanged += new System.EventHandler(this.gridStudents_SelectionChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // BirthDate
            // 
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.HeaderText = "Birth date";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 513);
            this.Controls.Add(this.gridStudents);
            this.Controls.Add(this.btnSaveStudent);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnEditStudent);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.gridCourse);
            this.Controls.Add(this.textNameC);
            this.Controls.Add(this.textSY);
            this.Controls.Add(this.textTeacher);
            this.Controls.Add(this.textIdC);
            this.Controls.Add(this.labelSY);
            this.Controls.Add(this.labelTeacher);
            this.Controls.Add(this.labelNameC);
            this.Controls.Add(this.labelIDC);
            this.Controls.Add(this.dtpStudentBirthDate);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudentAddress);
            this.Controls.Add(this.txtStudentName);
           // this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.DateTimePicker dtpStudentBirthDate;
        private System.Windows.Forms.Label labelIDC;
        private System.Windows.Forms.Label labelNameC;
        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.Label labelSY;
        private System.Windows.Forms.TextBox textIdC;
        private System.Windows.Forms.TextBox textTeacher;
        private System.Windows.Forms.TextBox textSY;
        private System.Windows.Forms.TextBox textNameC;
        private System.Windows.Forms.DataGridView gridCourse;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnSaveStudent;
        private System.Windows.Forms.DataGridView gridStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

