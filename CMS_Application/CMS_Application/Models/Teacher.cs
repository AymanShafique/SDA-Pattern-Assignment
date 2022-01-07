using CMS_Applicaion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_Application.Models
{
    public class Teacher : Person
    {
        private TeacherDataObject dataObject = new TeacherDataObject();
        public string Degree { get; set; }
        public List<Class> Courses { get; set; }
        public int Found(Person u)
        {
            return dataObject.UserFound(u);
        }
        public Teacher TeacherInfo(int id)
        {
            return dataObject.UserInfo(id);
        }
        public List<Class> AllCurrentCourses(int id)
        {
            return dataObject.TeacherAllCurrentCourses(id);
        }
    }
}
