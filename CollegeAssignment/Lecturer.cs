using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeAssignment
{
    public partial class Lecturer : Form
    {
        public Lecturer()
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
            txtSalary.Clear();
        }

        private void ShowLecturerData()
        {
            dgvLec.DataSource = ap.ShowLec();
        }
        private void Lecturer_Load(object sender, EventArgs e)
        {
            cboCy.DataSource = Enum.GetValues(typeof(Counties));
            ShowLecturerData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fn = txtFn.Text;
            string sn = txtSn.Text;
            string dob = dtpDOB.Text;
            string add = txtAddress.Text;
            string cy = cboCy.SelectedItem.ToString();
            string ge = "Male";
            if (rdoFemale.Checked)
            {
                ge = "Female";
            }
            string mail = txtEmail.Text;
            string phone = txtPhone.Text;
            decimal salary = decimal.Parse(txtSalary.Text);

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
                ErrorMessage = FnValidate(txtSn.Text);

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
            if (IsAllValid)
            {
                ErrorMessage = SalaryValidate(txtSalary.Text);
                if (ErrorMessage != "")
                {
                    IsAllValid = false;
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

            ap.AddLecturer(fn, sn, dob, add, cy, ge, mail, phone, salary);
            MessageBox.Show("Data Added", "Add Lecturer", MessageBoxButtons.OK, MessageBoxIcon.Information);

            AllClear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = dgvLec.SelectedCells[0].RowIndex;
            int id = (int)dgvLec.Rows[index].Cells[0].Value;
            string fn = txtFn.Text;
            string sn = txtSn.Text;

            if (id > 0)
            {
                string dob = dtpDOB.Text;
                string add = txtAddress.Text;
                string cy = cboCy.SelectedItem?.ToString();  // Add null check
                string ge = rdoMale.Checked ? "Male" : "Female";  // Simplify gender check
                string mail = txtEmail.Text;
                string phone = txtPhone.Text;
                decimal salary = 0;
                // Use the obtained ID to update the student data
                ap.UpdateLec(id, fn, sn, dob, add, cy, ge, mail, phone, salary);

                MessageBox.Show("Data Updated", "Update Lecturer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tidy up
                AllClear();

            }
            else
            {
                MessageBox.Show("Lecturer not found. Please check the provided first name and last name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            foreach (DataGridViewRow row in dgvLec.Rows)
            {
                var gridEmail = row.Cells[8].Value?.ToString();
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
        public int CountDuplicateMobile(string mobile)
        {
            int count = 0;
            foreach (DataGridViewRow row in dgvLec.Rows)
            {
                var gridMobile = row.Cells[8].Value?.ToString();
                if (gridMobile == txtPhone.Text)
                {
                    count++;
                }
            }
            return count;
        }
        public string MobileValidate(string LecMobile)
        {
            string MobileErrorMessage = string.Empty;
            LecMobile = LecMobile.Trim();
            if (LecMobile == "")
            {
                MobileErrorMessage = "Mobile Number required";
            }
            else if (LecMobile.Length > 20)
            {
                MobileErrorMessage = "The mobile number needs to be between 11-20 digits";
            }
            else if (LecMobile.Length < 11)
            {
                MobileErrorMessage = "The mobile number needs to be a minimum of 11 digits";
            }
            else
            {
                MobileErrorMessage = string.Empty;
            }
            return MobileErrorMessage;
        }
        public string SalaryValidate(string salary)
        {
            string salaryErrorMessage = string.Empty;
            string salaryString = salary.ToString().Trim();
            if (string.IsNullOrEmpty(salaryString))
            {
                salaryErrorMessage = "Salary cannot be empty or null.";
            }
            else
            {
                if (!decimal.TryParse(salaryString, out decimal parsedSalary))
                {
                    salaryErrorMessage = "Invalid salary format.";
                }
                else if (parsedSalary < 0)
                {
                    salaryErrorMessage = "Salary cannot be negative.";
                }
            }
            return salaryErrorMessage;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dgvLec.SelectedCells[0].RowIndex;
            int id = (int)dgvLec.Rows[index].Cells[0].Value;

            ap.DeleteLec(id);
            MessageBox.Show("Data Deleted", "Delete Lecturer", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgvLec.Rows.RemoveAt(index);
        }

        private void dgvLec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell firstCell = dgvLec.Rows[e.RowIndex].Cells[0];
            DataGridViewCell secondCell = dgvLec.Rows[e.RowIndex].Cells[1];
            DataGridViewCell thirdCell = dgvLec.Rows[e.RowIndex].Cells[2];
            DataGridViewCell forthCell = dgvLec.Rows[e.RowIndex].Cells[3];
            DataGridViewCell fifthCell = dgvLec.Rows[e.RowIndex].Cells[4];
            DataGridViewCell sixthCell = dgvLec.Rows[e.RowIndex].Cells[5];
            DataGridViewCell seventhCell = dgvLec.Rows[e.RowIndex].Cells[6];
            DataGridViewCell eighthCell = dgvLec.Rows[e.RowIndex].Cells[7];
            DataGridViewCell ninthCell = dgvLec.Rows[e.RowIndex].Cells[8];
            DataGridViewCell tenthCell = dgvLec.Rows[e.RowIndex].Cells[9];


            int cellValue = (int)firstCell.Value;
            dgvLec.Rows[e.RowIndex].Selected = true;
            txtFn.Text = (string)secondCell.Value;
            txtSn.Text = (string)thirdCell.Value;
            dtpDOB.Text = (string)forthCell.Value;
            txtAddress.Text = (string)fifthCell.Value;

            string countyValue = (string)sixthCell.Value;
            int countyIndex = cboCy.FindString(countyValue);
            cboCy.SelectedIndex = countyIndex;

            txtEmail.Text = (string)eighthCell.Value;
            txtPhone.Text = (string)ninthCell.Value;

            txtSalary.Text = ((decimal)tenthCell.Value).ToString();
            
        }

        private void txtFn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
