using CourseGame.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseGame
{
    public partial class CreatingProfileForm : Form
    {
        public CreatingProfileForm()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PlayerNameTBox.Text))
            {
                MessageBox.Show("Input name!");
            }
            else 
            {
                using (var db = new CourseGame_DbContext())
                {
                    bool exist = db.Players.Any(p => p.Name == PlayerNameTBox.Text);
                    if (exist)
                    {
                        MessageBox.Show("This name already exists!");
                    }
                    else
                    {
                        var name = PlayerNameTBox.Text;
                        var player = new Player { Name = name, HP = 100, Score = 0, Skin = 1, TimeInGame = TimeSpan.Zero, Progress = 0, IsBanned = false };
                        db.Players.Add(player);
                        db.SaveChanges();

                        Program.state.player = player;
                        //MainMenuScreen.Close();
                        this.Close();

                        SelectLevel selectLevelForm = new SelectLevel();
                        selectLevelForm.Show();
                    }
                }
            }
        }

        private void PlayerNameTBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
