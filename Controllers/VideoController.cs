using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ULearn.BL.Interface;

namespace ULearn.Controllers
{
    public class VideoController : Controller
    {
        private readonly IVideoRep videoRep;
        private readonly IWashListRep washListRep;

        public VideoController( IVideoRep videoRep, IWashListRep washListRep)
        {
            this.videoRep = videoRep;
            this.washListRep = washListRep;
        }

        public IActionResult Index(int crsId, int stdId)
        {
            var data = videoRep.GetVideosById(crsId, stdId);
            //ViewBag.ViewedCrs = washListRep.GetCrsByWtshListId((int)HttpContext.Session.GetInt32("WashListId"));
            return View(data);
        }


        public IActionResult MyWashedList(int id, int washId)
        {
            var data = washListRep.GetVideoLinkByWashId(id, washId);
            //select all crsid where watchid =5
            return View(data);
        }

        public IActionResult AddtoWatchList(int crsid, int wishid, int videolink)
        {
            var crs = new DataBase.Entites.CrsWhish { CrsId = crsid, WhishId = wishid, VideoLink = videolink };
            washListRep.Insert(crs);
            return Ok();
        }


    }
}
