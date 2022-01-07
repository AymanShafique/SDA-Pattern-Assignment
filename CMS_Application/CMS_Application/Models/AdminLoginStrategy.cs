using CMS_Applicaion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_Application.Models
{
    public class AdminLoginStrategy
    {
        public int AdminFound(Person u)
        {
            StorageClass dal = new StorageClass();
            return dal.FindAdmin(u);
        }
    }
}
