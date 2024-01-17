using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CollegeAssignment
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        AddPerson ap = new AddPerson();

        private void AllClear()
        {
            txtFn.Clear();
            txtSn.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAge.Clear();
        }

        private void ShowStudentData()
        {
            dgvStu.DataSource = ap.ShowStu();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            cboCy.DataSource = Enum.GetValues(typeof(Counties));
            cboCourse.DataSource = Enum.GetValues(typeof(Course));
            cboSoc.DataSource = Enum.GetValues(typeof(Society));
            ShowStudentData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fn = txtFn.Text;
            string sn = txtSn.Text;
            string dob = dtpDOB.Text;
            int age = 0;
            string add = txtAddress.Text;
            string cy = cboCy.SelectedItem.ToString();
            string ge = "Male";
            if (rdoFemale.Checked)
            {
                ge = "Female";
            }
            string mail = txtEmail.Text;
            string phone = txtPhone.Text;
            string cse = cboCourse.SelectedItem.ToString();
            string soc = cboSoc.SelectedItem.ToString();
            
            bool IsAllValid = true;
            String ErrorMessage = string.Empty;
            if (IsAllValid)
            {
                ErrorMessage = FnValidate(txtFn.Text);

                if (ErrorMessage != "")
                {
                    IsAllValid = false;

                }
                else
                {
                    IsAllValid = true;
                }
            }

            if (IsAllValid)
            {
                ErrorMessage = SnValidate(txtSn.Text);

                if (ErrorMessage != "")
                {
                    IsAllValid = false;

                }
                else
                {
                    IsAllValid = true;
                }
            }
            if (IsAllValid)
            {
                ErrorMessage = AgeValidate(txtAge.Text);
                if (ErrorMessage != "")
                {
                    IsAllValid = false;
                }
                else
                {
                    age = int.Parse(txtAge.Text);
                    IsAllValid = true;
                }
            }
            if (IsAllValid)
            {
                ErrorMessage = EmailValidate(txtEmail.Text);

                if (ErrorMessage != "")
                {
                    IsAllValid = false;
                }
                else
                {
                    IsAllValid = true;
                    if (CountDuplicateEmail(txtEmail.Text) > 0)
                    {
                        IsAllValid = false;
                        ErrorMessage = ("This Email is already used.");
                    }
                    else
                    {
                        IsAllValid = true;
                    }
                }
            }

            if (IsAllValid)
            {
                ErrorMessage = MobileValidate(txtPhone.Text);

                if (ErrorMessage != "")
                {
                    IsAllValid = false;
                }
                else
                {
                    IsAllValid = true;
                    if (CountDuplicateMobile(txtPhone.Text) > 0)
                    {
                        IsAllValid = false;
                        ErrorMessage = ("This Mobile Number is already used");
                    }
                    else
                    {
                        IsAllValid = true;
                    }
                }
            }

            if (IsAllValid)
            {
                if (rdoMale.Checked != true && rdoFemale.Checked != true)
                {
                    IsAllValid = false;
                    ErrorMessage = ("Select Your Gender.");
                }
                else
                {
                    IsAllValid = true;
                }
            }

            if (IsAllValid)
            {
                if (dtpDOB.Value > DateTime.Today)
                {
                    IsAllValid = false;
                    dtpDOB.Value = DateTime.Today;
                    ErrorMessage = ("you cannot use future date and time.");
                }
                else
                {
                    IsAllValid = true;
                }
            }

            if (ErrorMessage != "")
            {
                MessageBox.Show(ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ap.AddStudent(fn, sn, dob, age, add, cy, ge, mail, phone, cse, soc);
            MessageBox.Show("Data Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            //tidy up
            AllClear();
            ShowStudentData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = dgvStu.SelectedCells[0].RowIndex;
            int id = (int)dgvStu.Rows[index].Cells[0].Value;
            string fn = txtFn.Text;
            string sn = txtSn.Text;
          
            if (id > 0)
            {
                string dob = dtpDOB.Text;
                int age = int.Parse(txtAge.Text);
                string add = txtAddress.Text;
                string cy = cboCy.SelectedItem?.ToString();  // Add null check
                string ge = rdoMale.Checked ? "Male" : "Female";  // Simplify gender check
                string mail = txtEmail.Text;
                string phone = txtPhone.Text;
                string cse = cboCourse.SelectedItem?.ToString();  // Add null check
                string soc = cboSoc.SelectedItem?.ToString();  // Add null check

                bool IsAllValid = true;
                String ErrorMessage = string.Empty;
                if (IsAllValid)
                {
                    ErrorMessage = FnValidate(txtFn.Text);

                    if (ErrorMessage != "")
                    {
                        IsAllValid = false;

                    }
                    else
                    {
                        IsAllValid = true;
                    }
                }

                if (IsAllValid)
                {
                    ErrorMessage = SnValidate(txtSn.Text);

                    if (ErrorMessage != "")
                    {
                        IsAllValid = false;

                    }
                    else
                    {
                        IsAllValid = true;
                    }
                }
                if (IsAllValid)
                {
                    ErrorMessage = AgeValidate(txtAge.Text);
                    if (ErrorMessage != "")
                    {
                        IsAllValid = false;
                    }
                    else
                    {
                        age = int.Parse(txtAge.Text);
                        IsAllValid = true;
                    }
                }
                if (IsAllValid)
                {
                    ErrorMessage = EmailValidate(txtEmail.Text);

                    if (ErrorMessage != "")
                    {
                        IsAllValid = false;
                    }
                    else
                    {
                        IsAllValid = true;
                        if (CountDuplicateEmail(txtEmail.Text) > 0)
                        {
                            IsAllValid = false;
                            ErrorMessage = ("This Email is already used.");
                        }
                        else
                        {
                            IsAllValid = true;
                        }
                    }
                }

                if (IsAllValid)
                {
                    ErrorMessage = MobileValidate(txtPhone.Text);

                    if (ErrorMessage != "")
                    {
                        IsAllValid = false;
                    }
                    else
                    {
                        IsAllValid = true;
                        if (CountDuplicateMobile(txtPhone.Text) > 0)
                        {
                            IsAllValid = false;
                            ErrorMessage = ("This Mobile Number is already used");
                        }
                        else
                        {
                            IsAllValid = true;
                        }
                    }
                }

                if (IsAllValid)
                {
                    if (rdoMale.Checked != true && rdoFemale.Checked != true)
                    {
                        IsAllValid = false;
                        ErrorMessage = ("Select Your Gender.");
                    }
                    else
                    {
                        IsAllValid = true;
                    }
                }

                if (IsAllValid)
                {
                    if (dtpDOB.Value > DateTime.Today)
                    {
                        IsAllValid = false;
                        dtpDOB.Value = DateTime.Today;
                        ErrorMessage = ("you cannot use future date and time.");
                    }
                    else
                    {
                        IsAllValid = true;
                    }
                }

                if (ErrorMessage != "")
                {
                    MessageBox.Show(ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Use the obtained ID to update the student data
                ap.UpdateStudent(id, fn, sn, dob, add, cy, ge, mail, phone, cse, soc);

                MessageBox.Show("Data Updated", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tidy up
                AllClear();
             
            }
            else
            {
                MessageBox.Show("Student not found. Please check the provided first name and last name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {

            int index = dgvStu.SelectedCells[0].RowIndex;
            int id = (int)dgvStu.Rows[index].Cells[0].Value;

            ap.DeleteStudent(id);
            MessageBox.Show("Data Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgvStu.Rows.RemoveAt(index);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvStu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewCell firstCell = dgvStu.Rows[e.RowIndex].Cells[0];
            DataGridViewCell secondCell = dgvStu.Rows[e.RowIndex].Cells[1];
            DataGridViewCell thirdCell = dgvStu.Rows[e.RowIndex].Cells[2];
            DataGridViewCell forthCell = dgvStu.Rows[e.RowIndex].Cells[3];
            DataGridViewCell fifthCell = dgvStu.Rows[e.RowIndex].Cells[4];
            DataGridViewCell sixthCell = dgvStu.Rows[e.RowIndex].Cells[5];
            DataGridViewCell seventhCell = dgvStu.Rows[e.RowIndex].Cells[6];
            DataGridViewCell eighthCell = dgvStu.Rows[e.RowIndex].Cells[7];
            DataGridViewCell ninthCell = dgvStu.Rows[e.RowIndex].Cells[8];
            DataGridViewCell tenthCell = dgvStu.Rows[e.RowIndex].Cells[9];
            DataGridViewCell eleventhCell = dgvStu.Rows[e.RowIndex].Cells[10];
            DataGridViewCell twelvethCell = dgvStu.Rows[e.RowIndex].Cells[11];


            int cellValue = (int)firstCell.Value;
            dgvStu.Rows[e.RowIndex].Selected = true;


            txtFn.Text = (string)secondCell.Value;
            txtSn.Text = (string)thirdCell.Value;
            dtpDOB.Text = (string)forthCell.Value;
            txtAge.Text = ((int)fifthCell.Value).ToString();
            txtAddress.Text = (string)sixthCell.Value;

            string countyValue = (string)seventhCell.Value;
            int countyIndex = cboCy.FindString(countyValue);
            cboCy.SelectedIndex = countyIndex;

            txtEmail.Text = (string)ninthCell.Value;
            txtPhone.Text = (string)tenthCell.Value;

            string courseValue = (string)eleventhCell.Value;
            int courseIndex = cboCourse.FindString(courseValue);
            cboCourse.SelectedItem = courseIndex;

            string socValue = (string)twelvethCell.Value;
            int socIndex = cboCy.FindString(socValue);
            cboSoc.SelectedItem = socIndex;
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            dgvStu.DataSource = null;
            dgvStu.Refresh();
            ShowStudentData();
        }

        public string FnValidate(string fn)
        {
            fn = fn.Trim();
            string NameErrorMessage = string.Empty;
            if (fn == "")
            {
                NameErrorMessage = "You must enter a firstname";
            }
            else if (fn.Length < 3)
            {
                NameErrorMessage = "Your firstname should be minimum 3 characters long";
            }
            else
            {
                NameErrorMessage = string.Empty;
            }
            return NameErrorMessage;
        }
        public string SnValidate(string sn)
        {
            sn = sn.Trim();
            string NameErrorMessage = string.Empty;
            if (sn == "")
            {
                NameErrorMessage = "You must enter a surname";
            }
            else if (sn.Length < 3)
            {
                NameErrorMessage = "Your surname should be minimum 3 characters long";
            }
            else
            {
                NameErrorMessage = string.Empty;
            }
            return NameErrorMessage;
        }
        public int CountDuplicateEmail(string mail)
        {
            int count = 0;
            foreach (DataGridViewRow row in dgvStu.Rows)
            {
                var gridEmail = row.Cells[8].Value.ToString();
                if (gridEmail == mail)
                {
                    count++;
                }
            }
            return count;
        }
        public string EmailValidate(string StudenEmail)
        {
            string EmailErrorMessage = string.Empty;
            StudenEmail = StudenEmail.Trim();
            string email = txtEmail.Text;

            System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (!expr.IsMatch(email))
            {
                EmailErrorMessage = "Invalid Email";
            }
            else if (StudenEmail.Length > 50)
            {
                EmailErrorMessage = "Your Email is too long";
            }
            else
            {
                EmailErrorMessage = string.Empty;
            }
            return EmailErrorMessage;
        }

        public string AgeValidate(string StudentAge)
        {
            int StudentAgeInt;
            string AgeErrorMessage = string.Empty;
            string age = StudentAge.Trim();

            if (StudentAge == "")
            {
                AgeErrorMessage = "Age Required";
            }
            else
            {
                try
                {
                    StudentAgeInt = Int32.Parse(StudentAge);
                    if (StudentAgeInt < 10)
                    {
                        AgeErrorMessage = "Age must be minimum of 10 years";
                    }
                    else if (StudentAgeInt > 40)
                    {
                        AgeErrorMessage = "Age should be between 10 to 40 years";
                    }
                    else
                    {
                        AgeErrorMessage = string.Empty;
                    }
                }
                catch (FormatException)
                {
                    AgeErrorMessage = "Enter number for age";
                }
            }
            return AgeErrorMessage;
        }
        public int CountDuplicateMobile(string mobile)
        {
            int count = 0;
            foreach (DataGridViewRow row in dgvStu.Rows)
            {
                var gridMobile = row.Cells[9].Value.ToString();
                if (gridMobile == mobile)
                {
                    count++;
                }
            }
            return count;
        }

        public string MobileValidate(string StudenMobile)
        {
            string MobileErrorMessage = string.Empty;
            StudenMobile = StudenMobile.Trim();
            if (StudenMobile == "")
            {
                MobileErrorMessage = "Mobile Number required";
            }
            else if (StudenMobile.Length > 20)
            {
                MobileErrorMessage = "The mobile number needs to be between 11-20 digits";
            }
            else if (StudenMobile.Length < 11)
            {
                MobileErrorMessage = "The mobile number needs to be a minimum of 11 digits";
            }
            else
            {
                MobileErrorMessage = string.Empty;
            }
            return MobileErrorMessage;
        }

        private void grpPersonal_Enter(object sender, EventArgs e)
        {

        }
    }
}
