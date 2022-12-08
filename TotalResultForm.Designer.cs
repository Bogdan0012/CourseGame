namespace CourseGame
{
    partial class TotalResultForm
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
            this.ResultPB = new System.Windows.Forms.PictureBox();
            this.OkBtn = new System.Windows.Forms.Button();
            this.levelLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.damageLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.totalResultabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ResultPB)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultPB
            // 
            this.ResultPB.BackColor = System.Drawing.Color.Transparent;
            this.ResultPB.Location = new System.Drawing.Point(184, 101);
            this.ResultPB.Name = "ResultPB";
            this.ResultPB.Size = new System.Drawing.Size(168, 182);
            this.ResultPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ResultPB.TabIndex = 0;
            this.ResultPB.TabStop = false;
            // 
            // OkBtn
            // 
            this.OkBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OkBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkBtn.ForeColor = System.Drawing.Color.White;
            this.OkBtn.Location = new System.Drawing.Point(304, 317);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(48, 34);
            this.OkBtn.TabIndex = 1;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = false;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.BackColor = System.Drawing.Color.Transparent;
            this.levelLabel.Font = new System.Drawing.Font("Palatino Linotype", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.levelLabel.Location = new System.Drawing.Point(12, 62);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(84, 43);
            this.levelLabel.TabIndex = 2;
            this.levelLabel.Text = "level";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.timeLabel.Location = new System.Drawing.Point(12, 119);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(76, 34);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "time";
            // 
            // damageLabel
            // 
            this.damageLabel.AutoSize = true;
            this.damageLabel.BackColor = System.Drawing.Color.Transparent;
            this.damageLabel.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damageLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.damageLabel.Location = new System.Drawing.Point(12, 153);
            this.damageLabel.Name = "damageLabel";
            this.damageLabel.Size = new System.Drawing.Size(111, 34);
            this.damageLabel.TabIndex = 4;
            this.damageLabel.Text = "damage";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.BackColor = System.Drawing.Color.Transparent;
            this.moneyLabel.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.moneyLabel.Location = new System.Drawing.Point(12, 187);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(99, 34);
            this.moneyLabel.TabIndex = 5;
            this.moneyLabel.Text = "money";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.scoreLabel.Location = new System.Drawing.Point(12, 221);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(81, 34);
            this.scoreLabel.TabIndex = 6;
            this.scoreLabel.Text = "score";
            // 
            // totalResultabel
            // 
            this.totalResultabel.AutoSize = true;
            this.totalResultabel.BackColor = System.Drawing.Color.Transparent;
            this.totalResultabel.Font = new System.Drawing.Font("Palatino Linotype", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalResultabel.ForeColor = System.Drawing.Color.IndianRed;
            this.totalResultabel.Location = new System.Drawing.Point(176, 62);
            this.totalResultabel.Name = "totalResultabel";
            this.totalResultabel.Size = new System.Drawing.Size(185, 43);
            this.totalResultabel.TabIndex = 7;
            this.totalResultabel.Text = "Total result";
            // 
            // TotalResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CourseGame.Properties.Resources.totalResult;
            this.ClientSize = new System.Drawing.Size(364, 363);
            this.Controls.Add(this.totalResultabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.damageLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.ResultPB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TotalResultForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "TotalResultForm";
            ((System.ComponentModel.ISupportInitialize)(this.ResultPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ResultPB;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label damageLabel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label totalResultabel;
    }
}