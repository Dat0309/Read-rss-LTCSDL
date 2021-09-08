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

namespace RSS_KQ_XOSO
{
    public partial class Form1 : Form
    {
        private readonly NewFeedManager _newManager;
        public Form1(NewFeedManager newManager)
        {
            InitializeComponent();
            this._newManager = newManager;
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new AddNew(_newManager);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ShowFeedOnTreeView(_newManager.GetNewFeed());
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvQuanLy.SelectedNode == null) return;
            if (tvQuanLy.SelectedNode.Level == 0)
            {
                _newManager.RemovePublish(tvQuanLy.SelectedNode.Text);
            }
            else
            {
                var publishNode = tvQuanLy.SelectedNode.Parent;
                _newManager.RemoveCate(publishNode.Text, tvQuanLy.SelectedNode.Text);
            }
            tvQuanLy.SelectedNode.Remove();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            pnNews.Controls.Clear();

            if (e.Node.Level == 1)
            {
                var lotteries = _newManager.GetNews(e.Node.Parent.Text, e.Node.Text);
                foreach (var lottery in lotteries)
                {
                    var item = new Component.NewControl();
                    item.Size = new Size(519, 101);
                    item.Dock = DockStyle.Top;
                    item.SetLottery(lottery);

                    pnNews.Controls.Add(item);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowFeedOnTreeView(_newManager.GetNewFeed());
        }
        private void ShowFeedOnTreeView(List<Publish> publisher)
        {
            tvQuanLy.Nodes.Clear();
            pnNews.Controls.Clear();

            foreach (var pub in publisher)
            {
                var publisherNode = tvQuanLy.Nodes.Add(pub.Name);
                foreach (var cate in pub.Categories)
                {
                    publisherNode.Nodes.Add(cate.Name);
                }
            }
            tvQuanLy.ExpandAll();
        }

        private void xóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (tvQuanLy.SelectedNode == null) return;
            if (tvQuanLy.SelectedNode.Level == 0)
            {
                _newManager.RemovePublish(tvQuanLy.SelectedNode.Text);
            }
            else
            {
                var publishNode = tvQuanLy.SelectedNode.Parent;
                _newManager.RemoveCate(publishNode.Text, tvQuanLy.SelectedNode.Text);
            }
            tvQuanLy.SelectedNode.Remove();
        }
    }
}
