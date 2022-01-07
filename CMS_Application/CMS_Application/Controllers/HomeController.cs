using CMS_Applicaion.Models;
using CMS_Application.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_Application.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Person u)
        {
            StudentDataObject user = new StudentDataObject();
            Teacher t = new Teacher();
            if (ModelState.IsValid)
            {
                int sid = user.UserFound(u);
                int tid = t.Found(u);
                int id;
                PersonType p;
                if (LoginStrategy.getInstance().Admin.AdminFound(u) > 0)
                {
                    p = PersonType.Admin;
                    id = LoginStrategy.getInstance().Admin.AdminFound(u);
                }
                else if (LoginStrategy.getInstance().Student.StudentFound(u) > 0)
                {
                    p = PersonType.Student;
                    id = LoginStrategy.getInstance().Student.StudentFound(u);
                }
                else if (LoginStrategy.getInstance().Teacher.TeacherFound(u) > 0)
                {
                    p = PersonType.Teacher;
                    id = LoginStrategy.getInstance().Teacher.TeacherFound(u);
                }
                else
                {
                    return View();
                }
                Person h = Singleton.getInstance().GetPersonInfo(p, id);
                return RedirectToAction("HomePage", p.ToString(), h);
            }
            else
            {
                ModelState.AddModelError(String.Empty, "Please enter correct data");
                return View();
            }

        }
    }
}
