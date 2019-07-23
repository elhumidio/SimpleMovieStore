using Newtonsoft.Json;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MovieStore
{
    public class DataAccess
    {
        public static Logger log = LogManager.GetCurrentClassLogger();
        public dynamic GetPictures()
        {
            log.Error(string.Format("Starting retrieving data"));
            try {
                //testEntities ctx = new testEntities();
                using (testEntities ctx = new testEntities()) {
                    var pictureList = (from p in ctx.pictures
                                       join cat in ctx.categories on p.idcategory equals cat.Id
                                       select new
                                       {
                                           p.Id,
                                           p.picture_path,
                                           p.thumbnail_path,
                                           p.title,
                                           p.description,
                                           category = cat.description,
                                           p.punctuation
                                       }).ToList();
                    log.Error(string.Format("Everything was just fine..."));
                    return JsonConvert.SerializeObject(pictureList);
                }
                  
            }
            catch (Exception ex) {
                log.Error(string.Format("Something went wrong {0}", ex));
                return null;
            }


        }

    }
}