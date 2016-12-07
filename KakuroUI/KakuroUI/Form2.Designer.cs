namespace KakuroUI
{
    partial class KakuroGridView
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
            this.labelGridInstructions = new System.Windows.Forms.Label();
            this.buttonGrid = new System.Windows.Forms.Button();
            this.labelLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelGridInstructions
            // 
            this.labelGridInstructions.AutoSize = true;
            this.labelGridInstructions.Location = new System.Drawing.Point(12, 9);
            this.labelGridInstructions.Name = "labelGridInstructions";
            this.labelGridInstructions.Size = new System.Drawing.Size(250, 12);
            this.labelGridInstructions.TabIndex = 0;
            this.labelGridInstructions.Text = "Enter in the black spaces and totals below.";
            // 
            // buttonGrid
            // 
            this.buttonGrid.Location = new System.Drawing.Point(268, 4);
            this.buttonGrid.Name = "buttonGrid";
            this.buttonGrid.Size = new System.Drawing.Size(75, 23);
            this.buttonGrid.TabIndex = 2;
            this.buttonGrid.Text = "Done";
            this.buttonGrid.UseVisualStyleBackColor = true;
            this.buttonGrid.Click += new System.EventHandler(this.buttonGrid_Click);
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(297, 34);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(22, 12);
            this.labelLog.TabIndex = 3;
            this.labelLog.Text = "log";
            // 
            // KakuroGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 55);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.buttonGrid);
            this.Controls.Add(this.labelGridInstructions);
            this.Name = "KakuroGridView";
            this.Text = "Kakuro";
            this.Load += new System.EventHandler(this.KakuroGridView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGridInstructions;
        private System.Windows.Forms.Button buttonGrid;
        private System.Windows.Forms.Label labelLog;
    }
}