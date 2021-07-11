using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ULearn.BL.Interface;

namespace ULearn.Controllers
{
    public class StudentController : Controller
    {
        private readonly IMapper mapper;
        private readonly ICourseRep courseRep;
        private readonly IVideoRep videoRep;
        private readonly IStudentRep studentRep;
        private readonly ICategoryRep categoryRep;
        private readonly ILearnCrsRep learnCrsRep;
        private readonly ILearnListRep learnListRep;
        private readonly IWashListRep washListRep;
        public StudentController(
            IMapper mapper,
            ICourseRep courseRep,
            IVideoRep videoRep,
            IStudentRep studentRep,
            ICategoryRep categoryRep,
            ILearnCrsRep learnCrsRep,
            ILearnListRep learnListRep,
            IWashListRep washListRep
            )
        {
            this.mapper = mapper;
            this.courseRep = courseRep;
            this.videoRep = videoRep;
            this.studentRep = studentRep;
            this.categoryRep = categoryRep;
            this.learnCrsRep = learnCrsRep;
            this.learnListRep = learnListRep;
            this.washListRep = washListRep;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StudentSignIn()
        {

            return View();
        }

        [HttpPost]
        public IActionResult StudentSignIn(DataBase.Entites.Student model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var student = studentRep.GetByEmail(model);
                    if (student == null)
                    {
                        ModelState.AddModelError(string.Empty, "UserName not Valid");
                    }
                    else if (student != null && model.Pass != student.Pass)
                    {
                        ModelState.AddModelError(string.Empty, "Password not Valid ");

                    }
                    else
                    {
                        HttpContext.Session.SetString("StdEmail", student.Email);
                        HttpContext.Session.SetString("StdId", student.Id.ToString());
                        var Watchid = studentRep.GetWashListId(student.Id);
                        HttpContext.Session.SetInt32("WashListId", Watchid);
                        return RedirectToAction("Index", "Category");
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            }
            return View();
        }



        public IActionResult StudentSignOut()
        {
            //HttpContext.Session.SetString("StdEmail",null);
            HttpContext.Session.Remove("StdId");
            HttpContext.Session.Remove("StdEmail");
            HttpContext.Session.Remove("WashListId");
            return RedirectToAction("Index","Home");
        }
    }
}
