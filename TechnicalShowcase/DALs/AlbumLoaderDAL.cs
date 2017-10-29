

namespace TechnicalShowcase.DALs
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using TechnicalShowcase.Mapper;

    public static class AlbumLoaderDAL
    {
        private static List<AlbumDm> AlbumList = new List<AlbumDm>();

        private static string URL = "https://jsonplaceholder.typicode.com/photos";

        public static  List<AlbumDm> LoadAlbums()
        {
            using (var webClient = new WebClient())
            {
                var json = webClient.DownloadString(URL);
                var reader = new JsonTextReader(new StringReader(json));
                var currentAlbumId = 0;
                while (reader.Read())
                {
                    if (reader.TokenType == JsonToken.StartObject)
                    {
                        var obj = JObject.Load(reader);
                        if (currentAlbumId != Convert.ToInt32(obj["albumId"]))
                        {
                            var album = new AlbumDm
                            {
                                AlbumId = Convert.ToInt32(obj["albumId"]),
                                Photos = new List<PhotoDm>()
                            };

                            AlbumList.Add(album);

                            currentAlbumId = Convert.ToInt32(obj["albumId"]);

                            var photo = PhotoMapper.Map(obj);
                            AlbumList[AlbumList.Count - 1].Photos.Add(photo);
                        }
                        else
                        {
                            var photo = PhotoMapper.Map(obj);
                            AlbumList[AlbumList.Count - 1].Photos.Add(photo);
                        }
                    }
                }
            }
            return AlbumList;
        }

        public static AlbumDm GetAlbumById(int id)
        {
            return AlbumList.Where(a => a.AlbumId == id).FirstOrDefault();
        }

        public static int GetAlbumCount()
        {
            return AlbumList.Count;
        }
    }
}
