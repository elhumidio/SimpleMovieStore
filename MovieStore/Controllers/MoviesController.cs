using MovieStore.Entities;
using Newtonsoft.Json;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Configuration;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace MovieStore.Controllers
{
    [System.Web.Http.Authorize]
    public class MoviesController : ApiController
    {

        public static Logger log = LogManager.GetCurrentClassLogger();
        // GET api/values
        [System.Web.Http.AllowAnonymous]
        [System.Web.Http.Route("moviestore/actions/GetAllMovies"), System.Web.Http.HttpGet]
        public HttpResponseMessage GetAllMovies()
        {
            log.Error(string.Format("Start action controller"));
            List<PicturesDTO> list = new List<PicturesDTO>();
            try {

                if (WebConfigurationManager.AppSettings["dataOrigen"].ToString() == "DB")
                {
                    log.Error(string.Format("getting data from DB"));
                    var data = new DataAccess();
                    list = JsonConvert.DeserializeObject<List<PicturesDTO>>(data.GetPictures());
                    return Request.CreateResponse(HttpStatusCode.OK, list);
                }
                else
                {
                    log.Error(string.Format("getting mock data"));
                    var data = new MockData.MockData();
                    list = data.GetMovies();
                    log.Error(string.Format("Everything was just fine..."));
                    return Request.CreateResponse(HttpStatusCode.OK, list);
                }


            }

            catch (Exception ex) {
                log.Error(string.Format("Something went wrong {0}",ex));
                return Request.CreateResponse(HttpStatusCode.InternalServerError, list);
            }
            
        }


        
     
    }
}
