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
    public partial class NewFeesForm : Form
    {
        private readonly NewFeedManager _newManager;
        public bool WasChange { get; set; }
        public NewFeesForm(NewFeedManager newManager)
        {
            InitializeComponent();
            this._newManager = newManager;
        }

        private void NewFeesForm_Load(object sender, EventArgs e)
        {
            var publishers = _newManager.GetNewFeed();
            foreach (var item in publishers)
            {
                cbbOffice.Items.Add(item.Name); 
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var pulishName = cbbOffice.Text;
            var categoryName = txtCateName.Text;
            var link = txtLink.Text;

            if(string.IsNullOrWhiteSpace(pulishName) || string.IsNullOrWhiteSpace(categoryName) || string.IsNullOrWhiteSpace(link))
            {
                MessageBox.Show("Khong duoc bo trong o nao!", "Error");
                return;
            }

            WasChange = true;

            var success = _newManager.AddCategory(pulishName, categoryName, link, false);
            if (success)
            {
                _newManager.SaveChange();
                WasChange = true;
                ClearForm();
                return;
            }

            if (MessageBox.Show("Chuyen muc da ton tai, ban co muon cap nhat khong?", "Thong bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                WasChange = true;
                _newManager.AddCategory(pulishName, categoryName, link, true);
                _newManager.SaveChange();
            }

            ClearForm();
        }
        private void ClearForm()
        {
            cbbOffice.Text = "";
            txtCateName.Text = "";
            txtLink.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
