using CMS_Applicaion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_Application.Models
{
    public class TeacherDataObject
    {
        public int UserFound(Person u)
        {
            StorageClass dal = new StorageClass();
            return dal.FindTeacher(u);
        }
        public Teacher UserInfo(int id)
        {
            StorageClass dal = new StorageClass();
            return dal.TeacherInfo(id);
        }
        public List<Class> TeacherAllCurrentCourses(int id)
        {
            StorageClass dal = new StorageClass();
            return dal.TeacherCourses(id);
        }
    }
}
