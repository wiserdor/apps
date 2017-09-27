using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GetMusic.Models;

namespace GetMusic.Controllers
{
    public class SearcherController : Controller
    {
        private Store db = new Store();

        public ActionResult GetParams(string genre, string text)
        {



            switch (genre)
            {
                case "Album":
                    {


                        IEnumerable<Album> list = from Album in db.MyAlbums where Album.Title == text orderby Album.Title select Album;
                        return View("ByAlbum", list);

                    }

                //2-join
                case "Artist":

                    {


                        var list = (from Artist in db.MyArtists
                                    join Album in db.MyAlbums on Artist.Name equals Album.ArtistId
                                    join Track in db.MyTracks on Artist.Name equals Track.ArtistName
                                    select new
                                    {
                                        Artist.Id,
                                        Artist.Name,
                                        Album.Title,
                                        Album.ArtistId,
                                        Album.price,
                                        TrackName = Track.Name,
                                        TrackAlbumName = Track.AlbumName
                                    });

                        List<Searcher> list2 = new List<Searcher>();


                        foreach (var v in list)
                        {
                            //match artist
                            if (v.Name == text && v.TrackAlbumName == v.Title)
                            {
                                {
                                    list2.Add(new Searcher
                                    {
                                        Type = "Artist",
                                        ArtistName = v.ArtistId,
                                        AlbumName = v.Title,
                                        TrackName = v.TrackName


                                    });

                                }



                            }
                            else if (String.IsNullOrEmpty(text) && (v.Title == v.TrackAlbumName || String.IsNullOrEmpty(v.TrackAlbumName)))
                            {
                                list2.Add(new Searcher
                                {
                                    Type = "Artist",
                                    ArtistName = v.ArtistId,
                                    AlbumName = v.Title,
                                    TrackName = v.TrackName


                                });
                            }

                        }
                        return View("ByArtist", list2.ToList());
                    }




                case "Track":
                    {
                        IEnumerable<Track> list = from Track in db.MyTracks where Track.Name == text orderby Track.Name select Track;
                        return View("ByTrack", list);
                    }

                case "Any":
                    {

                        return View("ByAny");
                    }




            }
            return RedirectToAction("Index", "Home");



        }


        private ActionResult ByAlbum(string text)
        {

            IEnumerable<Album> list = from Album in db.MyAlbums where Album.Title == text orderby Album.Title select Album;

            return View(list.ToList());
        }
        private ActionResult ByArtist(string text)
        {



            return View();
        }
        private ActionResult ByTrack(string text)
        {
            return View();
        }
        private ActionResult ByAny(string text)
        {
            return View();
        }

    }
}
