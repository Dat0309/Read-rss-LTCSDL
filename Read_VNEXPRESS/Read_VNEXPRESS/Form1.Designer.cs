
namespace Read_VNEXPRESS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tvPubLish = new System.Windows.Forms.TreeView();
            this.pnNews = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tvPubLish
            // 
            this.tvPubLish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvPubLish.Location = new System.Drawing.Point(12, 59);
            this.tvPubLish.Name = "tvPubLish";
            this.tvPubLish.Size = new System.Drawing.Size(214, 379);
            this.tvPubLish.TabIndex = 0;
            this.tvPubLish.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // pnNews
            // 
            this.pnNews.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnNews.Location = new System.Drawing.Point(232, 59);
            this.pnNews.Name = "pnNews";
            this.pnNews.Size = new System.Drawing.Size(556, 379);
            this.pnNews.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnNews);
            this.Controls.Add(this.tvPubLish);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvPubLish;
        private System.Windows.Forms.Panel pnNews;
    }
}

