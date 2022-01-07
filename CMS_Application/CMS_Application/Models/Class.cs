using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_Application.Models
{
    public class Class
    {
        private ClassDataObject dataObject = new ClassDataObject();
        public int Id;
        public string Name { get; set; }
        public int CreditHours { get; set; }
        public string Announcement { get; set; }
        public Teacher Instructor { get; set; }
        public Class FindClass(int id)
        {
            return dataObject.FindClass(id);
        }
        public List<Class> AllOfferedCourses()
        {
            return dataObject.AllCourses();
        }
        public List<Class> CourseClasses(string c)
        {
            return dataObject.CourseClasses(c);
        }

    }
}
