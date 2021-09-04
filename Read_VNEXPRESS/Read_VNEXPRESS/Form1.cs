using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Read_VNEXPRESS
{
    public partial class Form1 : Form
    {
        private readonly NewFeedManager _newManager;

        public Form1(NewFeedManager newManager)
        {
            InitializeComponent();
            this._newManager = newManager;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            pnNews.Controls.Clear();

            if(e.Node.Level == 1)
            {
                var articles = _newManager.GetNews(e.Node.Parent.Text, e.Node.Text);
                foreach (var article in articles)
                {
                    var item = new Component.NewsControl();
                    item.Size = new Size(519, 101);
                    item.Dock = DockStyle.Top;
                    item.SetArticle(article);

                    pnNews.Controls.Add(item);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowFeedOnTreeView(_newManager.GetNewFeed());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dialog = new NewFeesForm(_newManager);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //_newManager.SaveChange();
                ShowFeedOnTreeView(_newManager.GetNewFeed());
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (tvPubLish.SelectedNode == null) return;
            if(tvPubLish.SelectedNode.Level == 0)
            {
                _newManager.RemovePublish(tvPubLish.SelectedNode.Text);
            }
            else
            {
                var publishNode = tvPubLish.SelectedNode.Parent;
                _newManager.RemoveCate(publishNode.Text, tvPubLish.SelectedNode.Text);
            }
            tvPubLish.SelectedNode.Remove();
        }

        private void ShowFeedOnTreeView(List<Models.Publish> publisher)
        {
            tvPubLish.Nodes.Clear();
            pnNews.Controls.Clear();

            foreach (var pub in publisher)
            {
                var publisherNode = tvPubLish.Nodes.Add(pub.Name);
                foreach (var cate in pub.Categories)
                {
                    publisherNode.Nodes.Add(cate.Name);
                }
            }
            tvPubLish.ExpandAll();
        }
    }
}
