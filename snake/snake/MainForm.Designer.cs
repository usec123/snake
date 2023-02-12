namespace snake
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.playLbl = new System.Windows.Forms.Label();
            this.scoreboardLbl = new System.Windows.Forms.Label();
            this.rulesLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(-5, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 170);
            this.label1.TabIndex = 0;
            this.label1.Text = "S N A K E";
            // 
            // playLbl
            // 
            this.playLbl.Font = new System.Drawing.Font("Myanmar Text", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playLbl.ForeColor = System.Drawing.Color.Red;
            this.playLbl.Location = new System.Drawing.Point(263, 126);
            this.playLbl.Name = "playLbl";
            this.playLbl.Size = new System.Drawing.Size(193, 83);
            this.playLbl.TabIndex = 4;
            this.playLbl.Text = "PLAY";
            this.playLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playLbl.Click += new System.EventHandler(this.playLbl_Click);
            // 
            // scoreboardLbl
            // 
            this.scoreboardLbl.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreboardLbl.ForeColor = System.Drawing.Color.Red;
            this.scoreboardLbl.Location = new System.Drawing.Point(14, 126);
            this.scoreboardLbl.Name = "scoreboardLbl";
            this.scoreboardLbl.Size = new System.Drawing.Size(188, 39);
            this.scoreboardLbl.TabIndex = 5;
            this.scoreboardLbl.Text = "Scoreboard";
            this.scoreboardLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.scoreboardLbl.Click += new System.EventHandler(this.scoreboardLbl_Click);
            // 
            // rulesLbl
            // 
            this.rulesLbl.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesLbl.ForeColor = System.Drawing.Color.Red;
            this.rulesLbl.Location = new System.Drawing.Point(14, 170);
            this.rulesLbl.Name = "rulesLbl";
            this.rulesLbl.Size = new System.Drawing.Size(188, 39);
            this.rulesLbl.TabIndex = 6;
            this.rulesLbl.Text = "Rules";
            this.rulesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rulesLbl.Click += new System.EventHandler(this.rulesLbl_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(468, 223);
            this.Controls.Add(this.rulesLbl);
            this.Controls.Add(this.scoreboardLbl);
            this.Controls.Add(this.playLbl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playLbl;
        private System.Windows.Forms.Label scoreboardLbl;
        private System.Windows.Forms.Label rulesLbl;
    }
}

