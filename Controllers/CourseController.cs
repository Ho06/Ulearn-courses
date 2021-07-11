using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ULearn.DataBase;
using ULearn.DataBase.Entites;

namespace ULearn.Controllers
{
    public class CourseController : Controller
    {
        //private readonly ICourseRep courseRep;
        //public CourseController
        //    (
        //    ICourseRep courseRep
        //    )
        //{
        //    this.courseRep = courseRep;
        //}

        ////public IActionResult Index(int id)
        ////{

        ////        try
        ////        {
        ////            var data = courseRep.GetById(id);
        ////            //   ViewBag.categoryDetails = data;
        ////            // var model= mapper.Map<CategoryVM>(data);
        ////            return View(data);

        ////        }
        ////        catch (Exception ex)
        ////        {

        ////            throw ex;
        ////        }

        ////}

        private readonly Dbcontainner _context;
        IWebHostEnvironment _webHostEnvironment;
        public CourseController(Dbcontainner context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        [Authorize]
        // GET: Course
        public IActionResult Index()
        {
            var uLearnCourses = _context.Courses.Include(c => c.Ins)
                                                .Include(c => c.Lone)
                                                .Include(c => c.Lthree)
                                                .Include(c => c.Ltwo);
            ViewBag.CoursesCount = uLearnCourses.Count();
            return View(uLearnCourses);
        }


        [Authorize]
        // GET: Course/Create
        public IActionResult Create()
        {
            //ViewData["InsId"] = new SelectList(_context.Instructors, "InsId", "InsId");
            //ViewData["LoneId"] = new SelectList(_context.Levelones, "Id", "Id");
            //ViewData["LthreeId"] = new SelectList(_context.LevelThrees, "Id", "Id");
            //ViewData["LtwoId"] = new SelectList(_context.LevelTwos, "Id", "Id");
            return View();
        }

        // POST: Course/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Duration,Descripton,Price,InsId,LoneId,LtwoId,LthreeId,ImageFile")] Course course)
        {
            if (ModelState.IsValid)
            {
                if (course.ImageFile != null)
                {
                    var ImagePath = SaveImage(course.ImageFile);
                    course.ImagePath = ImagePath;
                }
                _context.Add(course);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //ViewData["InsId"] = new SelectList(_context.Instructors, "InsId", "InsId", course.InsId);
            //ViewData["LoneId"] = new SelectList(_context.Levelones, "Id", "Id", course.LoneId);
            //ViewData["LthreeId"] = new SelectList(_context.LevelThrees, "Id", "Id", course.LthreeId);
            //ViewData["LtwoId"] = new SelectList(_context.LevelTwos, "Id", "Id", course.LtwoId);
            return View(course);
        }
        [Authorize]
        // GET: Course/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            //ViewData["InsId"] = new SelectList(_context.Instructors, "InsId", "InsId", course.InsId);
            //ViewData["LoneId"] = new SelectList(_context.Levelones, "Id", "Id", course.LoneId);
            //ViewData["LthreeId"] = new SelectList(_context.LevelThrees, "Id", "Id", course.LthreeId);
            //ViewData["LtwoId"] = new SelectList(_context.LevelTwos, "Id", "Id", course.LtwoId);
            return View(course);
        }

        // POST: Course/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Duration,Descripton,Price,InsId,LoneId,LtwoId,LthreeId,ImagePath,ImageFile")] Course course)
        {
            if (id != course.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (course.ImageFile != null)
                    {
                        var ImagePath = SaveImage(course.ImageFile);
                        DeleteImage(course.ImagePath);
                        course.ImagePath = ImagePath;
                    }
                    _context.Update(course);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseExists(course.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            //ViewData["InsId"] = new SelectList(_context.Instructors, "InsId", "InsId", course.InsId);
            //ViewData["LoneId"] = new SelectList(_context.Levelones, "Id", "Id", course.LoneId);
            //ViewData["LthreeId"] = new SelectList(_context.LevelThrees, "Id", "Id", course.LthreeId);
            //ViewData["LtwoId"] = new SelectList(_context.LevelTwos, "Id", "Id", course.LtwoId);
            return View(course);
        }
        [Authorize]
        // GET: Course/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .Include(c => c.Ins)
                .Include(c => c.Lone)
                .Include(c => c.Lthree)
                .Include(c => c.Ltwo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }
        [Authorize]
        // POST: Course/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        // GET: Course/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .Include(c => c.Ins)
                .Include(c => c.Lone)
                .Include(c => c.Lthree)
                .Include(c => c.Ltwo)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }
        private bool CourseExists(int id)
        {
            return _context.Courses.Any(e => e.Id == id);
        }
        public string SaveImage(IFormFile Image)
        {
            try
            {
                var FileNameArr = Image.FileName.Split('.');
                var FileType = FileNameArr[FileNameArr.Length - 1];
                var FileName = Guid.NewGuid().ToString() + "." + FileType;
                var FolderPath = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images/Courses");
                var FilePath = Path.Combine(FolderPath, FileName);
                Image.CopyTo(new FileStream(FilePath, FileMode.Create));
                return FileName;
            }
            catch (Exception ex)
            {
                return "";
            }

        }
        public void DeleteImage(string ImageName)
        {
            try
            {
                var FolderPath = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images/Courses");
                var FilePath = Path.Combine(FolderPath, ImageName);
                System.IO.File.Delete(FilePath);
            }
            catch (Exception ex)
            {

            }

        }
    }
}
