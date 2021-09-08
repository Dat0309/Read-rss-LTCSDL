using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSS_KQ_XOSO.Model;
using System.Net;

namespace RSS_KQ_XOSO.RssFeed
{
    public class RssReader
    {
        private readonly NewParse _parser;

        public RssReader(NewParse parser)
        {
            this._parser = parser;
        }

        public List<Lottery> GetNews(string rssLink)
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
