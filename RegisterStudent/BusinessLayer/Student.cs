using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RegisterStudent.DataLayer;
using System.Data;

namespace RegisterStudent.BusinessLayer
{
    internal class Student
    {
        private string firstName;
        private string lastname;
        private string father_name;
        private string birth_certificate_no;
        private string birth_certificate_loc;
        private int birthday_d;
        private int birthday_m;
        private int birthday_y;
        private string student_number;
        private int study_field_id;
        private int entry_year;
        private bool graduated;

        public Student()
        {

        }
        public string FirstName { get;set; }
        public string LastName { get;set; }
        public string FatherName { get;set; }
        public string BirthCertificateNo { get;set; }
        public string BirthCertificateLoc { get;set; }
        public int  BirthdayD { get;set; }
        public int  BirthdayM { get;set; }
        public int  BirthdayY { get;set; }
        public string StudentNumber
        {
            get { return this.student_number; }
            set {
                double out_number;
                if (value.Length != 12 || !double.TryParse(value, out out_number))
                {
                    MessageBox.Show("error...");
                    return;
                }else{
                    student_number = value;
                }
                
        }
        }
        public int StudentFieldId { get;set; }
        public int EntryYear { get;set; }
        public bool Graduated { get;set; }
        public string FullName { get { return FirstName + " " + LastName; } }
        public string BirthDay { get { return BirthdayY.ToString() + '/' + BirthdayM.ToString() + '/' + BirthdayD.ToString(); } }
        public bool Save()
        {
            RegisterStudentDB db = new RegisterStudentDB();
            db.SaveNewStudent(FullName,StudentNumber,BirthDay,FatherName,BirthCertificateNo,BirthCertificateLoc,EntryYear,7,Graduated);
            return true;
        }

        public static DataTable getStudents(String Con="All")
        {
            RegisterStudentDB db=new RegisterStudentDB();
            DataTable result=new DataTable();
            switch (Con)
            {
                case("All"):
                    result=db.getAllStudents();
                    break;
                case ("Graduated"):
                    result= db.getAllGraduatedStudents();
                    break;
            }
            return result;
        }
        public static bool StudentNumberExist(string sn)
        {
            return RegisterStudentDB.StudentNumberExist_DB(sn);
        }

        public static bool SetStudentGraduatedStatus(int Id,bool Flag)
        {
            RegisterStudentDB db = new RegisterStudentDB();
            return db.SetStudentGraduatedStatus_DB(Id,Flag);
        }

    }
}
