using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RegisterStudent.DataLayer;
using System.Data;

namespace RegisterStudent.BusinessLayer
{
    internal class StudyField
    {
        //private string newStudyField;
        public string NewStudyField { get; set; }
        public void Save()
        {
            RegisterStudentDB db =new RegisterStudentDB();
            db.SaveNewStudyField(NewStudyField);
        }
        static public DataTable getStudyFields()
        {
            RegisterStudentDB db = new RegisterStudentDB();
            return db.getAllStudyFields();
        }
        
    }
}
