namespace CourseGame
{
    partial class SelectLevel
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.TotalScoreLabel = new System.Windows.Forms.Label();
            this.skinlabel = new System.Windows.Forms.Label();
            this.Skin2PBox = new System.Windows.Forms.PictureBox();
            this.Skin1PBox = new System.Windows.Forms.PictureBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Skin2PBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skin1PBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(58, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Level";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(84, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(153, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.AutoSize = true;
            this.PlayerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlayerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerNameLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.PlayerNameLabel.Location = new System.Drawing.Point(12, 3);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(89, 16);
            this.PlayerNameLabel.TabIndex = 4;
            this.PlayerNameLabel.Text = "playername";
            // 
            // TotalScoreLabel
            // 
            this.TotalScoreLabel.AutoSize = true;
            this.TotalScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalScoreLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.TotalScoreLabel.Location = new System.Drawing.Point(101, 3);
            this.TotalScoreLabel.Name = "TotalScoreLabel";
            this.TotalScoreLabel.Size = new System.Drawing.Size(66, 16);
            this.TotalScoreLabel.TabIndex = 5;
            this.TotalScoreLabel.Text = "totalscore";
            // 
            // skinlabel
            // 
            this.skinlabel.AutoSize = true;
            this.skinlabel.BackColor = System.Drawing.Color.Transparent;
            this.skinlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skinlabel.ForeColor = System.Drawing.Color.White;
            this.skinlabel.Location = new System.Drawing.Point(73, 149);
            this.skinlabel.Name = "skinlabel";
            this.skinlabel.Size = new System.Drawing.Size(60, 18);
            this.skinlabel.TabIndex = 6;
            this.skinlabel.Text = "Skins: ";
            // 
            // Skin2PBox
            // 
            this.Skin2PBox.Image = global::CourseGame.Properties.Resources.player2Right;
            this.Skin2PBox.Location = new System.Drawing.Point(129, 180);
            this.Skin2PBox.Name = "Skin2PBox";
            this.Skin2PBox.Size = new System.Drawing.Size(65, 74);
            this.Skin2PBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Skin2PBox.TabIndex = 8;
            this.Skin2PBox.TabStop = false;
            this.Skin2PBox.Click += new System.EventHandler(this.Skin2PBox_Click);
            // 
            // Skin1PBox
            // 
            this.Skin1PBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Skin1PBox.Image = global::CourseGame.Properties.Resources.playerRight;
            this.Skin1PBox.Location = new System.Drawing.Point(15, 180);
            this.Skin1PBox.Name = "Skin1PBox";
            this.Skin1PBox.Size = new System.Drawing.Size(65, 74);
            this.Skin1PBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Skin1PBox.TabIndex = 7;
            this.Skin1PBox.TabStop = false;
            this.Skin1PBox.Click += new System.EventHandler(this.Skin1PBox_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLabel.ForeColor = System.Drawing.Color.LightCoral;
            this.TimeLabel.Location = new System.Drawing.Point(12, 19);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(44, 16);
            this.TimeLabel.TabIndex = 9;
            this.TimeLabel.Text = "label2";
            // 
            // SelectLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::CourseGame.Properties.Resources.totalResult;
            this.ClientSize = new System.Drawing.Size(209, 265);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.Skin2PBox);
            this.Controls.Add(this.Skin1PBox);
            this.Controls.Add(this.skinlabel);
            this.Controls.Add(this.TotalScoreLabel);
            this.Controls.Add(this.PlayerNameLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(225, 304);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(225, 304);
            this.Name = "SelectLevel";
            this.Text = "Select Level";
            ((System.ComponentModel.ISupportInitialize)(this.Skin2PBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Skin1PBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label PlayerNameLabel;
        private System.Windows.Forms.Label TotalScoreLabel;
        private System.Windows.Forms.Label skinlabel;
        private System.Windows.Forms.PictureBox Skin1PBox;
        private System.Windows.Forms.PictureBox Skin2PBox;
        private System.Windows.Forms.Label TimeLabel;
    }
}