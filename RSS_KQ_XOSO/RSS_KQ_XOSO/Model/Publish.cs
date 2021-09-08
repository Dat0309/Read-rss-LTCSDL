using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSS_KQ_XOSO.Model
{
    public class Publish
    {
        public string Name { get; set; }
        public List<Category> Categories { get; set; }

        public Publish()
        {
            Categories = new List<Category>();
        }
        #region Ham thao tac voi Category
        public bool AddCategory(string name, string link, bool isExist)
        {
            var category = Categories.Find(x => x.Name == name);
            if(category == null)
            {
                category = new Category()
                {
                    Name = name,
                    Link = link
                };
                Categories.Add(category);
                return true;
            }
            if (isExist)
            {
                category.Link = link;
                return true;
            }
            return false;
        }

        public void RemoveCate(string name)
        {
            Categories.RemoveAll(x => x.Name == name);
        }

        #endregion
    }
}
