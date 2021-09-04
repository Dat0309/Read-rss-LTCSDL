using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Read_VNEXPRESS.IO;

namespace Read_VNEXPRESS
{
    public class NewFeedManager
    {
        private readonly IO.INewRepo _newRepo;
        private List<Models.Publish> _publisher;
        private readonly RssFeed.RSSReader _rssReader;

        public NewFeedManager(INewRepo newRepo, RssFeed.RSSReader rssReader)
        {
            _newRepo = newRepo;
            _rssReader = rssReader;
        }

        public List<Models.Publish> GetNewFeed()
        {
            if(_publisher == null)
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
                pub = new Models.Publish()
                {
                    Name = publishName
                };
                _publisher.Add(pub);
            }
            return pub.AddCategory(categoryName, link, isExists);
        }

        public List<Models.Article> GetNews(string publishName, string categoryName)
        {
            var publisher = _publisher.Find(x => x.Name == publishName);
            if (publisher == null) return new List<Models.Article>();

            var category = publisher.Categories.Find(x => x.Name == categoryName);
            if (category == null) return new List<Models.Article>();

            if(category.Articles.Count == 0)
            {
                category.Articles = _rssReader.GetNews(category.Link);
            }
            return category.Articles;
        }

    }
}
