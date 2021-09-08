using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSS_KQ_XOSO.Model;

namespace RSS_KQ_XOSO.IO
{
    public interface INewRepo
    {
        List<Publish> GetNews();
        void Save(List<Publish> pub);
    }
}
