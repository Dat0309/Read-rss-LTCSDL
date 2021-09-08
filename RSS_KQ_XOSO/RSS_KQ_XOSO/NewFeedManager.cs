using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSS_KQ_XOSO.IO;
using RSS_KQ_XOSO.Model;
using RSS_KQ_XOSO.RssFeed;

namespace RSS_KQ_XOSO
{
    public class NewFeedManager
    {
        private readonly INewRepo _newRepo;
        private List<Publish> _publisher;
        private readonly RssReader _rssReader;

        public NewFeedManager(INewRepo newRepo, RssReader rssReader)
        {
            _newRepo = newRepo;
            _rssReader = rssReader;
        }

        public List<Publish> GetNewFeed()
        {
            if (_publisher == null)
            {
                _publisher = _newRepo.GetNews();
            }
            return _publisher;
        }

        public void SaveChange()
        {
            _newRepo.Save(_publisher);
        }
        public void RemovePublish(string pubName)
        {
            _publisher.RemoveAll(x => x.Name == pubName);
            SaveChange();
        }

        public void RemoveCate(string pubName, string cateName)
        {
            var pub = _publisher.Find(x => x.Name == pubName);
            if (pub == null)
                return;
            pub.RemoveCate(cateName);
            SaveChange();
        }

        public bool AddCategory(string publishName, string categoryName, string link, bool isExists)
        {
            var pub = _publisher.Find(x => x.Name == publishName);
            if (pub == null)
            {
                pub = new Publish()
                {
                    Name = publishName
                };
                _publisher.Add(pub);
            }
            return pub.AddCategory(categoryName, link, isExists);
        }
        public List<Lottery> GetNews(string publishName, string categoryName)
        {
            var publisher = _publisher.Find(x => x.Name == publishName);
            if (publisher == null) return new List<Lottery>();

            var category = publisher.Categories.Find(x => x.Name == categoryName);
            if (category == null) return new List<Lottery>();

            if (category.Lotteries.Count == 0)
            {
                category.Lotteries = _rssReader.GetNews(category.Link);
            }
            return category.Lotteries;
        }
    }
}
