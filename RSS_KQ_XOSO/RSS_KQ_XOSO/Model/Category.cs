using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSS_KQ_XOSO.Model
{
    public class Category
    {
        public string Name { get; set; }
        public string Link { get; set; }
        public List<Lottery> Lotteries { get; set; }

        public Category()
        {
            Lotteries = new List<Lottery>();
        }
    }
}
