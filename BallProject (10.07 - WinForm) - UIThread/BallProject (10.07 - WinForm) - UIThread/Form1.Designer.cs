namespace BallProject__10._07___WinForm____UIThread
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CreateBallBtn = new System.Windows.Forms.Button();
            this.BallImg = new System.Windows.Forms.PictureBox();
            this.RemoveBallsImg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BallImg)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateBallBtn
            // 
            this.CreateBallBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CreateBallBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CreateBallBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CreateBallBtn.Location = new System.Drawing.Point(0, 0);
            this.CreateBallBtn.Name = "CreateBallBtn";
            this.CreateBallBtn.Size = new System.Drawing.Size(403, 43);
            this.CreateBallBtn.TabIndex = 0;
            this.CreateBallBtn.Text = "Create Ball";
            this.CreateBallBtn.UseVisualStyleBackColor = false;
            this.CreateBallBtn.Click += new System.EventHandler(this.AddBallBtn_Click);
            // 
            // BallImg
            // 
            this.BallImg.Image = ((System.Drawing.Image)(resources.GetObject("BallImg.Image")));
            this.BallImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("BallImg.InitialImage")));
            this.BallImg.Location = new System.Drawing.Point(386, 198);
            this.BallImg.Name = "BallImg";
            this.BallImg.Size = new System.Drawing.Size(70, 71);
            this.BallImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BallImg.TabIndex = 1;
            this.BallImg.TabStop = false;
            // 
            // RemoveBallsImg
            // 
            this.RemoveBallsImg.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.RemoveBallsImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RemoveBallsImg.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RemoveBallsImg.Location = new System.Drawing.Point(398, 0);
            this.RemoveBallsImg.Name = "RemoveBallsImg";
            this.RemoveBallsImg.Size = new System.Drawing.Size(402, 43);
            this.RemoveBallsImg.TabIndex = 2;
            this.RemoveBallsImg.Text = "Remove Balls";
            this.RemoveBallsImg.UseVisualStyleBackColor = false;
            this.RemoveBallsImg.Click += new System.EventHandler(this.RemoveBallsImg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RemoveBallsImg);
            this.Controls.Add(this.BallImg);
            this.Controls.Add(this.CreateBallBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BallImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateBallBtn;
        private System.Windows.Forms.PictureBox BallImg;
        private System.Windows.Forms.Button RemoveBallsImg;
    }
}

