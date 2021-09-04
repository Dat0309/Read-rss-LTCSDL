using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_VNEXPRESS.Models
{
    public class Publish
    {
        public string Name { get; set; }
        public List<Category> Categories { get; set; }
        public Publish()
        {
            Categories = new List<Category>();
        }

        public bool AddCategory(string name, string link, bool updateIfExist)
        {
            var category = Categories.Find(x => x.Name == Name);
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
            if (updateIfExist)
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
    }
}
