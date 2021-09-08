
namespace RSS_KQ_XOSO.Component
{
    partial class NewControl
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
            this.llb = new System.Windows.Forms.LinkLabel();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbDes = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // llb
            // 
            this.llb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llb.AutoSize = true;
            this.llb.Location = new System.Drawing.Point(711, 69);
            this.llb.Name = "llb";
            this.llb.Size = new System.Drawing.Size(39, 13);
            this.llb.TabIndex = 7;
            this.llb.TabStop = true;
            this.llb.Text = "Chi tiet";
            // 
            // lbDate
            // 
            this.lbDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(6, 69);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(35, 13);
            this.lbDate.TabIndex = 6;
            this.lbDate.Text = "label3";
            // 
            // lbDes
            // 
            this.lbDes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDes.Location = new System.Drawing.Point(6, 28);
            this.lbDes.Name = "lbDes";
            this.lbDes.Size = new System.Drawing.Size(767, 41);
            this.lbDes.TabIndex = 5;
            this.lbDes.Text = "label2";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoEllipsis = true;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbTitle.Location = new System.Drawing.Point(3, 11);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(41, 13);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "label1";
            // 
            // NewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.llb);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbDes);
            this.Controls.Add(this.lbTitle);
            this.Name = "NewControl";
            this.Size = new System.Drawing.Size(770, 107);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llb;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbDes;
        private System.Windows.Forms.Label lbTitle;
    }
}
