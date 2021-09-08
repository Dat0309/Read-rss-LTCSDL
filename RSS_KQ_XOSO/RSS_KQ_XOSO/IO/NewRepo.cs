using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSS_KQ_XOSO.Model;
using System.IO;

namespace RSS_KQ_XOSO.IO
{
    public class NewRepo : INewRepo
    {
        private const string filePath = "Data\\Data.txt";
        public List<Publish> GetNews()
        {
            var publisher = new List<Publish>();
            Publish office = null;
            string line;

            try
            {
                using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new StreamReader(stream))
                    {
                        while (!reader.EndOfStream)
                        {
                            line = reader.ReadLine();
                            if (line == null)
                            {
                                break;
                            }
                            if (line.StartsWith("@"))
                            {
                                office = ParsePublishh(line);
                                publisher.Add(office);
                            }
                            else if (line.StartsWith("#") && office != null)
                            {
                                var category = ParseCate(line);
                                office.Categories.Add(category);
                            }
                        }
                    }
                }
            }
            catch (Exception) { }
            return publisher;
        }

        public void Save(List<Publish> pub)
        {
            using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                using (var sw = new StreamWriter(stream))
                {
                    foreach (var item in pub)
                    {
                        sw.WriteLine("@{0}", item.Name);
                        foreach (var cate in item.Categories)
                        {
                            sw.WriteLine("#{0}^{1}", cate.Name, cate.Link);
                        }
                    }
                }
            }
        }

        #region Thao tac doc file txt
        private Publish ParsePublishh(string line)
        {
            return new Publish()
            {
                Name = line.Substring(1).Trim()
            };
        }
        private Category ParseCate(string line)
        {
            var lines = line.Substring(1).Split('^');
            return new Category()
            {
                Name = lines[0].Trim(),
                Link = lines[1].Trim()
            };
        }
        #endregion
    }
}
