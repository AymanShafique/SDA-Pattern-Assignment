using CMS_Applicaion.Models;
using CMS_Application.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_Application.Models
{
    public class StorageClass
    {
        private string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CMSdatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private SqlConnection connection;
        private string query;
        SqlCommand cmd;

        public void InsertStudent(Student s)
        {
            if (lastId(s.Degree)+1 < 10)
            {
                s.RollNo = "BS" + s.Degree + "F18M00" + lastId(s.Degree)+1;
            }
            else if ((lastId(s.Degree)+1 < 10)&&(lastId(s.Degree) < 100))
            {
                s.RollNo = "BS" + s.Degree + "F18M0" + lastId(s.Degree)+1;
            }
            s.Degree = "BS" + s.Degree;
            connection = new SqlConnection(conString);
            query = $"insert into Student (Name, RollNo,Password, Degree, Address, Phone) values(@n,@r,@p,@d,@a,@ph)";
            SqlParameter p1 = new SqlParameter("n", s.Name);
            SqlParameter p2 = new SqlParameter("r", s.RollNo);
            SqlParameter p3 = new SqlParameter("p", s.Password);
            SqlParameter p4 = new SqlParameter("d", s.Degree);
            SqlParameter p5 = new SqlParameter("a", s.Address);
            SqlParameter p6 = new SqlParameter("ph", s.PhoneNo);
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void InsertTeacher(Teacher t)
        {
            connection = new SqlConnection(conString);
            query = $"insert into Teacher (Name,Password, Degree,Address,Phone) values(@n,@p,@d,@a,@ph)";
            SqlParameter p1 = new SqlParameter("n", t.Name);
            SqlParameter p2 = new SqlParameter("p", t.Password);
            SqlParameter p3 = new SqlParameter("d", t.Degree);
            SqlParameter p4 = new SqlParameter("a", t.Address);
            SqlParameter p5 = new SqlParameter("ph", t.PhoneNo);
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void DeleteStudent(int id)
        {
            connection = new SqlConnection(conString);
            query = $"delete from Student where Id=@i";
            SqlParameter p1 = new SqlParameter("i", id);
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p1);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void DeleteTeacher(int id)
        {
            connection = new SqlConnection(conString);
            query = $"delete from Teacher where Id=@i";
            SqlParameter p1 = new SqlParameter("i", id);
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p1);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public int lastId(string degree)
        {
            connection = new SqlConnection(conString);
            connection.Open();
            query = $"select * from Student where Degree=@d";
            SqlParameter p1 = new SqlParameter("d", degree);
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p1);
            SqlDataReader dr = cmd.ExecuteReader();
            int id = 0;
            while (dr.Read())
            {
               id = dr.GetInt32(0);
            }
            connection.Close();
            return id;
        }
        public void UpdateStudent(Student s)
        {
            connection = new SqlConnection(conString);
            query = $"update Student set Name=@n,RollNo=@r,Password=@p,Degree=@d,Address=@a,Phone=@ph where Id=@i";
            SqlParameter p1 = new SqlParameter("n", s.Name);
            SqlParameter p2 = new SqlParameter("r", s.RollNo);
            SqlParameter p3 = new SqlParameter("p", s.Password);
            SqlParameter p4 = new SqlParameter("d", s.Degree);
            SqlParameter p5 = new SqlParameter("a", s.Address);
            SqlParameter p6 = new SqlParameter("ph", s.PhoneNo);
            SqlParameter p7 = new SqlParameter("i", s.Id);
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void UpdateTeacher(Teacher t)
        {
            connection = new SqlConnection(conString);
            query = $"update Teacher set Name=@n,Password=@p,Degree=@d,Address=@a,Phone=@ph where Id=@i";
            SqlParameter p1 = new SqlParameter("n", t.Name);
            SqlParameter p2 = new SqlParameter("p", t.Password);
            SqlParameter p3 = new SqlParameter("d", t.Degree);
            SqlParameter p4 = new SqlParameter("a", t.Address);
            SqlParameter p5 = new SqlParameter("ph", t.PhoneNo);
            SqlParameter p6 = new SqlParameter("i", t.Id);
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public Admin AdminInfo(int id)
        {
            connection = new SqlConnection(conString);
            query = $"select * from Admin where Id=@i";
            SqlParameter p = new SqlParameter("i", id);
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p);
            connection.Open();
            SqlDataReader d = cmd.ExecuteReader();
            Admin a = new Admin();
            while (d.Read())
            {
                a.Id = d.GetInt32(0);
                a.Name = d.GetValue(1).ToString();
            }
            connection.Close();
            return a;
        }
        public int FindAdmin(Person u)
        {
            connection = new SqlConnection(conString);
            connection.Open();
            query = $"select * from Admin where Name=@n and Password=@p";
            SqlParameter p1 = new SqlParameter("n", u.UserId);
            SqlParameter p2 = new SqlParameter("p", u.Password);
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                return dr.GetInt32(0);
            }
            connection.Close();
            return 0;
        }
        public List<Student> AllStudents()
        {
            connection = new SqlConnection(conString);
            connection.Open();
            query = $"select * from Student";
            cmd = new SqlCommand(query, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Student> stu = new List<Student>();
            while (dr.Read())
            {
                Student s = new Student();
                s.Id = dr.GetInt32(0);
                s.Name = dr.GetValue(1).ToString();
                s.RollNo = dr.GetValue(2).ToString();
                s.Degree = dr.GetValue(4).ToString();
                s.Address = dr.GetValue(5).ToString();
                s.PhoneNo = dr.GetValue(6).ToString();
                stu.Add(s);
            }
            connection.Close();
            return stu;
        }
        public List<Teacher> AllTeachers()
        {
            connection = new SqlConnection(conString);
            connection.Open();
            query = $"select * from Teacher";
            cmd = new SqlCommand(query, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            List<Teacher> teachers = new List<Teacher>();
            while (dr.Read())
            {
                Teacher t = new Teacher();
                t.Id = dr.GetInt32(0);
                t.Name = dr.GetValue(1).ToString();
                t.Degree = dr.GetValue(3).ToString();
                t.Address = dr.GetValue(4).ToString();
                t.PhoneNo = dr.GetValue(5).ToString();
                teachers.Add(t);
            }
            connection.Close();
            return teachers;
        }




        public int FindStudent(Person u)
        {
            connection = new SqlConnection(conString);
            connection.Open();
            query = $"select * from Student where RollNo=@r and Password=@p";
            SqlParameter p1 = new SqlParameter("r", u.UserId);
            SqlParameter p2 = new SqlParameter("p", u.Password);
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                return dr.GetInt32(0);
            }
            connection.Close();
            return 0;
        }
        public Student UserInfo(int id)
        {
            connection = new SqlConnection(conString);
            query = $"select * from Student where Id=@i";
            SqlParameter p1 = new SqlParameter("i", id);
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p1);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Student s = new Student();
            s.Id = -1;
            while (dr.Read())
            {
                s.Id = id;
                s.Name = dr.GetValue(1).ToString();
                s.RollNo = dr.GetValue(2).ToString();
                s.Degree = dr.GetValue(4).ToString();
                s.Password = dr.GetValue(3).ToString();
                s.Address = dr.GetValue(5).ToString();
                s.PhoneNo = dr.GetValue(6).ToString();
            }
            connection.Close();
            return s;
        }
        /*public List<Class> CurrentCourses(int id)
        {
            connection = new SqlConnection(conString);
            query = $"select * from Class where StudentId=@i";
            SqlParameter p = new SqlParameter("i", id);
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p);
            connection.Open();
            SqlDataReader d = cmd.ExecuteReader();
            List<int> cid = new List<int>();
            while (d.Read())
            {
                int i = d.GetInt32(0);
                cid.Add(i);
            }
            List<Class> courses = new List<Class>();
            foreach (int i in cid)
            {
                courses.Add(FindCourse(i));
            }
            connection.Close();
            return courses;
        }*/
        public Class FindCourse(int id)
        {
            connection = new SqlConnection(conString);
            query = $"select * from Course where Id=@i";
            SqlParameter p = new SqlParameter("i", id);
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Class c = new Class();

            while (dr.Read())
            {
                c.Id = dr.GetInt32(0);
                c.Name = dr.GetValue(1).ToString();
                c.CreditHours = dr.GetInt32(2);
            }
            connection.Close();
            return c;
        }
        public List<Class> CurrentCourses(int id)
        {
            connection = new SqlConnection(conString);
            query = $"select * from Class where StudentId=@i";
            SqlParameter p = new SqlParameter("i", id);
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p);
            connection.Open();
            SqlDataReader d = cmd.ExecuteReader();
            List<int> cid = new List<int>();
            List<string> cann = new List<string>();
            while (d.Read())
            {
                int i = d.GetInt32(2);
                string ann = d.GetValue(1).ToString();

                cid.Add(i);
                cann.Add(ann);
            }
            List<Class> courses = new List<Class>();
            int ind = 0;
            foreach (int i in cid)
            {
                courses.Add(FindCourse(i,cann[ind]));
                ind++;
            }
            connection.Close();
            return courses;
        }
        public Class FindCourse(int id, string ann)
        {
            connection = new SqlConnection(conString);
            query = $"select * from Course where Id=@i";
            SqlParameter p = new SqlParameter("i", id);
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Class c = new Class();

            while (dr.Read())
            {
                c.Id = id;
                c.Announcement = ann;
                c.Name = dr.GetValue(1).ToString();
                c.CreditHours = dr.GetInt32(2);
                c.Instructor=TeacherInfo(dr.GetInt32(3));
            }
            connection.Close();
            return c;
        }
        public Class FindClass(int id)
        {
            connection = new SqlConnection(conString);
            query = $"select * from Class where CourseId=@i";
            SqlParameter p = new SqlParameter("i", id);
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Class c = new Class();
            while (dr.Read())
            {
                c.Id = dr.GetInt32(2);
                c.Announcement = dr.GetValue(1).ToString();
            }
            c = FindCourse(c.Id, c.Announcement);
            connection.Close();
            return c;
        }
        public List<Class> AllCourses()
        {
            connection = new SqlConnection(conString);
            query = $"select * from Class ";
            cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader d = cmd.ExecuteReader();
            List<int> cid = new List<int>();
            List<string> cann = new List<string>();
            while (d.Read())
            {
                int i = d.GetInt32(0);
                string ann = d.GetValue(1).ToString();

                cid.Add(i);
                cann.Add(ann);
            }
            List<Class> courses = new List<Class>();
            int ind = 0;
            foreach (int i in cid)
            {
                courses.Add(FindCourse(i, cann[ind]));
                ind++;
            }
            connection.Close();
            return courses;
        }
        public Teacher TeacherInfo(int id)
        {
            connection = new SqlConnection(conString);
            query = $"select * from Teacher where Id=@i";
            SqlParameter p = new SqlParameter("i", id);
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p);
            connection.Open();
            SqlDataReader d = cmd.ExecuteReader();
            Teacher t = new Teacher();
            while (d.Read())
            {
                t.Id = d.GetInt32(0);
                t.Name = d.GetValue(1).ToString();
                t.Password = d.GetValue(2).ToString();
                t.Degree = d.GetValue(3).ToString();
                t.Address = d.GetValue(4).ToString();
                t.PhoneNo = d.GetValue(5).ToString();

            }
            connection.Close();
            return t;
        }
        public List<Class> AllOfferedCourses()
        {
            connection = new SqlConnection(conString);
            query = $"select Distinct Name,* from Course";
            cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader d = cmd.ExecuteReader();
            List<Class> courses = new List<Class>();
            while (d.Read())
            {
                Class c = new Class();
                c.Id = d.GetInt32(1);
                c.Name = d.GetValue(0).ToString();
                c.Instructor = TeacherInfo(d.GetInt32(3));
                courses.Add(c);
            }
            connection.Close();
            return courses;
        }
        public List<Class> CourseClasses(string c1)
        {
            connection = new SqlConnection(conString);
            query = $"select * from Course where Name=@n";
            SqlParameter p = new SqlParameter("n", c1);
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p);
            connection.Open();
            SqlDataReader d = cmd.ExecuteReader();
            List<Class> courses = new List<Class>();
            while (d.Read())
            {
                Class c = new Class();
                c.Id = d.GetInt32(0);
                c.Name = d.GetValue(1).ToString();
                c.CreditHours = d.GetInt32(2);
                c.Instructor = TeacherInfo(d.GetInt32(3));
                courses.Add(c);
            }
            connection.Close();
            return courses;
        }
        public int FindTeacher(Person u)
        {
            connection = new SqlConnection(conString);
            connection.Open();
            query = $"select * from Teacher where Name=@n and Password=@p";
            SqlParameter p1 = new SqlParameter("n", u.UserId);
            SqlParameter p2 = new SqlParameter("p", u.Password);
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                return dr.GetInt32(0);
            }
            connection.Close();
            return 0;
        }
        public List<Class> TeacherCourses(int id)
        {
            connection = new SqlConnection(conString);
            query = $"select * from Course where TeacherId=@i";
            SqlParameter p = new SqlParameter("i", id);
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p);
            connection.Open();
            SqlDataReader d = cmd.ExecuteReader();
            List<Class> courses = new List<Class>();
            while (d.Read())
            {
                Class c = new Class();
                c.Id = d.GetInt32(0);
                c.Name = d.GetValue(1).ToString();
                c.CreditHours = d.GetInt32(2);
                c.Instructor = TeacherInfo(d.GetInt32(3));
                courses.Add(c);
            }            
            connection.Close();
            return courses;
        }
    }
}
