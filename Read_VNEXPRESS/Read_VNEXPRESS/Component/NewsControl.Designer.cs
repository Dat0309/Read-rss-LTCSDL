
namespace Read_VNEXPRESS.Component
{
    partial class NewsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbDes = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.llb = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoEllipsis = true;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbTitle.Location = new System.Drawing.Point(16, 12);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(41, 13);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "label1";
            // 
            // lbDes
            // 
            this.lbDes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDes.Location = new System.Drawing.Point(19, 29);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(516, 41);
            this.lbDes.TabIndex = 1;
            this.lbDes.Text = "label2";
            // 
            // lbDate
            // 
            this.lbDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(19, 70);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(35, 13);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "label3";
            // 
            // llb
            // 
            this.llb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llb.AutoSize = true;
            this.llb.Location = new System.Drawing.Point(473, 70);
            this.llb.Name = "llb";
            this.llb.Size = new System.Drawing.Size(39, 13);
            this.llb.TabIndex = 3;
            this.llb.TabStop = true;
            this.llb.Text = "Chi tiet";
            // 
            // NewsControl
            // 
            this.Controls.Add(this.llb);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbDes);
            this.Controls.Add(this.lbTitle);
            this.Name = "NewsControl";
            this.Size = new System.Drawing.Size(556, 127);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbDetail;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.LinkLabel llbLink;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbDes;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.LinkLabel llb;
    }
}
