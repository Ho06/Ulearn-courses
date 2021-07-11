using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Stripe.BillingPortal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ULearn.BL.Interface;
using ULearn.BL.Repository;
using ULearn.DataBase.Entites;
using ULearn.Models;
using Microsoft.AspNetCore.Http;
using System.Net.Mail;
using ULearn.ViewModels;

namespace ULearn.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMapper mapper;
        private readonly ICourseRep courseRep;
        private readonly IVideoRep videoRep;
        private readonly IStudentRep studentRep;
        private readonly ICategoryRep categoryRep;
        private readonly ILearnCrsRep learnCrsRep;
        private readonly ILearnListRep learnListRep;
        private readonly IWashListRep washListRep;
        private readonly ILogger<HomeController> _logger;
        public HomeController
            (
            IMapper mapper,
            ICourseRep courseRep,
            IVideoRep videoRep,
            IStudentRep studentRep,
            ICategoryRep categoryRep,
            ILearnCrsRep learnCrsRep,
            ILearnListRep learnListRep,
            IWashListRep washListRep,
           

            ILogger<HomeController> logger
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
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult About()
        {
            return RedirectToPage("/about.html");
        }
       [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //[Authorize]
        [HttpGet]
        public IActionResult contact()
        {
            return View();
        }
        //[Authorize]
        [HttpPost]
        public IActionResult contact(ContactViewModel vm)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    MailMessage msz = new MailMessage();
                    msz.From = new MailAddress(vm.Email);//Email which you are getting 
                                                         //from contact us page 
                    msz.To.Add("yor email");//Where mail will be sent 
                    msz.Subject = vm.Subject;
                    msz.Body = vm.Message;
                    SmtpClient smtp = new SmtpClient();

                    smtp.Host = "smtp.gmail.com";

                    smtp.Port = 587;

                    smtp.Credentials = new System.Net.NetworkCredential
                    ("yor email", "yor pass");//from account&& password from account

                    smtp.EnableSsl = true;

                    smtp.Send(msz);

                    ModelState.Clear();
                    ViewBag.Message = "Thank you for Contacting us ";
                }
                catch (Exception ex)
                {
                    ModelState.Clear();
                    ViewBag.Message = $" Sorry we are facing Problem here {ex.Message}";
                }
            }

            return View();
        }


    }
}
