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
    }
}
