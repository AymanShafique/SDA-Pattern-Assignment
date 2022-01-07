using CMS_Applicaion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_Application.Models
{
    public class Factory
    {
        public Person GetPerson(PersonType type)
        {
            switch (type)
            {
                case PersonType.Student:
                    return new Student();
                case PersonType.Teacher:
                    return new Teacher();
                case PersonType.Admin:
                    return new Admin();
                default:
                    throw new NotSupportedException();
            }
        }
        public Person GetPersonInfo(PersonType type, int id)
        {
            switch (type)
            {
                case PersonType.Student:
                    return new StudentDataObject().UserInfo(id);
                case PersonType.Teacher:
                    return new Teacher().TeacherInfo(id);
                case PersonType.Admin:
                    return new Admin().UserInfo(id);
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
