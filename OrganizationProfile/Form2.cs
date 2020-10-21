using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizationProfile
{
    public partial class frmConfirmation : Form
    {
        public frmConfirmation()
        {
            InitializeComponent();
        }

        private void frmConfirmation_Load(object sender, EventArgs e)
        {
            lblStudentNo.Text = StudentInformationClass.SetStudentNo.ToString();
            lblProgram.Text = StudentInformationClass.SetProgram;
            lblName.Text = StudentInformationClass.SetFullName;
            lblBirthday.Text = StudentInformationClass.SetBirthday;
            lblGender.Text = StudentInformationClass.SetGender;
            lblAge.Text = StudentInformationClass.SetAge.ToString();
            lblContactNo.Text = StudentInformationClass.SetContactNo.ToString();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You finally registered");

        }
    }
}
