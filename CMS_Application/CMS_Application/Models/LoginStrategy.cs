using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_Application.Models
{
    public class LoginStrategy
    {
        public static LoginStrategy Instance { get; } = new LoginStrategy();
        public TeacherLoginStrategy Teacher = new TeacherLoginStrategy();
        public StudentLoginStrategy Student = new StudentLoginStrategy();
        public AdminLoginStrategy Admin = new AdminLoginStrategy();
        public static LoginStrategy getInstance()
        {
            return Instance;
        }

    }
}
