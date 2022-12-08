namespace CourseGame
{
    partial class MainMenuScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.CreateProfileBtn = new System.Windows.Forms.Button();
            this.LoadProfileBtn = new System.Windows.Forms.Button();
            this.HelpBtn = new System.Windows.Forms.Button();
            this.CloseGameBtn = new System.Windows.Forms.Button();
            this.MapCreateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Work In Progress", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(128, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 121);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Game";
            // 
            // CreateProfileBtn
            // 
            this.CreateProfileBtn.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateProfileBtn.Location = new System.Drawing.Point(201, 137);
            this.CreateProfileBtn.Name = "CreateProfileBtn";
            this.CreateProfileBtn.Size = new System.Drawing.Size(220, 39);
            this.CreateProfileBtn.TabIndex = 1;
            this.CreateProfileBtn.Text = "Create new profile";
            this.CreateProfileBtn.UseVisualStyleBackColor = true;
            this.CreateProfileBtn.Click += new System.EventHandler(this.CreateProfileBtn_Click);
            // 
            // LoadProfileBtn
            // 
            this.LoadProfileBtn.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadProfileBtn.Location = new System.Drawing.Point(201, 200);
            this.LoadProfileBtn.Name = "LoadProfileBtn";
            this.LoadProfileBtn.Size = new System.Drawing.Size(220, 39);
            this.LoadProfileBtn.TabIndex = 2;
            this.LoadProfileBtn.Text = "Load";
            this.LoadProfileBtn.UseVisualStyleBackColor = true;
            this.LoadProfileBtn.Click += new System.EventHandler(this.LoadProfileBtn_Click);
            // 
            // HelpBtn
            // 
            this.HelpBtn.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpBtn.Location = new System.Drawing.Point(201, 267);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(220, 39);
            this.HelpBtn.TabIndex = 3;
            this.HelpBtn.Text = "Help";
            this.HelpBtn.UseVisualStyleBackColor = true;
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // CloseGameBtn
            // 
            this.CloseGameBtn.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseGameBtn.Location = new System.Drawing.Point(201, 451);
            this.CloseGameBtn.Name = "CloseGameBtn";
            this.CloseGameBtn.Size = new System.Drawing.Size(220, 39);
            this.CloseGameBtn.TabIndex = 4;
            this.CloseGameBtn.Text = "Quit";
            this.CloseGameBtn.UseVisualStyleBackColor = true;
            this.CloseGameBtn.Click += new System.EventHandler(this.CloseGameBtn_Click);
            this.CloseGameBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseGameBtn_Click);
            // 
            // MapCreateBtn
            // 
            this.MapCreateBtn.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapCreateBtn.Location = new System.Drawing.Point(201, 334);
            this.MapCreateBtn.Name = "MapCreateBtn";
            this.MapCreateBtn.Size = new System.Drawing.Size(220, 39);
            this.MapCreateBtn.TabIndex = 5;
            this.MapCreateBtn.Text = "Map creator";
            this.MapCreateBtn.UseVisualStyleBackColor = true;
            this.MapCreateBtn.Click += new System.EventHandler(this.MapCreateBtn_Click);
            // 
            // MainMenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(623, 530);
            this.Controls.Add(this.MapCreateBtn);
            this.Controls.Add(this.CloseGameBtn);
            this.Controls.Add(this.HelpBtn);
            this.Controls.Add(this.LoadProfileBtn);
            this.Controls.Add(this.CreateProfileBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(639, 569);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(639, 569);
            this.Name = "MainMenuScreen";
            this.Tag = "MainMenuScreen";
            this.Text = "My Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateProfileBtn;
        private System.Windows.Forms.Button LoadProfileBtn;
        private System.Windows.Forms.Button HelpBtn;
        private System.Windows.Forms.Button CloseGameBtn;
        private System.Windows.Forms.Button MapCreateBtn;
    }
}