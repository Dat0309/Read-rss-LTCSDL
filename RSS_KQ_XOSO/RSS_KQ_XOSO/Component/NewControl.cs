using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RSS_KQ_XOSO.Model;
using System.Diagnostics;

namespace RSS_KQ_XOSO.Component
{
    public partial class NewControl : UserControl
    {
        public NewControl()
        {
            InitializeComponent();
        }
        public void SetLottery(Lottery news)
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
