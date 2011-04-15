namespace Guess
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.bnBu = new System.Windows.Forms.Button();
            this.bnSsc = new System.Windows.Forms.Button();
            this.bnHmm = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.bnAg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbPc = new System.Windows.Forms.PictureBox();
            this.pbHum = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // bnBu
            // 
            this.bnBu.Location = new System.Drawing.Point(29, 113);
            this.bnBu.Name = "bnBu";
            this.bnBu.Size = new System.Drawing.Size(46, 20);
            this.bnBu.TabIndex = 1;
            this.bnBu.Text = "包袱";
            this.bnBu.Click += new System.EventHandler(this.bnBu_Click);
            // 
            // bnSsc
            // 
            this.bnSsc.Location = new System.Drawing.Point(98, 113);
            this.bnSsc.Name = "bnSsc";
            this.bnSsc.Size = new System.Drawing.Size(41, 20);
            this.bnSsc.TabIndex = 2;
            this.bnSsc.Text = "剪子";
            this.bnSsc.Click += new System.EventHandler(this.bnSsc_Click);
            // 
            // bnHmm
            // 
            this.bnHmm.Location = new System.Drawing.Point(166, 113);
            this.bnHmm.Name = "bnHmm";
            this.bnHmm.Size = new System.Drawing.Size(42, 20);
            this.bnHmm.TabIndex = 3;
            this.bnHmm.Text = "锤";
            this.bnHmm.Click += new System.EventHandler(this.bnHmm_Click);
            // 
            // lbResult
            // 
            this.lbResult.Location = new System.Drawing.Point(79, 190);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(138, 20);
            this.lbResult.Visible = false;
            // 
            // bnAg
            // 
            this.bnAg.Location = new System.Drawing.Point(79, 236);
            this.bnAg.Name = "bnAg";
            this.bnAg.Size = new System.Drawing.Size(72, 20);
            this.bnAg.TabIndex = 5;
            this.bnAg.Text = "再来";
            this.bnAg.Visible = false;
            this.bnAg.Click += new System.EventHandler(this.bnAg_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(98, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.Text = "VS";
            // 
            // pbPc
            // 
            this.pbPc.Location = new System.Drawing.Point(24, 43);
            this.pbPc.Name = "pbPc";
            this.pbPc.Size = new System.Drawing.Size(51, 50);
            // 
            // pbHum
            // 
            this.pbHum.Location = new System.Drawing.Point(158, 43);
            this.pbHum.Name = "pbHum";
            this.pbHum.Size = new System.Drawing.Size(59, 50);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.pbHum);
            this.Controls.Add(this.pbPc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnSsc);
            this.Controls.Add(this.bnHmm);
            this.Controls.Add(this.bnBu);
            this.Controls.Add(this.bnAg);
            this.Controls.Add(this.lbResult);
            this.Menu = this.mainMenu1;
            this.Name = "FormMain";
            this.Text = "猜拳";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnBu;
        private System.Windows.Forms.Button bnSsc;
        private System.Windows.Forms.Button bnHmm;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button bnAg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPc;
        private System.Windows.Forms.PictureBox pbHum;
    }
}

