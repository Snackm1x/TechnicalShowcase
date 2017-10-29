
namespace TechnicalShowcase.Mapper
{
    using Newtonsoft.Json.Linq;
    using System;

    public static class PhotoMapper
    {
        public static PhotoDm Map(JObject obj)
        {
            var photo = new PhotoDm
            {
                Id = Convert.ToInt32(obj["id"]),
                Title = obj["title"].ToString(),
                Url = obj["url"].ToString(),
                ThumbnailUrl = obj["thumbnailUrl"].ToString()
            };
            return photo;
        }
    }
}
