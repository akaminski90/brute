using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using BruteApp.Models;
using Umbraco.Web.Mvc;
using Umbraco.Web.PublishedContentModels;

namespace BruteApp.Controllers
{
    public class GetSongsController : SurfaceController
    {
        [HttpGet]
        private List<SearchModel> GetSongsAsList(dynamic dynamicSongs)
        {
            var songs = new List<SearchModel>();
            foreach (var song in dynamicSongs)
            {
                var sng = new SearchModel
                {
                    text = song.NavigationName,
                    id = song.Id
                };
                songs.Add(sng);
            }
            return songs;
        }
    }
}