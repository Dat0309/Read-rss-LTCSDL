using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Read_VNEXPRESS.Models;

namespace Read_VNEXPRESS.IO
{
    public class NewRepo : INewRepo
    {
        private const string filePath = "data\\data.txt";
        public List<Publish> GetNews()
        {
            throw new NotImplementedException();
        }

        public void Save(List<Publish> pub)
        {
            throw new NotImplementedException();
        }
    }
}
