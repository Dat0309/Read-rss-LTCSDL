using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Read_VNEXPRESS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            RssFeed.NewParser parser = new RssFeed.NewParser();
            RssFeed.RSSReader rssReader = new RssFeed.RSSReader(parser);
            IO.INewRepo repo = new IO.NewRepo();
            var manager = new NewFeedManager(repo, rssReader);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(manager));
        }
    }
}
