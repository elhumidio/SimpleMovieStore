using MovieStore.Entities;
using System.Collections.Generic;


namespace MovieStore.MockData
{
    public class MockData
    {

        public List<PicturesDTO> GetMovies()
        {
               Categories c = new Categories {
                Description = "Horror",
                Id = 0
            };
              List<Categories> listaCategorias = new List<Categories>();
              PicturesDTO p = new PicturesDTO
              {
                  category = "Action",
                  Id = 0,
                  picture_path = "../Content/Pictures/ironman1.jpg",
                  thumbnail_path = "../Content/ThumbNails/ironman1Icon.png",
                  title = "Iron Man 1",
                  description = "A great movie about a men in an armor",
                  punctuation = 4

              };

              PicturesDTO p1 = new PicturesDTO
              {
                  category = "Drama",
                  Id = 1,
                  picture_path = "../Content/Pictures/thegodfather.jpg",
                  thumbnail_path = "../Content/ThumbNails/thegodfather.png",
                  title = "The Godfather",
                  description = "A movie of big mobster boss",
                  punctuation = 5

              };

              PicturesDTO p2 = new PicturesDTO
              {
                  category = "Comedy",
                  Id = 2,
                  picture_path = "../Content/Pictures/scary2.jpg",
                  thumbnail_path = "../Content/ThumbNails/scaryIcon.png",
                  title = "Scary Movie 2",
                  description = "The horror in the whole sense of the word",
                  punctuation = 1

              };
              PicturesDTO p3 = new PicturesDTO
              {
                  category = "Action",
                  Id = 3,
                  picture_path = "../Content/Pictures/ironman2.jpg",
                  thumbnail_path = "../Content/ThumbNails/Ironman2Icon.png",
                  title = "iron Man 2",
                  description = "The secuel of the men in the armor",
                  punctuation = 5

              };
              PicturesDTO p4 = new PicturesDTO
              {
                  category = "Action",
                  Id = 4,
                  picture_path = "../Content/Pictures/venom.jpg",
                  thumbnail_path = "../Content/ThumbNails/venom.jpg",
                  title = "Venom",
                  description = "A venom actually",
                  punctuation = 3

              };
              PicturesDTO p5 = new PicturesDTO
              {
                  category = "Drama",
                  Id = 5,
                  picture_path = "../Content/Pictures/shawshank.jpg",
                  thumbnail_path = "../Content/ThumbNails/The-Shawshank-Redemption-icon.png",
                  title = "Shawshank redemption",
                  description = "A great story about a men unfairly imprisoned",
                  punctuation = 5

              };

            List<PicturesDTO> pictures = new List<PicturesDTO>();
              pictures.Add(p);
              pictures.Add(p1);
              pictures.Add(p2);
              pictures.Add(p3);
              pictures.Add(p4);
              pictures.Add(p5);
              return pictures;
        }


    }
}