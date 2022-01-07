using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_Application.Models
{
    public class ClassDataObject
    {
        public Class FindClass(int id)
        {
            StorageClass dal = new StorageClass();
            return dal.FindClass(id);
        }
        public List<Class> AllCourses()
        {
            StorageClass dal = new StorageClass();
            return dal.AllOfferedCourses();
        }
        public List<Class> CourseClasses(string c)
        {
            StorageClass dal = new StorageClass();
            return dal.CourseClasses(c);
        }
    }
}
