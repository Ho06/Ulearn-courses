using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using ULearn.BL.Interface;

namespace ULearn.Controllers
{
    public class CategoryController : Controller
    {

        private readonly IMapper mapper;
        private readonly ICourseRep courseRep;
        private readonly IVideoRep videoRep;
        private readonly IStudentRep studentRep;
        private readonly ICategoryRep categoryRep;
        private readonly ILearnCrsRep learnCrsRep;
        private readonly ILearnListRep learnListRep;
        private readonly IWashListRep washListRep;
        public CategoryController(
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
            try
            {
                ViewBag.category = categoryRep.Get();
            }
            catch (Exception)
            {

                throw;
            }
            return View();
        }



        public IActionResult Details(int id)
        {
            try
            {
                var data = categoryRep.GetById(id);
                //   ViewBag.categoryDetails = data;
                // var model= mapper.Map<CategoryVM>(data);
                return View(data);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
