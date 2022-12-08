namespace CourseGame
{
    partial class LoadProfileForm
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
            this.ProfilesLB = new System.Windows.Forms.ListBox();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProfilesLB
            // 
            this.ProfilesLB.BackColor = System.Drawing.Color.Black;
            this.ProfilesLB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProfilesLB.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfilesLB.ForeColor = System.Drawing.Color.White;
            this.ProfilesLB.FormattingEnabled = true;
            this.ProfilesLB.ItemHeight = 16;
            this.ProfilesLB.Location = new System.Drawing.Point(12, 21);
            this.ProfilesLB.Name = "ProfilesLB";
            this.ProfilesLB.Size = new System.Drawing.Size(269, 144);
            this.ProfilesLB.TabIndex = 0;
            // 
            // LoadBtn
            // 
            this.LoadBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBtn.Location = new System.Drawing.Point(12, 189);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadBtn.TabIndex = 1;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(206, 189);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // LoadProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::CourseGame.Properties.Resources.mainMenu;
            this.ClientSize = new System.Drawing.Size(291, 224);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.ProfilesLB);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(307, 263);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(307, 263);
            this.Name = "LoadProfileForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "LoadProfileForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ProfilesLB;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button DeleteBtn;
    }
}