namespace CollegeAssignment
{
    partial class Student
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
            this.grpPersonal = new System.Windows.Forms.GroupBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cboCy = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSn = new System.Windows.Forms.TextBox();
            this.txtFn = new System.Windows.Forms.TextBox();
            this.lblGen = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSn = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblFn = new System.Windows.Forms.Label();
            this.grpCourse = new System.Windows.Forms.GroupBox();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.cboSoc = new System.Windows.Forms.ComboBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblSoc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvStu = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grpPersonal.SuspendLayout();
            this.grpCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStu)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPersonal
            // 
            this.grpPersonal.Controls.Add(this.lblAge);
            this.grpPersonal.Controls.Add(this.txtAge);
            this.grpPersonal.Controls.Add(this.rdoMale);
            this.grpPersonal.Controls.Add(this.rdoFemale);
            this.grpPersonal.Controls.Add(this.dtpDOB);
            this.grpPersonal.Controls.Add(this.cboCy);
            this.grpPersonal.Controls.Add(this.label10);
            this.grpPersonal.Controls.Add(this.txtEmail);
            this.grpPersonal.Controls.Add(this.txtPhone);
            this.grpPersonal.Controls.Add(this.txtAddress);
            this.grpPersonal.Controls.Add(this.txtSn);
            this.grpPersonal.Controls.Add(this.txtFn);
            this.grpPersonal.Controls.Add(this.lblGen);
            this.grpPersonal.Controls.Add(this.lblEmail);
            this.grpPersonal.Controls.Add(this.lblCounty);
            this.grpPersonal.Controls.Add(this.lblPhone);
            this.grpPersonal.Controls.Add(this.lblAddress);
            this.grpPersonal.Controls.Add(this.lblSn);
            this.grpPersonal.Controls.Add(this.lblDob);
            this.grpPersonal.Controls.Add(this.lblFn);
            this.grpPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPersonal.Location = new System.Drawing.Point(13, 13);
            this.grpPersonal.Name = "grpPersonal";
            this.grpPersonal.Size = new System.Drawing.Size(1073, 280);
            this.grpPersonal.TabIndex = 0;
            this.grpPersonal.TabStop = false;
            this.grpPersonal.Text = "Add Student";
            this.grpPersonal.Enter += new System.EventHandler(this.grpPersonal_Enter);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(390, 44);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(66, 29);
            this.lblAge.TabIndex = 24;
            this.lblAge.Text = "Age*";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(394, 75);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(316, 34);
            this.txtAge.TabIndex = 23;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Checked = true;
            this.rdoMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMale.Location = new System.Drawing.Point(740, 79);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(87, 33);
            this.rdoMale.TabIndex = 22;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFemale.Location = new System.Drawing.Point(940, 79);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(116, 33);
            this.rdoFemale.TabIndex = 18;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Location = new System.Drawing.Point(47, 232);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(316, 34);
            this.dtpDOB.TabIndex = 16;
            this.dtpDOB.Value = new System.DateTime(2023, 11, 22, 20, 55, 35, 0);
            // 
            // cboCy
            // 
            this.cboCy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCy.FormattingEnabled = true;
            this.cboCy.Location = new System.Drawing.Point(394, 232);
            this.cboCy.Name = "cboCy";
            this.cboCy.Size = new System.Drawing.Size(316, 37);
            this.cboCy.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(268, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 29);
            this.label10.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(740, 154);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(316, 34);
            this.txtEmail.TabIndex = 12;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(740, 232);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(316, 34);
            this.txtPhone.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(394, 154);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(316, 34);
            this.txtAddress.TabIndex = 10;
            // 
            // txtSn
            // 
            this.txtSn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSn.Location = new System.Drawing.Point(47, 154);
            this.txtSn.Name = "txtSn";
            this.txtSn.Size = new System.Drawing.Size(316, 34);
            this.txtSn.TabIndex = 9;
            // 
            // txtFn
            // 
            this.txtFn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFn.Location = new System.Drawing.Point(47, 78);
            this.txtFn.Name = "txtFn";
            this.txtFn.Size = new System.Drawing.Size(316, 34);
            this.txtFn.TabIndex = 8;
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGen.Location = new System.Drawing.Point(735, 44);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(104, 29);
            this.lblGen.TabIndex = 7;
            this.lblGen.Text = "Gender*";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(735, 122);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(84, 29);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email*";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(389, 200);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(97, 29);
            this.lblCounty.TabIndex = 5;
            this.lblCounty.Text = "County*";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(735, 200);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(186, 29);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone Number*";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(389, 122);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(112, 29);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address*";
            // 
            // lblSn
            // 
            this.lblSn.AutoSize = true;
            this.lblSn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSn.Location = new System.Drawing.Point(42, 122);
            this.lblSn.Name = "lblSn";
            this.lblSn.Size = new System.Drawing.Size(120, 29);
            this.lblSn.TabIndex = 2;
            this.lblSn.Text = "Surname*";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.Location = new System.Drawing.Point(42, 200);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(75, 29);
            this.lblDob.TabIndex = 1;
            this.lblDob.Text = "DOB*";
            // 
            // lblFn
            // 
            this.lblFn.AutoSize = true;
            this.lblFn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFn.Location = new System.Drawing.Point(42, 44);
            this.lblFn.Name = "lblFn";
            this.lblFn.Size = new System.Drawing.Size(130, 29);
            this.lblFn.TabIndex = 0;
            this.lblFn.Text = "Firstname*";
            // 
            // grpCourse
            // 
            this.grpCourse.Controls.Add(this.cboCourse);
            this.grpCourse.Controls.Add(this.cboSoc);
            this.grpCourse.Controls.Add(this.lblCourse);
            this.grpCourse.Controls.Add(this.lblSoc);
            this.grpCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCourse.Location = new System.Drawing.Point(13, 299);
            this.grpCourse.Name = "grpCourse";
            this.grpCourse.Size = new System.Drawing.Size(1089, 125);
            this.grpCourse.TabIndex = 1;
            this.grpCourse.TabStop = false;
            this.grpCourse.Text = "Course Information";
            // 
            // cboCourse
            // 
            this.cboCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Location = new System.Drawing.Point(40, 77);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(324, 37);
            this.cboCourse.TabIndex = 17;
            // 
            // cboSoc
            // 
            this.cboSoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSoc.FormattingEnabled = true;
            this.cboSoc.Location = new System.Drawing.Point(394, 77);
            this.cboSoc.Name = "cboSoc";
            this.cboSoc.Size = new System.Drawing.Size(316, 37);
            this.cboSoc.TabIndex = 16;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(35, 45);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(91, 29);
            this.lblCourse.TabIndex = 2;
            this.lblCourse.Text = "Course";
            // 
            // lblSoc
            // 
            this.lblSoc.AutoSize = true;
            this.lblSoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoc.Location = new System.Drawing.Point(390, 45);
            this.lblSoc.Name = "lblSoc";
            this.lblSoc.Size = new System.Drawing.Size(92, 29);
            this.lblSoc.TabIndex = 1;
            this.lblSoc.Text = "Society";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 753);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 46);
            this.button1.TabIndex = 20;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(656, 753);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 46);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvStu
            // 
            this.dgvStu.AllowUserToAddRows = false;
            this.dgvStu.AllowUserToDeleteRows = false;
            this.dgvStu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStu.Location = new System.Drawing.Point(13, 430);
            this.dgvStu.Name = "dgvStu";
            this.dgvStu.ReadOnly = true;
            this.dgvStu.RowHeadersWidth = 51;
            this.dgvStu.RowTemplate.Height = 24;
            this.dgvStu.Size = new System.Drawing.Size(1089, 317);
            this.dgvStu.TabIndex = 21;
            this.dgvStu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStu_CellContentClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(813, 753);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 46);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(978, 753);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 46);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(177, 753);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(124, 46);
            this.btnRefresh.TabIndex = 26;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 807);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvStu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpCourse);
            this.Controls.Add(this.grpPersonal);
            this.Controls.Add(this.btnSave);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.grpPersonal.ResumeLayout(false);
            this.grpPersonal.PerformLayout();
            this.grpCourse.ResumeLayout(false);
            this.grpCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersonal;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cboCy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSn;
        private System.Windows.Forms.TextBox txtFn;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSn;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblFn;
        private System.Windows.Forms.GroupBox grpCourse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.ComboBox cboSoc;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblSoc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvStu;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
    }
}