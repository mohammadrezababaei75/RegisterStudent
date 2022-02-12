using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RegisterStudent.BusinessLayer;

namespace RegisterStudent
{
    
    public partial class Form1 : Form
    {
        private void FillDGVStudyField()
        {
            dataGridViewStudyFields.DataSource = StudyField.getStudyFields();
        }
        private void FillDGVStudnts(string con="All")
        {
            dataGridViewStudents.DataSource = Student.getStudents(con);
        }
        private void ClearInputs()
        {
            txtName.Text = "";
            txtLname.Text = "";
            txtFatherName.Text = "";
            txtBirthCertificateNo.Text = "";
            txtBirthCertificateLoc.Text = "";
            txtStudentCode.Text = "";
            cmbBirthdayD.SelectedItem = null;
            cmbBirthdayM.SelectedItem = null;
            cmbBirthdayY.SelectedItem = null;
            cmbEntryYear.SelectedItem = null;
            cmbStudentStudyField.SelectedItem = null;
            chkGraduated.Checked = false;
        }
        private void SetCMBStudyField()
        {
            cmbStudentStudyField.DisplayMember = "name";
            cmbStudentStudyField.ValueMember = "Id"; //Field in the datatable which you want to be the value of the combobox 
            cmbStudentStudyField.DataSource = StudyField.getStudyFields();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblSaveNewStudentResult.Text =cmbStudentStudyField.SelectedValue.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillDGVStudyField();
            FillDGVStudnts();
            SetCMBStudyField();
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            if (txtStudentCode.Text.Length != 12 || !double.TryParse(txtStudentCode.Text, out double out_number))
            {
                lblSaveNewStudentResult.Text = "شماره دانشجویی باید 12 رقم و عدد باشد.";
                txtStudentCode.Focus();
                return;
            }
            if (Student.StudentNumberExist(txtStudentCode.Text))
            {
                lblSaveNewStudentResult.Text = "کد دانشجویی تکراری می باشد.";
                txtStudentCode.Focus();
                return;
            }
            if (Convert.ToInt32(cmbBirthdayY.Text) > Convert.ToInt32(cmbEntryYear.Text))
            {
                lblSaveNewStudentResult.Text = "سال تولد از سال ورود به دانشگاه باید کوچکتر باشد.";
                txtStudentCode.Focus();
                return;
            }
            Student newstudent = new Student();
            newstudent.FirstName=txtName.Text;
            newstudent.LastName=txtLname.Text;
            newstudent.FatherName=txtFatherName.Text;
            newstudent.BirthCertificateNo=txtBirthCertificateNo.Text;
            newstudent.BirthCertificateLoc = txtBirthCertificateLoc.Text;
            newstudent.BirthdayD = Convert.ToInt32(cmbBirthdayD.Text);
            newstudent.BirthdayM = Convert.ToInt32(cmbBirthdayM.Text);
            newstudent.BirthdayY = Convert.ToInt32(cmbBirthdayY.Text);
            newstudent.StudentNumber=txtStudentCode.Text;
            newstudent.StudentFieldId=Convert.ToInt32(cmbStudentStudyField.SelectedValue);
            newstudent.EntryYear = Convert.ToInt32(cmbEntryYear.Text);
            newstudent.Graduated = chkGraduated.Checked;
            newstudent.Save();
            lblSaveNewStudentResult.Text = "";
            ClearInputs();
            tabMain.SelectedTab=tabStudentList;
            FillDGVStudnts();



        }

        private void btnNewStudyField_Click(object sender, EventArgs e)
        {
            if (txtNewStudyfield.Text == "")
            {
                lblStudyFieldResult.Text = "نام رشته را وارد کنید.";
                lblStudyFieldResult.ForeColor = Color.Red;
                txtNewStudyfield.Focus();
                return;
            }
            else { 
                StudyField sf = new StudyField();
                sf.NewStudyField=txtNewStudyfield.Text;
                sf.Save();
                FillDGVStudyField();
                SetCMBStudyField();
                txtNewStudyfield.Text = "";
                txtNewStudyfield.Focus();
                lblStudyFieldResult.Text = "";
            }
        }

        private void chkShowGraduated_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowGraduated.Checked)
                FillDGVStudnts("Graduated");
            else
                FillDGVStudnts();
        }

        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void dataGridViewStudents_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int columnIndex = e.ColumnIndex;

            if (columnIndex.ToString() == "8")
            {
                int Id=Convert.ToInt32(dataGridViewStudents.Rows[e.RowIndex].Cells["Id"].Value);
                bool Flag=!Convert.ToBoolean(dataGridViewStudents.Rows[e.RowIndex].Cells["Graduated"].Value);
                Student.SetStudentGraduatedStatus(Id,Flag);
                FillDGVStudnts();
            }
        }
    }
}
