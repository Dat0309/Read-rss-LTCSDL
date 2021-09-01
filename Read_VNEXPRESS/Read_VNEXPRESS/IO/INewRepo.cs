using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_VNEXPRESS.IO
{
    public interface INewRepo
    {
        List<Models.Publish> GetNews();
        void Save(List<Models.Publish> pub);
    }
}
