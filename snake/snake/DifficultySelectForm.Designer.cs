namespace snake
{
    partial class DifficultySelectForm
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
            this.lblEasy = new System.Windows.Forms.Label();
            this.lblNormal = new System.Windows.Forms.Label();
            this.lblHard = new System.Windows.Forms.Label();
            this.buttonEasy = new System.Windows.Forms.Button();
            this.buttonNormal = new System.Windows.Forms.Button();
            this.buttonHard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select difficulty:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEasy
            // 
            this.lblEasy.BackColor = System.Drawing.Color.Black;
            this.lblEasy.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEasy.ForeColor = System.Drawing.Color.Red;
            this.lblEasy.Location = new System.Drawing.Point(74, 81);
            this.lblEasy.Name = "lblEasy";
            this.lblEasy.Size = new System.Drawing.Size(130, 57);
            this.lblEasy.TabIndex = 4;
            this.lblEasy.Text = "Easy";
            this.lblEasy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEasy.Click += new System.EventHandler(this.lblEasy_Click);
            // 
            // lblNormal
            // 
            this.lblNormal.BackColor = System.Drawing.Color.Black;
            this.lblNormal.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNormal.ForeColor = System.Drawing.Color.Red;
            this.lblNormal.Location = new System.Drawing.Point(74, 138);
            this.lblNormal.Name = "lblNormal";
            this.lblNormal.Size = new System.Drawing.Size(130, 57);
            this.lblNormal.TabIndex = 5;
            this.lblNormal.Text = "Normal";
            this.lblNormal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNormal.Click += new System.EventHandler(this.lblNormal_Click);
            // 
            // lblHard
            // 
            this.lblHard.BackColor = System.Drawing.Color.Black;
            this.lblHard.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHard.ForeColor = System.Drawing.Color.Red;
            this.lblHard.Location = new System.Drawing.Point(74, 195);
            this.lblHard.Name = "lblHard";
            this.lblHard.Size = new System.Drawing.Size(130, 57);
            this.lblHard.TabIndex = 6;
            this.lblHard.Text = "Hard";
            this.lblHard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHard.Click += new System.EventHandler(this.lblHard_Click);
            // 
            // buttonEasy
            // 
            this.buttonEasy.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonEasy.Location = new System.Drawing.Point(101, 98);
            this.buttonEasy.Name = "buttonEasy";
            this.buttonEasy.Size = new System.Drawing.Size(75, 23);
            this.buttonEasy.TabIndex = 7;
            this.buttonEasy.Text = "button1";
            this.buttonEasy.UseVisualStyleBackColor = true;
            this.buttonEasy.Click += new System.EventHandler(this.buttonEasy_Click);
            // 
            // buttonNormal
            // 
            this.buttonNormal.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonNormal.Location = new System.Drawing.Point(101, 154);
            this.buttonNormal.Name = "buttonNormal";
            this.buttonNormal.Size = new System.Drawing.Size(75, 23);
            this.buttonNormal.TabIndex = 8;
            this.buttonNormal.Text = "button1";
            this.buttonNormal.UseVisualStyleBackColor = true;
            this.buttonNormal.Click += new System.EventHandler(this.buttonNormal_Click);
            // 
            // buttonHard
            // 
            this.buttonHard.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonHard.Location = new System.Drawing.Point(101, 210);
            this.buttonHard.Name = "buttonHard";
            this.buttonHard.Size = new System.Drawing.Size(75, 23);
            this.buttonHard.TabIndex = 9;
            this.buttonHard.Text = "button1";
            this.buttonHard.UseVisualStyleBackColor = true;
            this.buttonHard.Click += new System.EventHandler(this.buttonHard_Click);
            // 
            // DifficultySelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(280, 260);
            this.Controls.Add(this.lblHard);
            this.Controls.Add(this.lblNormal);
            this.Controls.Add(this.lblEasy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEasy);
            this.Controls.Add(this.buttonNormal);
            this.Controls.Add(this.buttonHard);
            this.Name = "DifficultySelectForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEasy;
        private System.Windows.Forms.Label lblNormal;
        private System.Windows.Forms.Label lblHard;
        private System.Windows.Forms.Button buttonEasy;
        private System.Windows.Forms.Button buttonNormal;
        private System.Windows.Forms.Button buttonHard;
    }
}