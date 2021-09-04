using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Read_VNEXPRESS.RssFeed
{
    public class RSSReader
    {
        private readonly RssFeed.NewParser _parser;

        public RSSReader(NewParser parser)
        {
            this._parser = parser;
        }

        public List<Models.Article> GetNews(string rssLink)
        {
            var feedData = DownloadFeed(rssLink);
            return _parser.ParseXml(feedData);
        }

        private string DownloadFeed(string rssLink)
        {
            var client = new WebClient()
            {
                Encoding = Encoding.UTF8
            };
            return client.DownloadString(rssLink);
        }
    }
}
