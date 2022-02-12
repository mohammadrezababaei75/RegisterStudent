using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace RegisterStudent.DataLayer
{
    internal class RegisterStudentDB
    {
        //static private string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MohammadReza\source\repos\RegisterStudent\RegisterStudent\RegisterStudent.mdf;Integrated Security=True";
        static private string connstr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+Application.StartupPath+@"\RegisterStudent.mdf;Integrated Security=True";
        public void SaveNewStudyField(string StudyField)
        {
            SqlConnection conn=new SqlConnection(connstr);
            conn.Open();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = conn;
            sqlcmd.CommandText = "Insert into study_fields(name) Values(@name)";
            sqlcmd.Parameters.AddWithValue("name", StudyField);
            sqlcmd.ExecuteNonQuery();
            conn.Close();
        }
        
        public void SaveNewStudent(string Name, string Code, string Birthday, string FatherName, string BirthdayCertificationNo, string BirthdayCertificationLoc, int EntryYear, int StudyField, bool Graduated)
        {
            SqlConnection conn=new SqlConnection(connstr);
            conn.Open();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = conn;
            sqlcmd.CommandText = "INSERT INTO students (name,code,birthday,father_name,birth_certificate_no,birth_certificate_location,entry_year,study_field,graduated) "
                + "VALUES (@Name,@Code,@Birthday,@FatherName,@BirthdayCertificationNo,@BirthdayCertificationLoc,@EntryDate,@StudyField,@Graduated)";
            sqlcmd.Parameters.AddWithValue("@Name", Name);
            sqlcmd.Parameters.AddWithValue("@Code", Code);
            sqlcmd.Parameters.AddWithValue("@Birthday", Birthday);
            sqlcmd.Parameters.AddWithValue("@FatherName", FatherName);
            sqlcmd.Parameters.AddWithValue("@BirthdayCertificationNo", BirthdayCertificationNo);
            sqlcmd.Parameters.AddWithValue("@BirthdayCertificationLoc", BirthdayCertificationLoc);
            sqlcmd.Parameters.AddWithValue("@EntryDate", EntryYear.ToString());
            sqlcmd.Parameters.AddWithValue("@StudyField", StudyField.ToString());
            sqlcmd.Parameters.AddWithValue("@Graduated", Graduated.ToString());
            sqlcmd.ExecuteNonQuery();
            conn.Close();
        }

        static public bool StudentNumberExist_DB(string sn)
        {
            bool ExistFlag;
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = conn;
            sqlcmd.CommandText = "SELECT count(*) FROM students WHERE code = @code";
            sqlcmd.Parameters.AddWithValue("code",sn);
            ExistFlag= Convert.ToBoolean(Convert.ToInt32(sqlcmd.ExecuteScalar()));
            conn.Close();
            return ExistFlag;
        }

        public DataTable getAllStudyFields()
        {
            SqlConnection conn = new SqlConnection(connstr);
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter();
            SqlCommand sqlcmd=new SqlCommand();
            sqlcmd.Connection = conn;
            sqlcmd.CommandText = "Select * from study_fields ORDER BY Id ASC";
            da.SelectCommand = sqlcmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable getAllStudents()
        {
            SqlConnection conn = new SqlConnection(connstr);
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter();
            SqlCommand sqlcmd=new SqlCommand();
            sqlcmd.Connection = conn;
            sqlcmd.CommandText = "select students.Id,students.name,students.code,students.birthday,students.father_name,students.birth_certificate_no,"
                                + "students.birth_certificate_location,students.entry_year,students.graduated,study_fields.name as study_field "
                                +"From students "
                                +"inner join study_fields on students.study_field = study_fields.Id ORDER BY code ASC";
            da.SelectCommand = sqlcmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable getAllGraduatedStudents()
        {
            SqlConnection conn = new SqlConnection(connstr);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = conn;
            sqlcmd.CommandText = "select students.Id,students.name,students.code,students.birthday,students.father_name,students.birth_certificate_no,"
                                + "students.birth_certificate_location,students.entry_year,students.graduated,study_fields.name as study_field "
                                + "From students "
                                + "inner join study_fields on students.study_field = study_fields.Id "
                                + "where graduated=1"
                                + "ORDER BY code ASC";
            da.SelectCommand = sqlcmd;
            da.Fill(dt);
            return dt;
        }

        public bool SetStudentGraduatedStatus_DB(int Id,bool Flag)
        {
            bool Result;
            SqlConnection conn=new SqlConnection(connstr);
            conn.Open();
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = conn;
            sqlcmd.CommandText = "update students set graduated=@Flag where Id=@Id";
            sqlcmd.Parameters.AddWithValue("Flag", Flag);
            sqlcmd.Parameters.AddWithValue("Id", Id);
            sqlcmd.ExecuteNonQuery();

            sqlcmd.CommandText = "select graduated From students Where Id=@Id";
            //sqlcmd.Parameters.AddWithValue("Id", Id);
            Result=Convert.ToBoolean(sqlcmd.ExecuteScalar());
            conn.Close();
            return Result;
        }
    }
}
