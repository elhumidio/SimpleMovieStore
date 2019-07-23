using System;
using System.Web;
using System.Web.Mvc;
using System.Globalization;
using RestSharp;
using Newtonsoft.Json;
using System.Collections.Generic;
using ClientWebMovieStore.Entities;
using NLog;

namespace ClientWebMovieStore.Controllers
{
    public class HomeController : Controller
    {
        public static Logger log = LogManager.GetCurrentClassLogger();
        private const string UrlLocal = "http://localhost:50961/";
        public ActionResult Index()
        {
            try
            {
                log.Error(string.Format("Start action controller"));
                //Call Web Api, get movies save them in json
                var strUri = string.Format("{0}moviestore/actions/GetAllMovies", UrlLocal).ToLower(CultureInfo.InvariantCulture);
                var uri = new Uri(strUri);
                var uriWithoutScheme = HttpUtility.UrlEncode(string.Format("{0}{1}", uri.Host, uri.PathAndQuery));
                var client = new RestClient(UrlLocal);
                var request = new RestRequest(string.Format("moviestore/actions/GetAllMovies"), Method.GET)
                {
                    RequestFormat = DataFormat.Json
                };
                log.Error(string.Format("Trying to execute"));
                var response = client.Execute(request);
                ViewBag.Movies = JsonConvert.DeserializeObject<List<Pictures>>(response.Content);
                log.Error(string.Format("Everything was just fine..."));
                return View();
            }
            catch (Exception ex)
            {
                log.Error(string.Format("Something went wrong - {0}",ex));
                return View();
            }

            
        }


        


    }
}