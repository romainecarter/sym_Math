namespace XBuilder
{
    partial class XBuilder
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnLParen = new System.Windows.Forms.Button();
            this.btnRParen = new System.Windows.Forms.Button();
            this.txtFormulaBar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(408, 11);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(71, 27);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Run";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(409, 44);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 27);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(409, 77);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 27);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(11, 91);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(25, 23);
            this.btnPlus.TabIndex = 5;
            this.btnPlus.Text = "+";
            this.btnPlus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(39, 91);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(25, 23);
            this.btnMinus.TabIndex = 6;
            this.btnMinus.Text = "-";
            this.btnMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(68, 91);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(25, 23);
            this.btnDiv.TabIndex = 7;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(97, 91);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(25, 23);
            this.btnMul.TabIndex = 8;
            this.btnMul.Text = "*";
            this.btnMul.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnLParen
            // 
            this.btnLParen.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLParen.Location = new System.Drawing.Point(126, 91);
            this.btnLParen.Name = "btnLParen";
            this.btnLParen.Size = new System.Drawing.Size(25, 23);
            this.btnLParen.TabIndex = 9;
            this.btnLParen.Text = "(";
            this.btnLParen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLParen.UseVisualStyleBackColor = true;
            this.btnLParen.Click += new System.EventHandler(this.btnLParen_Click);
            // 
            // btnRParen
            // 
            this.btnRParen.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRParen.Location = new System.Drawing.Point(155, 91);
            this.btnRParen.Name = "btnRParen";
            this.btnRParen.Size = new System.Drawing.Size(25, 23);
            this.btnRParen.TabIndex = 10;
            this.btnRParen.Text = ")";
            this.btnRParen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRParen.UseVisualStyleBackColor = true;
            this.btnRParen.Click += new System.EventHandler(this.btnRParen_Click);
            // 
            // txtFormulaBar
            // 
            this.txtFormulaBar.HideSelection = false;
            this.txtFormulaBar.Location = new System.Drawing.Point(11, 13);
            this.txtFormulaBar.Multiline = true;
            this.txtFormulaBar.Name = "txtFormulaBar";
            this.txtFormulaBar.Size = new System.Drawing.Size(391, 72);
            this.txtFormulaBar.TabIndex = 14;
            // 
            // XBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.txtFormulaBar);
            this.Controls.Add(this.btnRParen);
            this.Controls.Add(this.btnLParen);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "XBuilder";
            this.Size = new System.Drawing.Size(488, 120);
            this.Load += new System.EventHandler(this.XBuilder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnLParen;
        private System.Windows.Forms.Button btnRParen;
        private System.Windows.Forms.TextBox txtFormulaBar;
    }
}
