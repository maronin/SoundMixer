using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundWiz
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    public class Id
    {
        [JsonProperty("$t")]
        public string t { get; set; }
    }
    public class Updated
    {
        [JsonProperty("$t")]
        public string t { get; set; }
    }
    public class Category
    {
        public string scheme { get; set; }
        public string term { get; set; }
        public string label { get; set; }
    }
    public class Title
    {
        [JsonProperty("$t")]
        public string t { get; set; }
    }
    public class Logo
    {
        [JsonProperty("$t")]
        public string t { get; set; }
    }
    public class Link
    {
        public string rel { get; set; }
        public string type { get; set; }
        public string href { get; set; }
    }
    public class Name
    {
        [JsonProperty("$t")]
        public string t { get; set; }
    }
    public class Generator
    {
        [JsonProperty("$t")]
        public string t { get; set; }
        public string version { get; set; }
        public string uri { get; set; }
    }
    public class OpenSearchTotalResults
    {
        [JsonProperty("$t")]
        public int t { get; set; }
    }
    public class OpenSearchStartIndex
    {
        [JsonProperty("$t")]
        public int t { get; set; }
    }
    public class OpenSearchItemsPerPage
    {
        [JsonProperty("$t")]
        public int t { get; set; }
    }
    public class Published
    {
        [JsonProperty("$t")]
        public string t { get; set; }
    }
    public class Content
    {
        public string type { get; set; }
        public string src { get; set; }
    }

    public class Uri
    {
        [JsonProperty("$t")]
        public string t { get; set; }
    }
    public class YtUserId
    {
        [JsonProperty("$t")]
        public string t { get; set; }
    }
    public class Author
    {
        public Name name { get; set; }
        public Uri uri { get; set; }
        [JsonProperty("$t")]
        public YtUserId ytuserId { get; set; }
    }
    public class YtAccessControl
    {
        public string action { get; set; }
        public string permission { get; set; }
    }
    public class GdFeedLink
    {
        public string rel { get; set; }
        public string href { get; set; }
        public int countHint { get; set; }
    }
    public class GdComments
    {
        [JsonProperty("gd$feedLink")]
        public GdFeedLink gdfeedLink { get; set; }
    }
    public class MediaCategory
    {
        [JsonProperty("$t")]
        public string t { get; set; }
        public string label { get; set; }
        public string scheme { get; set; }
    }
    public class MediaContent
    {
        public string url { get; set; }
        public string type { get; set; }
        public string medium { get; set; }
        public string isDefault { get; set; }
        public string expression { get; set; }
        public int duration { get; set; }
        [JsonProperty("yt$format")]
        public int ytformat { get; set; }
    }
    public class MediaCredit
    {
        [JsonProperty("$t")]
        public string t { get; set; }
        public string role { get; set; }
        public string scheme { get; set; }
        [JsonProperty("yt$display")]
        public string ytdisplay { get; set; }
        [JsonProperty("yt$type")]
        public string yttype { get; set; }
    }
    public class MediaDescription
    {
        [JsonProperty("$t")]
        public string t { get; set; }
        public string type { get; set; }
    }
    public class MediaKeywords
    {
    }
    public class MediaLicense
    {
        [JsonProperty("$t")]
        public string t { get; set; }
        public string type { get; set; }
        public string href { get; set; }
    }
    public class MediaPlayer
    {
        public string url { get; set; }
    }
    public class MediaThumbnail
    {
        public string url { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public string time { get; set; }
        [JsonProperty("yt$name")]
        public string ytname { get; set; }
    }
    public class MediaTitle
    {
        [JsonProperty("$t")]
        public string t { get; set; }
        public string type { get; set; }
    }
    public class YtDuration
    {
        public string seconds { get; set; }
    }
    public class YtUploaded
    {
        [JsonProperty("$t")]
        public string t { get; set; }
    }
    public class YtUploaderId
    {
        [JsonProperty("$t")]
        public string t { get; set; }
    }
    public class YtVideoid
    {
        [JsonProperty("$t")]
        public string t { get; set; }
    }
    public class MediaRestriction
    {
        [JsonProperty("$t")]
        public string t { get; set; }
        public string type { get; set; }
        public string relationship { get; set; }
    }
    public class YtAspectRatio
    {
        [JsonProperty("$t")]
        public string t { get; set; }
    }
    public class MediaGroup
    {
        [JsonProperty("media$category")]
        public List<MediaCategory> mediacategory { get; set; }
        [JsonProperty("media$content")]
        public List<MediaContent> mediacontent { get; set; }
        [JsonProperty("media$credit")]
        public List<MediaCredit> mediacredit { get; set; }
        [JsonProperty("media$description")]
        public MediaDescription mediadescription { get; set; }
        [JsonProperty("media$keywords")]
        public MediaKeywords mediakeywords { get; set; }
        [JsonProperty("media$license")]
        public MediaLicense medialicense { get; set; }
        [JsonProperty("media$player")]
        public MediaPlayer mediaplayer { get; set; }
        [JsonProperty("media$thumbnail")]
        public List<MediaThumbnail> mediathumbnail { get; set; }
        [JsonProperty("media$title")]
        public MediaTitle mediatitle { get; set; }
        [JsonProperty("yt$duration")]
        public YtDuration ytduration { get; set; }
        [JsonProperty("yt$uploaded")]
        public YtUploaded ytuploaded { get; set; }
        [JsonProperty("yt$uploaderId")]
        public YtUploaderId ytuploaderId { get; set; }
        [JsonProperty("yt$videoid")]
        public YtVideoid ytvideoid { get; set; }
        [JsonProperty("media$restriction")]
        public List<MediaRestriction> mediarestriction { get; set; }
        [JsonProperty("yt$aspectRatio")]
        public YtAspectRatio ytaspectRatio { get; set; }
    }
    public class GdRating
    {
        public double average { get; set; }
        public int max { get; set; }
        public int min { get; set; }
        public int numRaters { get; set; }
        public string rel { get; set; }
    }
    public class YtRecorded
    {
        [JsonProperty("$t")]
        public string t { get; set; }
    }
    public class YtStatistics
    {
        public string favoriteCount { get; set; }
        public string viewCount { get; set; }
    }
    public class YtRating
    {
        public string numDislikes { get; set; }
        public string numLikes { get; set; }
    }
    public class YtState
    {
        [JsonProperty("$t")]
        public string t { get; set; }
        public string name { get; set; }
        public string reasonCode { get; set; }
    }
    public class AppControl
    {
        [JsonProperty("yt$state")]
        public YtState ytstate { get; set; }
    }
    public class YtHd
    {
    }
    public class Entry
    {
        public string xmlns { get; set; }

        [JsonProperty("xmlns$media")]
        public string xmlnsmedia { get; set; }

        [JsonProperty("xmlns$gd")]
        public string xmlnsgd { get; set; }

        [JsonProperty("xmlns$yt")]
        public string xmlnsyt { get; set; }

        [JsonProperty("gd$etag")]
        public string gdetag { get; set; }

        public Id id { get; set; }

        public Published published { get; set; }

        public Updated updated { get; set; }

        public List<Category> category { get; set; }

        public Title title { get; set; }

        public Content content { get; set; }

        public List<Link> link { get; set; }

        public List<Author> author { get; set; }

        [JsonProperty("yt$accessControl")]
        public List<YtAccessControl> ytaccessControl { get; set; }

        [JsonProperty("gd$comments")]
        public GdComments gdcomments { get; set; }

        [JsonProperty("yt$hd")]
        public YtHd ythd { get; set; }

        [JsonProperty("media$group")]
        public MediaGroup mediagroup { get; set; }

        [JsonProperty("gd$rating")]
        public GdRating gdrating { get; set; }

        [JsonProperty("yt$recorded")]
        public YtRecorded ytrecorded { get; set; }

        [JsonProperty("yt$statistics")]
        public YtStatistics ytstatistics { get; set; }

        [JsonProperty("yt$rating ")]
        public YtRating ytrating { get; set; }



    }


    public class YouTubeDataFeed
    {
        public string version { get; set; }
        public string encoding { get; set; }
        public Entry entry { get; set; }
    }
}
