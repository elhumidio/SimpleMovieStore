using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieStore.Entities
{
    public class Categories
    {
       public int Id { get; set; }
       public string Description { get; set; }
    }


    public class Pictures
    {
        public int Id { get; set; }
        public string picture_path { get; set; }
        public string thumbnail_path { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public int? punctuation { get; set; }
    }

    public class PicturesDTO
    {
        public int Id { get; set; }
        public string picture_path { get; set; }
        public string thumbnail_path { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public int? punctuation { get; set; }
    }
}