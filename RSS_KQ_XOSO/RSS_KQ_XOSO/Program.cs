using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSS_KQ_XOSO
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RssFeed.NewParse parser = new RssFeed.NewParse();
            RssFeed.RssReader rssReader = new RssFeed.RssReader(parser);
            IO.INewRepo repo = new IO.NewRepo();
            var manager = new NewFeedManager(repo, rssReader);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(manager));
        }
    }
}
