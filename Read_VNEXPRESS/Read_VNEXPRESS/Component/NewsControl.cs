using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Read_VNEXPRESS.Component
{
    public partial class NewsControl : UserControl
    {
        public NewsControl()
        {
            InitializeComponent();
        }

        public void SetArticle(Models.Article news)
        {
            lbTitle.Text = news.Title;
            lbDes.Text = news.Description;
            lbDate.Text = news.PubDate.ToString("dd/MM/yyyy HH:mm");
            llb.LinkClicked += (sender, args) =>
            {
                Process.Start(news.Link);
            };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.DrawRectangle(Pens.Black, 0, 1, Width - 1, Height - 2);
        }

    }
}
