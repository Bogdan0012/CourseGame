namespace CourseGame
{
    partial class CreatingProfileForm
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
            this.PlayerNameTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerNameTBox
            // 
            this.PlayerNameTBox.BackColor = System.Drawing.Color.LightGray;
            this.PlayerNameTBox.Location = new System.Drawing.Point(46, 49);
            this.PlayerNameTBox.Name = "PlayerNameTBox";
            this.PlayerNameTBox.Size = new System.Drawing.Size(160, 20);
            this.PlayerNameTBox.TabIndex = 0;
            this.PlayerNameTBox.TextChanged += new System.EventHandler(this.PlayerNameTBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mocking Bird", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input your nickname:";
            // 
            // StartBtn
            // 
            this.StartBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.Location = new System.Drawing.Point(61, 107);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(129, 30);
            this.StartBtn.TabIndex = 2;
            this.StartBtn.Text = "Play!";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // CreatingProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::CourseGame.Properties.Resources.mainMenu;
            this.ClientSize = new System.Drawing.Size(254, 161);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayerNameTBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(270, 200);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(270, 200);
            this.Name = "CreatingProfileForm";
            this.Text = "New Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PlayerNameTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartBtn;
    }
}