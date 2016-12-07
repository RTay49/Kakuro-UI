namespace KakuroUI
{
    partial class kakuroSquare
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
            this.entrybackground = new System.Windows.Forms.PictureBox();
            this.labelpos = new System.Windows.Forms.Label();
            this.labelTablePos = new System.Windows.Forms.Label();
            this.entryTR = new System.Windows.Forms.TextBox();
            this.entryBL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.entrybackground)).BeginInit();
            this.SuspendLayout();
            // 
            // entrybackground
            // 
            this.entrybackground.Image = global::KakuroUI.Properties.Resources.kakurobackgroundsquare;
            this.entrybackground.Location = new System.Drawing.Point(0, -4);
            this.entrybackground.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.entrybackground.Name = "entrybackground";
            this.entrybackground.Size = new System.Drawing.Size(57, 62);
            this.entrybackground.TabIndex = 0;
            this.entrybackground.TabStop = false;
            this.entrybackground.Visible = false;
            this.entrybackground.Click += new System.EventHandler(this.entrybackground_Click);
            // 
            // labelpos
            // 
            this.labelpos.AutoSize = true;
            this.labelpos.ForeColor = System.Drawing.Color.Red;
            this.labelpos.Location = new System.Drawing.Point(-3, 41);
            this.labelpos.Name = "labelpos";
            this.labelpos.Size = new System.Drawing.Size(62, 15);
            this.labelpos.TabIndex = 3;
            this.labelpos.Text = "labelpos";
            // 
            // labelTablePos
            // 
            this.labelTablePos.AutoSize = true;
            this.labelTablePos.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelTablePos.Location = new System.Drawing.Point(-3, 5);
            this.labelTablePos.Name = "labelTablePos";
            this.labelTablePos.Size = new System.Drawing.Size(69, 15);
            this.labelTablePos.TabIndex = 4;
            this.labelTablePos.Text = "TablePos";
            // 
            // entryTR
            // 
            this.entryTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.entryTR.Font = new System.Drawing.Font("Gulim", 9F);
            this.entryTR.Location = new System.Drawing.Point(31, 1);
            this.entryTR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.entryTR.MaxLength = 3;
            this.entryTR.Name = "entryTR";
            this.entryTR.Size = new System.Drawing.Size(23, 21);
            this.entryTR.TabIndex = 2;
            this.entryTR.Visible = false;
            // 
            // entryBL
            // 
            this.entryBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.entryBL.Font = new System.Drawing.Font("Gulim", 9F);
            this.entryBL.Location = new System.Drawing.Point(3, 30);
            this.entryBL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.entryBL.Name = "entryBL";
            this.entryBL.Size = new System.Drawing.Size(23, 21);
            this.entryBL.TabIndex = 1;
            this.entryBL.TabStop = false;
            this.entryBL.Visible = false;
            this.entryBL.TextChanged += new System.EventHandler(this.entryBL_TextChanged);
            // 
            // kakuroSquare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.entryTR);
            this.Controls.Add(this.entryBL);
            this.Controls.Add(this.entrybackground);
            this.Controls.Add(this.labelpos);
            this.Controls.Add(this.labelTablePos);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "kakuroSquare";
            this.Size = new System.Drawing.Size(57, 62);
            this.Click += new System.EventHandler(this.kakuroSquare_Click);
            ((System.ComponentModel.ISupportInitialize)(this.entrybackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox entrybackground;
        private System.Windows.Forms.Label labelpos;
        private System.Windows.Forms.Label labelTablePos;
        private System.Windows.Forms.TextBox entryTR;
        private System.Windows.Forms.TextBox entryBL;
    }
}
