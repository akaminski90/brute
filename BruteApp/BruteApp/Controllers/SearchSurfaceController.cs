using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BruteApp.Helpers;
using BruteApp.Models;
using Umbraco.Core;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using Umbraco.Web.PublishedContentModels;

namespace BruteApp.Controllers
{
    public class SearchSurfaceController : SurfaceController
    {
        [HttpGet]
        public JsonResult Search(string q = null)
        {
            var songs = Umbraco.TypedContentAtXPath("//song");
            var musicians = Umbraco.TypedContentAtXPath("//musician");

            if (!string.IsNullOrEmpty(q))
            {
                q = q.ToLower();
                songs = songs.Where(x => x.GetPropertyValue<string>("songName") != null 
                                         && x.GetPropertyValue<string>("songName").ToLower().Contains(q));
                musicians = musicians.Where(x => x.GetPropertyValue<string>("navigationName") != null
                                                 && x.GetPropertyValue<string>("navigationName").ToLower().Contains(q));                
            }
            var songsResult = songs.Select(x => new
            {
                id = x.Id,
                text = "<b>" + x.Parent.GetPropertyValue<string>("navigationName") + "</b>" + " - " +
                       x.GetPropertyValue<string>("songName"),
                musician = x.Parent.GetPropertyValue<string>("navigationName"),
                link = x.Url
            })
            .Where(x => x.text.ToLower().Contains(q))
            .OrderBy(x => x.text.ToLower().StartsWith(q) ? 0 : 1)
            .ThenBy(x => x.text)
            .Take(10)
            .ToList();
            var musiciansResult = musicians.Select(x => new
                {
                    id = x.Id,
                    text = /*"Группа: " + */"<b>" + x.GetPropertyValue<string>("navigationName") + "</b>",
                    musician = x.GetPropertyValue<string>("navigationName"),
                    link = x.Url
                })
                .Where(x => x.musician.ToLower().Contains(q))
                .OrderBy(x => x.musician.ToLower().StartsWith(q) ? 0 : 1)
                .ThenBy(x => x.musician)
                .Take(5)
                .ToList();

            musiciansResult.AddRange(songsResult);
            return Json(musiciansResult, JsonRequestBehavior.AllowGet);
        }
    }
}