using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_VNEXPRESS.Models
{
    public class Category
    {
        public string Name { get; set; }
        public string Link { get; set; }
        public List<Article> Articles { get; set; }

        public Category()
        {
            Articles = new List<Article>();
        }
    }
}
