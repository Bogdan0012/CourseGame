namespace CourseGame.Admin
{
    partial class DeleteForm
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
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayersLB
            // 
            this.PlayersLB.BackColor = System.Drawing.Color.White;
            this.PlayersLB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayersLB.FormattingEnabled = true;
            this.PlayersLB.Location = new System.Drawing.Point(12, 30);
            this.PlayersLB.Name = "PlayersLB";
            this.PlayersLB.Size = new System.Drawing.Size(321, 182);
            this.PlayersLB.TabIndex = 1;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(120, 232);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(113, 32);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "DELETE PLAYER";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(344, 276);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.PlayersLB);
            this.Name = "DeleteForm";
            this.Text = "DeleteForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox PlayersLB;
        private System.Windows.Forms.Button DeleteBtn;
    }
}