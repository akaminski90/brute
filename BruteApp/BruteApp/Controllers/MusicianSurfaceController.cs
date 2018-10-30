using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using BruteApp.Helpers;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Mvc;

namespace BruteApp.Controllers
{
    public class MusicianSurfaceController : SurfaceController
    {

        [HttpGet]
        public JsonResult Infinite(int count = 0)
        {
            //var start = count;
            var musicians = Umbraco.TypedContentAtXPath("//musician");
            musicians = musicians.OrderBy(x => x.GetPropertyValue("navigationName")).Skip(count).Take(6);
            var str = musicians.Aggregate("", (current, musician) => current + ("<div class='col-sm-6 col-md-4 col-lg-3 col-xl-3 col-xxl-2'><a href='" + musician.Url.ToString() + "' class='musician'><img class='lazy' data-src='" + Url.GetCropUrl(musician, "image", "musicianCropper").ToString() + "'><div class='description'><p>" + musician.GetPropertyValue("navigationName").ToString() + "</p><span>перевод песен</span></div></a></div>"));


            return Json(str, JsonRequestBehavior.AllowGet);
        }

    }
}