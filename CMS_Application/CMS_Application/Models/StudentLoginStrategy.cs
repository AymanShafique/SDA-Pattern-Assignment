using CMS_Applicaion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_Application.Models
{
    public class StudentLoginStrategy
    {
        public int StudentFound(Person u)
        {
            StorageClass dal = new StorageClass();
            return dal.FindStudent(u);
        }
    }
}
