using CMS_Applicaion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_Application.Models
{
    public class TeacherLoginStrategy
    {
        public int TeacherFound(Person u)
        {
            StorageClass dal = new StorageClass();
            return dal.FindTeacher(u);
        }
    }
}
