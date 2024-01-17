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
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }
        AddPerson ap = new AddPerson();
        private void btnStu_Click(object sender, EventArgs e)
        {
            dgv.DataSource = false;
            dgv.DataSource = ap.ShowStu();
        }

        private void btnLec_Click(object sender, EventArgs e)
        {
            dgv.DataSource = false;
            dgv.DataSource = ap.ShowLec();
        }

        private void View_Load(object sender, EventArgs e)
        {
            cboAR.DataSource = Enum.GetValues(typeof(AgeRange));
            cboGe.DataSource = Enum.GetValues(typeof(Gender));
        }

        private void btnGL_Click(object sender, EventArgs e)
        {
            dgv.DataSource = false;
            dgv.DataSource = ap.ShowMaleLec();
        }

        private void btnGS_Click(object sender, EventArgs e)
        {
            dgv.DataSource = false;
            dgv.DataSource = ap.ShowFemaleStu();
        }

        private void btnAS_Click(object sender, EventArgs e)
        {
            dgv.DataSource = false;
            dgv.DataSource = ap.StuAbove25();
        }

        private void btnAL_Click(object sender, EventArgs e)
        {
            dgv.DataSource = false;
            dgv.DataSource = ap.LecBelow25();
        }

        private void btnSD_Click(object sender, EventArgs e)
        {
            dgv.DataSource = false;
            dgv.DataSource = ap.StuDub();
        }
        private void btnLD_Click(object sender, EventArgs e)
        {
            dgv.DataSource = false;
            dgv.DataSource = ap.LecDub();
        }
    }
}
