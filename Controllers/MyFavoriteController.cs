using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ULearn.BL.Interface;

namespace ULearn.Controllers
{
    public class MyFavoriteController : Controller
    {
        private readonly ILearnCrsRep learnCrsRep;
        private readonly ILearnListRep learnListRep;
        public MyFavoriteController
            (
            ILearnCrsRep learnCrsRep,
            ILearnListRep learnListRep
            )
        {
            this.learnCrsRep = learnCrsRep;
            this.learnListRep = learnListRep;
        }
        public IActionResult Index(int id)
        {
            var data = learnListRep.GetById(id);
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Addfavorite(int courseId, int stdId)
        {
            //var learnId =  5 ;

            var learnId = await learnListRep.GetLearnListIdAsync(stdId);
            foreach (var item in learnId)
            {
                var addtolistItem = new DataBase.Entites.LearnCr() { LearnId = item, CrsId = courseId };
                learnCrsRep.Insert(addtolistItem);
            }
            //var addtolistItem = new DataBase.Entites.LearnCr() { LearnId = learnId, CrsId = courseId };
            //learnCrsRep.Insert(addtolistItem);

            //add item to favorite
            return Ok();
        }




    }
}
