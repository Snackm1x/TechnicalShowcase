
namespace TechnicalShowcase.BLLs
{
    using System;
    using TechnicalShowcase.DALs;

    public class AlbumBLL
    {

        public static void DisplayAlbumPhotos(int id)
        {
            var album = GetAlbumById(id);
            if (album != null)
            {
                Console.WriteLine("Album Id: " + id);
                foreach (var photo in album.Photos)
                {
                    Console.WriteLine("Id: " + photo.Id + " Title: " + photo.Title);
                }
            }
            else
            {
                Console.WriteLine("Sorry an album with Id of " + id + " was not found. The current total number of albums is: " + AlbumLoaderDAL.GetAlbumCount());
            }

        }

        private static AlbumDm GetAlbumById(int id)
        {
            return AlbumLoaderDAL.GetAlbumById(id);
        }
    }
}
