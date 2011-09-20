namespace driver
{
    partial class frmMain
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
            this.xBuilder1 = new XBuilder.XBuilder();
            this.SuspendLayout();
            // 
            // xBuilder1
            // 
            this.xBuilder1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.xBuilder1.Location = new System.Drawing.Point(0, 0);
            this.xBuilder1.Name = "xBuilder1";
            this.xBuilder1.Size = new System.Drawing.Size(494, 121);
            this.xBuilder1.TabIndex = 0;
            this.xBuilder1.Load += new System.EventHandler(this.xBuilder1_Load);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 121);
            this.Controls.Add(this.xBuilder1);
            this.Name = "frmMain";
            this.Text = "Simple C# Parser";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private XBuilder.XBuilder xBuilder1;
    }
}

