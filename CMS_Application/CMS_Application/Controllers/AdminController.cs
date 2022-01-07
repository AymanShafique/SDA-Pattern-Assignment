using CMS_Applicaion.Models;
using CMS_Application.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_Application.Controllers
{
    public class AdminController : Controller
    {
        public ViewResult HomePage(Admin a)
        {
            return View("MainPage", a);
        }
        public ViewResult ShowHomePage(int id)
        {
            Admin a = new Admin();
            a = a.UserInfo(id);
            return View("MainPage", a);
        }
        public ViewResult AddStudent(int id)
        {
            Admin a = new Admin();
            a = a.UserInfo(id);
            Student s = new Student();
            return View("AddStudent",s);
        }
        public ViewResult AddTeacher(int id)
        {
            Admin a = new Admin();
            a = a.UserInfo(id);
            return View("AddTeacher");
        }
        [HttpPost]
        public ViewResult AddTeacher(Teacher t)
        {
            Admin a = new Admin();
            a = a.UserInfo(1);
            a.addTeacher(t);
            a.teachers = a.getAllTeachers();
            return View("TeachersInfo", a);
        }
        [HttpPost]
        public ViewResult AddStudent(Student s)
        {
            Admin a = new Admin();
            a = a.UserInfo(1);
            a.addStudent(s);
            a.students = a.getAllStudents();
            return View("StudentsInfo", a);
        }
        public ViewResult AllStudent(int id)
        {
            Admin a = new Admin();
            a = a.UserInfo(id);
            a.students = a.getAllStudents();
            return View("StudentsInfo", a);
        }
        public ViewResult EditStudent(int aid, int id)
        {
            Admin a = new Admin();
            a = a.UserInfo(id);
            Student s = new Student();
            s = s.StudentInfo(id);
            return View("EditStudent", s);
        }
        [HttpPost]
        public ViewResult EditStudent(Student s)
        {

            Admin a = new Admin();
            a = a.UserInfo(1);
            if (s.Password == null)
            {
                Student stu = new Student();
                stu = stu.StudentInfo(s.Id);
                s.Password = stu.Password;
            }
            a.updateStudent(s);
            a.students = a.getAllStudents();
            return View("StudentsInfo", a);
        }
        public ViewResult RemoveStudent(int aid, int id)
        {
            Admin a = new Admin();
            a = a.UserInfo(aid);
            a.removeStudent(id);
            a.students = a.getAllStudents();
            return View("StudentsInfo", a);
        }
        public ViewResult AllTeacher(int id)
        {
            Admin a = new Admin();
            a = a.UserInfo(id);
            a.teachers = a.getAllTeachers();
            return View("TeachersInfo", a);
        }
        public ViewResult EditTeacher(int aid, int id)
        {
            Admin a = new Admin();
            a = a.UserInfo(aid);
            Teacher t = new Teacher();
            t = t.TeacherInfo(id);
            return View("EditTeacher", t);
        }
        [HttpPost]
        public ViewResult EditTeacher(Teacher t)
        {
            Admin a = new Admin();
            a = a.UserInfo(1);
            if (t.Password == null)
            {
                Teacher t1 = new Teacher();
                t1 = t1.TeacherInfo(t.Id);
                t.Password = t1.Password;
            }
            a.updateTeacher(t);
            a.teachers = a.getAllTeachers();
            return View("TeachersInfo", a);
        }
        public ViewResult RemoveTeacher(int aid, int id)
        {
            Admin a = new Admin();
            a = a.UserInfo(aid);
            a.removeTeacher(id);
            a.teachers = a.getAllTeachers();
            return View("TeachersInfo", a);
        }
    }
}
