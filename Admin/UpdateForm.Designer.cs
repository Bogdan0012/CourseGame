namespace CourseGame.Admin
{
    partial class UpdateForm
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
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.HpTB = new System.Windows.Forms.TextBox();
            this.SkinTB = new System.Windows.Forms.TextBox();
            this.ScoreTB = new System.Windows.Forms.TextBox();
            this.ProgressTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayersLB
            // 
            this.PlayersLB.BackColor = System.Drawing.Color.White;
            this.PlayersLB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayersLB.FormattingEnabled = true;
            this.PlayersLB.Location = new System.Drawing.Point(12, 22);
            this.PlayersLB.Name = "PlayersLB";
            this.PlayersLB.Size = new System.Drawing.Size(321, 195);
            this.PlayersLB.TabIndex = 2;
            this.PlayersLB.SelectedIndexChanged += new System.EventHandler(this.PlayersLB_SelectedIndexChanged);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(113, 393);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(113, 32);
            this.UpdateBtn.TabIndex = 3;
            this.UpdateBtn.Text = "UPDATE PLAYER";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(138, 247);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(148, 20);
            this.NameTB.TabIndex = 4;
            this.NameTB.Text = "name";
            // 
            // HpTB
            // 
            this.HpTB.Location = new System.Drawing.Point(138, 273);
            this.HpTB.Name = "HpTB";
            this.HpTB.Size = new System.Drawing.Size(148, 20);
            this.HpTB.TabIndex = 5;
            this.HpTB.Text = "110";
            this.HpTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNums_KeyPress);
            // 
            // SkinTB
            // 
            this.SkinTB.Location = new System.Drawing.Point(138, 299);
            this.SkinTB.Name = "SkinTB";
            this.SkinTB.Size = new System.Drawing.Size(148, 20);
            this.SkinTB.TabIndex = 6;
            this.SkinTB.Text = "2";
            this.SkinTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNums_KeyPress);
            // 
            // ScoreTB
            // 
            this.ScoreTB.Location = new System.Drawing.Point(138, 325);
            this.ScoreTB.Name = "ScoreTB";
            this.ScoreTB.Size = new System.Drawing.Size(148, 20);
            this.ScoreTB.TabIndex = 7;
            this.ScoreTB.Text = "200000";
            this.ScoreTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNums_KeyPress);
            // 
            // ProgressTB
            // 
            this.ProgressTB.Location = new System.Drawing.Point(138, 351);
            this.ProgressTB.Name = "ProgressTB";
            this.ProgressTB.Size = new System.Drawing.Size(148, 20);
            this.ProgressTB.TabIndex = 8;
            this.ProgressTB.Text = "1";
            this.ProgressTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNums_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "New name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "New HP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "New Skin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "New Score:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "New Progress:";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(346, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProgressTB);
            this.Controls.Add(this.ScoreTB);
            this.Controls.Add(this.SkinTB);
            this.Controls.Add(this.HpTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.PlayersLB);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PlayersLB;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox HpTB;
        private System.Windows.Forms.TextBox SkinTB;
        private System.Windows.Forms.TextBox ScoreTB;
        private System.Windows.Forms.TextBox ProgressTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}