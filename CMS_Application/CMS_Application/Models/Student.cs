using CMS_Application.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_Applicaion.Models
{
    public class Student : Person
    {
        public string Degree { get; set; }
        public string RollNo { get; set; }
        public List<Class> Courses { get; set; }
        private StudentDataObject dataObject = new StudentDataObject();
        public virtual int Found(Person u)
        {
            return dataObject.UserFound(u);
        }
        public Student StudentInfo(int id)
        {
            return dataObject.UserInfo(id);
        }
        public List<Class> AllCurrentCourses(int id)
        {
            return dataObject.StudentAllCurrentCourses(id);
        }
    }
}
