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
        //public ActionResult Index()
        //{
        //    return CurrentUmbracoPage(); ;
        //}



        [HttpGet]
        public JsonResult Search(string q = null)
        {
            //var umbracoHelper = new UmbracoHelper(UmbracoContext.Current);
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
                text = x.Parent.GetPropertyValue<string>("navigationName") + " - " +
                       x.GetPropertyValue<string>("songName"),
                musician = x.Parent.GetPropertyValue<string>("navigationName"),
                link = x.Url
            })
            .OrderBy(x => x.text)
            .ToList();
            var musiciansResult = musicians.Select(x => new
                {
                    id = x.Id,
                    text = x.GetPropertyValue<string>("navigationName"),
                    musician = x.GetPropertyValue<string>("navigationName"),
                    link = x.Url
                })
                .OrderBy(x => x.text)
                .ToList();

            musiciansResult.AddRange(songsResult);

            //var songsList = GetSongsAsList(songs, q);

            //var musicians = umbracoHelper.ContentAtXPath("//musician");
            //var musiciansList = GetMusiciansAsList(musicians, q);

            //musiciansList.AddRange(songs.ToList());

            //foreach (var musician in musicians)
            //{
            //    var artist = new SearchModel
            //    {
            //        id = musician.Id,
            //        text = musician.navigationName
            //    };
            //    if (artist.text.ToLower().Contains(q.ToLower()))
            //    {
            //        musiciansList.Add(artist);
            //    }
            //}

            //songsList.AddRange(musiciansList);

            return Json(musiciansResult, JsonRequestBehavior.AllowGet);
        }

        //private List<SearchModel> GetSongsAsList(dynamic dynamicItems, string q)
        //{
        //    var items = new List<SearchModel>();
        //    foreach (var item in dynamicItems)
        //    {
        //        var itm = new SearchModel
        //        {
        //            id = item.Id,
        //            text = item.Parent().NavigationName + " - " + item.SongName,
        //            musician = item.Parent().NavigationName,
        //            link = item.Url
        //        };                
        //        items.Add(itm);
        //    }
        //    return items;
        //}

        //private List<SearchModel> GetMusiciansAsList(dynamic dynamicItems, string q)
        //{
        //    var items = new List<SearchModel>();
        //    foreach (var item in dynamicItems)
        //    {
        //        if (!item.NavigationName.ToLower().Contains(q.ToLower())) continue;
        //        var itm = new SearchModel
        //        {
        //            id = item.Id,
        //            text = item.NavigationName,
        //            link = item.Url
        //        };
        //        items.Add(itm);
        //    }
        //    items = items.OrderBy(x => x.text).ToList();
        //    return items;
        //}

    }
}