namespace KakuroUI
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
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.Label();
            this.labelInstuctions = new System.Windows.Forms.Label();
            this.buttonDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(219, 46);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(53, 21);
            this.textBoxWidth.TabIndex = 0;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(219, 86);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(53, 21);
            this.textBoxHeight.TabIndex = 1;
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(178, 49);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(35, 12);
            this.labelWidth.TabIndex = 2;
            this.labelWidth.Text = "Width";
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Location = new System.Drawing.Point(173, 89);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(40, 12);
            this.Height.TabIndex = 3;
            this.Height.Text = "Height";
            // 
            // labelInstuctions
            // 
            this.labelInstuctions.Location = new System.Drawing.Point(12, 62);
            this.labelInstuctions.Name = "labelInstuctions";
            this.labelInstuctions.Size = new System.Drawing.Size(155, 39);
            this.labelInstuctions.TabIndex = 4;
            this.labelInstuctions.Text = "Please enter the width and height of the Kakuro grid.";
            this.labelInstuctions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelInstuctions.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(102, 158);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(75, 23);
            this.buttonDone.TabIndex = 5;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.labelInstuctions);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxWidth);
            this.Name = "Form1";
            this.Text = "Kakuro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.Label labelInstuctions;
        private System.Windows.Forms.Button buttonDone;
    }
}

