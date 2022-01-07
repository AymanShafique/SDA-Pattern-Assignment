using CMS_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_Applicaion.Models
{
    public class StudentDataObject
    {
        public int UserFound(Person u)
        {
            StorageClass dal = new StorageClass();
            return dal.FindStudent(u);
        }
        public Student UserInfo(int id)
        {
            StorageClass dal = new StorageClass();
            return dal.UserInfo(id);
        }
        public List<Class> StudentAllCurrentCourses(int id)
        {
            StorageClass dal = new  StorageClass();
            return dal.CurrentCourses(id);
        }
    }
}
