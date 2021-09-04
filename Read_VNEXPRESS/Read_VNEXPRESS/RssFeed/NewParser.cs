using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Text.RegularExpressions;

namespace Read_VNEXPRESS.RssFeed
{
    public class NewParser
    {
        public List<Models.Article> ParseXml(string xmlContent)
        {
            var document = new XmlDocument();
            document.LoadXml(xmlContent);

            var articles = new List<Models.Article>();
            var itemNodes = document.SelectNodes("//item");

            foreach (XmlNode node in itemNodes)
            {
                var news = new Models.Article()
                {
                    Title = node.SelectSingleNode("title").InnerText,
                    Description = StripHtml(node.SelectSingleNode("description").InnerText),
                    Link = node.SelectSingleNode("link").InnerText,
                    PubDate = ParseDate(node.SelectSingleNode("pubDate").InnerText)
                };
                articles.Add(news);
            }
            return articles;
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
