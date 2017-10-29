
namespace AlbumTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Linq;
    using TechnicalShowcase.DALs;

    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void VerifyAlbumsLoad()
        {
            var albumList = AlbumLoaderDAL.LoadAlbums();

            Assert.IsNotNull(albumList, "Album list failed to load correctly");
        }

        [TestMethod]
        public void VerifyGetSingleAlbum()
        {
            var id = 10;
            AlbumLoaderDAL.LoadAlbums();

            var album = AlbumLoaderDAL.GetAlbumById(id);

            Assert.AreEqual(id, album.AlbumId, "Album Ids do not match!");
        }

        [TestMethod]
        public void VerifyOutofBoundsAlbum()
        {
            var id = 101;
            AlbumLoaderDAL.LoadAlbums();

            var album = AlbumLoaderDAL.GetAlbumById(id);

            Assert.IsNull(album, "This should be null, we only have 100 albums and an error gets displayed to user!");
        }

        [TestMethod]
        public void VerifyAlbumPhoto()
        {
            var id = 3;

            var expectedId = 101;
            var expectedTitle = "incidunt alias vel enim";

            AlbumLoaderDAL.LoadAlbums();

            var album = AlbumLoaderDAL.GetAlbumById(id);
            var photo = album.Photos.Where(p => p.Id == expectedId).FirstOrDefault();

            var actualId = photo.Id;
            var actualTitle = photo.Title;

            Assert.AreEqual(expectedId, actualId, "Ids do not match!");
            Assert.AreEqual(expectedTitle, actualTitle, "Titles do not match!");
        }
    }
}
