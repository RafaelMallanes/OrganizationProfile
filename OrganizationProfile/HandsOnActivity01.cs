using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizationProfile
{
    public partial class frmRegistration : Form
    {

        private String _FullName;
        private int _Age;
        private long _ContactNumber;
        private long _StudentNumber;


        public long StudentNumber(string studNum)
        {

            _StudentNumber = long.Parse(studNum);

            return _StudentNumber;
        }

        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNumber = long.Parse(Contact);
            }
            else
            {
                throw new FormatException();
                throw new ArgumentNullException();
                throw new OverflowException();
                throw new IndexOutOfRangeException();
            }

            return _ContactNumber;
        }
        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }
            else
            {
                throw new ArgumentNullException();
            }


            return _FullName;
        }
        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }
            else
            {
                throw new FormatException();
                throw new ArgumentNullException();
                throw new OverflowException();
                throw new IndexOutOfRangeException();
            }

            return _Age;
        }

        public frmRegistration()
        {
            InitializeComponent();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {


            string[] ListOfProgram = new string[]
            {
               "Bacherlor of  Information Technology",
               "Bachelor of  Computer Science",
               "Bachelor in  Information Systems",
               "Baachelor in Accountancy",
               "Bachelor in Hospitality Management",
               "Bachelor in Tourism Management",
            };


            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }


        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                StudentInformationClass.SetFullName = FullName(txtLastname.Text, txtFirstname.Text, txtMiddleInitial.Text);
                StudentInformationClass.SetStudentNo = StudentNumber(txtStudentNo.Text);
                StudentInformationClass.SetProgram = cbPrograms.Text;
                StudentInformationClass.SetGender = cbGender.Text;
                StudentInformationClass.SetContactNo = ContactNo(txtContactNo.Text);
                StudentInformationClass.SetAge = Age(txtAge.Text);
                StudentInformationClass.SetBirthday = datePickerBirthday.Value.ToString("yyyy-MM-dd");

                frmConfirmation frm = new frmConfirmation();
                frm.ShowDialog();
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
            catch (ArgumentNullException ae)
            {
                MessageBox.Show(ae.Message);
            }
            catch (OverflowException oe)
            {
                MessageBox.Show(oe.Message);
            }
            catch (IndexOutOfRangeException ie)
            {
                MessageBox.Show(ie.Message);
            }
        }

        private void txtStudentNo_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

