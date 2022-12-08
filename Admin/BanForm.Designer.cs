namespace CourseGame.Admin
{
    partial class BanForm
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
            this.PlayersLB = new System.Windows.Forms.ListBox();
            this.BanBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayersLB
            // 
            this.PlayersLB.BackColor = System.Drawing.Color.White;
            this.PlayersLB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayersLB.FormattingEnabled = true;
            this.PlayersLB.Location = new System.Drawing.Point(12, 17);
            this.PlayersLB.Name = "PlayersLB";
            this.PlayersLB.Size = new System.Drawing.Size(321, 182);
            this.PlayersLB.TabIndex = 0;
            // 
            // BanBtn
            // 
            this.BanBtn.Location = new System.Drawing.Point(115, 232);
            this.BanBtn.Name = "BanBtn";
            this.BanBtn.Size = new System.Drawing.Size(113, 32);
            this.BanBtn.TabIndex = 1;
            this.BanBtn.Text = "BAN / UNBAN";
            this.BanBtn.UseVisualStyleBackColor = true;
            this.BanBtn.Click += new System.EventHandler(this.BanBtn_Click);
            // 
            // BanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(346, 276);
            this.Controls.Add(this.BanBtn);
            this.Controls.Add(this.PlayersLB);
            this.Name = "BanForm";
            this.Text = "BanForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox PlayersLB;
        private System.Windows.Forms.Button BanBtn;
    }
}