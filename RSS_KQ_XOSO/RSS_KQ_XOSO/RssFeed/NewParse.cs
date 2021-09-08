using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSS_KQ_XOSO.Model;
using System.Xml;
using System.Text.RegularExpressions;

namespace RSS_KQ_XOSO.RssFeed
{
    public class NewParse
    {
        public List<Lottery> ParseXml(string xmlContent)
        {
            var document = new XmlDocument();
            document.LoadXml(xmlContent);

            var lottery = new List<Lottery>();
            var itemNodes = document.SelectNodes("//item");

            foreach (XmlNode node in itemNodes)
            {
                var news = new Lottery()
                {
                    Title = node.SelectSingleNode("title").InnerText,
                    Description = StripHtml(node.SelectSingleNode("description").InnerText),
                    Link = node.SelectSingleNode("link").InnerText,
                    PubDate = ParseDate(node.SelectSingleNode("pubDate").InnerText)
                };
                lottery.Add(news);
            }
            return lottery;
        }
        private string StripHtml(string content)
        {
            return Regex.Replace(content, "<.*?>", String.Empty).Trim();
        }

        private DateTime ParseDate(string dateStr)
        {
            try
            {
                return DateTime.Parse(dateStr);
            }
            catch (Exception)
            {

                return DateTime.Now;
            }
        }
    }
}
