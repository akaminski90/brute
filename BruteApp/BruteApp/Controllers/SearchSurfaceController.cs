using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BruteApp.Helpers;
using BruteApp.Models;
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
        public JsonResult Search(string query = null)
        {
            //var umbracoHelper = new UmbracoHelper(UmbracoContext.Current);
            //var songs = umbracoHelper.ContentAtXPath("//song");

            //var songsList = new List<SearchModel>();

            //foreach (var song in songs)
            //{
            //    var sng = new SearchModel
            //    {
            //        id = song.Id,
            //        musician = song.Parent.NavigationName.ToString(),
            //        name = song.SongName,
            //        entityType = 1
            //    };
            //    songsList.Add(sng);
            //}

            //var musicians = umbracoHelper.ContentAtXPath("//musician");
            //var musiciansList = new List<SearchModel>();

            //foreach (var musician in musicians)
            //{
            //    var artist = new SearchModel
            //    {
            //        id = musician.Id,
            //        musician = musician.navigationName,
            //        name = musician.navigationName,
            //        entityType = 0
            //    };
            //    musiciansList.Add(artist);
            //}

            //songsList.AddRange(musiciansList);

            var search = new SearchModel
            {
                id = 0,
                text = "a"
            };
            var search1 = new SearchModel
            {
                id = 1,
                text = "b"
            };
            var search2 = new SearchModel
            {
                id = 2,
                text = "c"
            };
            var search3 = new SearchModel
            {
                id = 3,
                text = "d"
            };
            var search4 = new SearchModel
            {
                id = 4,
                text = "e"
            };
            var search5 = new SearchModel
            {
                id = 5,
                text = "f"
            }; var search6 = new SearchModel
            {
                id = 6,
                text = "font"
            };
            var list = new List<SearchModel>
            {
                search,
                search1,
                search2,
                search3,
                search4,
                search5,
                search6
            };

            return Json(list.ToArray(), JsonRequestBehavior.AllowGet);
            //return Json(songsList, JsonRequestBehavior.AllowGet);
        }

        private List<SearchModel> GetSongsAsList(dynamic dynamicItems)
        {
            var items = new List<SearchModel>();
            foreach (var item in dynamicItems)
            {
                var itm = new SearchModel
                {
                    id = item.Id,
                    text = item.NavigationName
                };
                items.Add(itm);
            }
            items = items.OrderBy(x => x.text).ToList();
            return items;
        }

    }
}