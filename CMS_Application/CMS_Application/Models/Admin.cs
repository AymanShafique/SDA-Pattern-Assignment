using CMS_Applicaion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_Application.Models
{
    public class Admin:Person
    {
        public List<Student> students = new List<Student>();
        public List<Teacher> teachers = new List<Teacher>();

        public List<Student> getAllStudents()
        {
            StorageClass dal = new StorageClass();
            return dal.AllStudents();
        }
        public List<Teacher> getAllTeachers()
        {
            StorageClass dal = new StorageClass();
            return dal.AllTeachers();
        }

        public void addStudent(Student s)
        {
            StorageClass dal = new StorageClass();
            dal.InsertStudent(s);
        }

        public void addTeacher(Teacher t)
        {
            StorageClass dal = new StorageClass();
            dal.InsertTeacher(t);
        }
        public void removeStudent(int id)
        {
            StorageClass dal = new StorageClass();
            dal.DeleteStudent(id);
        }

        public void removeTeacher(int id)
        {
            StorageClass dal = new StorageClass();
            dal.DeleteTeacher(id);
        }
        public void updateStudent(Student s)
        {
            StorageClass dal = new StorageClass();
            dal.UpdateStudent(s);
        }

        public void updateTeacher(Teacher t)
        {
            StorageClass dal = new StorageClass();
            dal.UpdateTeacher(t);
        }
        public Admin UserInfo(int id)
        {
            StorageClass dal = new StorageClass();
            return dal.AdminInfo(id);
        }
    }

}

