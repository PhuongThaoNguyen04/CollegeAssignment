namespace CollegeAssignment
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnLecturer = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "College Management";
            // 
            // btnStudent
            // 
            this.btnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.Location = new System.Drawing.Point(150, 143);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(206, 78);
            this.btnStudent.TabIndex = 2;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnLecturer
            // 
            this.btnLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLecturer.Location = new System.Drawing.Point(150, 259);
            this.btnLecturer.Name = "btnLecturer";
            this.btnLecturer.Size = new System.Drawing.Size(206, 78);
            this.btnLecturer.TabIndex = 3;
            this.btnLecturer.Text = "Lecturer";
            this.btnLecturer.UseVisualStyleBackColor = true;
            this.btnLecturer.Click += new System.EventHandler(this.btnLecturer_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(150, 379);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(206, 78);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View list";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 562);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnLecturer);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnLecturer;
        private System.Windows.Forms.Button btnView;
    }
}

