namespace CollegeAssignment
{
    partial class View
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnStu = new System.Windows.Forms.Button();
            this.btnLec = new System.Windows.Forms.Button();
            this.cboGe = new System.Windows.Forms.ComboBox();
            this.lblGe = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.cboAR = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGS = new System.Windows.Forms.Button();
            this.btnGL = new System.Windows.Forms.Button();
            this.btnAL = new System.Windows.Forms.Button();
            this.btnAS = new System.Windows.Forms.Button();
            this.btnSD = new System.Windows.Forms.Button();
            this.btnLD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(13, 304);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1199, 338);
            this.dgv.TabIndex = 0;
            // 
            // btnStu
            // 
            this.btnStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStu.Location = new System.Drawing.Point(51, 223);
            this.btnStu.Name = "btnStu";
            this.btnStu.Size = new System.Drawing.Size(187, 53);
            this.btnStu.TabIndex = 1;
            this.btnStu.Text = "All Student";
            this.btnStu.UseVisualStyleBackColor = true;
            this.btnStu.Click += new System.EventHandler(this.btnStu_Click);
            // 
            // btnLec
            // 
            this.btnLec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLec.Location = new System.Drawing.Point(290, 223);
            this.btnLec.Name = "btnLec";
            this.btnLec.Size = new System.Drawing.Size(187, 53);
            this.btnLec.TabIndex = 2;
            this.btnLec.Text = "All Lecturer";
            this.btnLec.UseVisualStyleBackColor = true;
            this.btnLec.Click += new System.EventHandler(this.btnLec_Click);
            // 
            // cboGe
            // 
            this.cboGe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGe.FormattingEnabled = true;
            this.cboGe.Location = new System.Drawing.Point(170, 46);
            this.cboGe.Name = "cboGe";
            this.cboGe.Size = new System.Drawing.Size(259, 37);
            this.cboGe.TabIndex = 3;
            // 
            // lblGe
            // 
            this.lblGe.AutoSize = true;
            this.lblGe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGe.Location = new System.Drawing.Point(31, 49);
            this.lblGe.Name = "lblGe";
            this.lblGe.Size = new System.Drawing.Size(94, 29);
            this.lblGe.TabIndex = 4;
            this.lblGe.Text = "Gender";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(636, 49);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(133, 29);
            this.lblAge.TabIndex = 5;
            this.lblAge.Text = "Age Range";
            // 
            // cboAR
            // 
            this.cboAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAR.FormattingEnabled = true;
            this.cboAR.Location = new System.Drawing.Point(823, 46);
            this.cboAR.Name = "cboAR";
            this.cboAR.Size = new System.Drawing.Size(259, 37);
            this.cboAR.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(579, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 10;
            // 
            // btnGS
            // 
            this.btnGS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGS.Location = new System.Drawing.Point(51, 118);
            this.btnGS.Name = "btnGS";
            this.btnGS.Size = new System.Drawing.Size(187, 53);
            this.btnGS.TabIndex = 11;
            this.btnGS.Text = "Student";
            this.btnGS.UseVisualStyleBackColor = true;
            this.btnGS.Click += new System.EventHandler(this.btnGS_Click);
            // 
            // btnGL
            // 
            this.btnGL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGL.Location = new System.Drawing.Point(290, 118);
            this.btnGL.Name = "btnGL";
            this.btnGL.Size = new System.Drawing.Size(187, 53);
            this.btnGL.TabIndex = 12;
            this.btnGL.Text = "Lecturer";
            this.btnGL.UseVisualStyleBackColor = true;
            this.btnGL.Click += new System.EventHandler(this.btnGL_Click);
            // 
            // btnAL
            // 
            this.btnAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAL.Location = new System.Drawing.Point(895, 118);
            this.btnAL.Name = "btnAL";
            this.btnAL.Size = new System.Drawing.Size(187, 53);
            this.btnAL.TabIndex = 13;
            this.btnAL.Text = "Lecturer";
            this.btnAL.UseVisualStyleBackColor = true;
            this.btnAL.Click += new System.EventHandler(this.btnAL_Click);
            // 
            // btnAS
            // 
            this.btnAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAS.Location = new System.Drawing.Point(641, 118);
            this.btnAS.Name = "btnAS";
            this.btnAS.Size = new System.Drawing.Size(187, 53);
            this.btnAS.TabIndex = 14;
            this.btnAS.Text = "Student";
            this.btnAS.UseVisualStyleBackColor = true;
            this.btnAS.Click += new System.EventHandler(this.btnAS_Click);
            // 
            // btnSD
            // 
            this.btnSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSD.Location = new System.Drawing.Point(641, 212);
            this.btnSD.Name = "btnSD";
            this.btnSD.Size = new System.Drawing.Size(187, 75);
            this.btnSD.TabIndex = 15;
            this.btnSD.Text = "Student from Dublin";
            this.btnSD.UseVisualStyleBackColor = true;
            this.btnSD.Click += new System.EventHandler(this.btnSD_Click);
            // 
            // btnLD
            // 
            this.btnLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLD.Location = new System.Drawing.Point(895, 212);
            this.btnLD.Name = "btnLD";
            this.btnLD.Size = new System.Drawing.Size(187, 75);
            this.btnLD.TabIndex = 16;
            this.btnLD.Text = "Lecturer from Dublin";
            this.btnLD.UseVisualStyleBackColor = true;
            this.btnLD.Click += new System.EventHandler(this.btnLD_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 654);
            this.Controls.Add(this.btnLD);
            this.Controls.Add(this.btnSD);
            this.Controls.Add(this.btnAS);
            this.Controls.Add(this.btnAL);
            this.Controls.Add(this.btnGL);
            this.Controls.Add(this.btnGS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboAR);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblGe);
            this.Controls.Add(this.cboGe);
            this.Controls.Add(this.btnLec);
            this.Controls.Add(this.btnStu);
            this.Controls.Add(this.dgv);
            this.Name = "View";
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnStu;
        private System.Windows.Forms.Button btnLec;
        private System.Windows.Forms.ComboBox cboGe;
        private System.Windows.Forms.Label lblGe;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.ComboBox cboAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGS;
        private System.Windows.Forms.Button btnGL;
        private System.Windows.Forms.Button btnAL;
        private System.Windows.Forms.Button btnAS;
        private System.Windows.Forms.Button btnSD;
        private System.Windows.Forms.Button btnLD;
    }
}