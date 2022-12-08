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
    public partial class LoadProfileForm : Form
    {
        public LoadProfileForm()
        {
            InitializeComponent();
            loadAndPrintProfiles();
        }

        private void loadAndPrintProfiles()
        {
            ProfilesLB.Items.Clear();
            using (var db = new CourseGame_DbContext())
            {
                // Display all Players from the database
                var query = from p in db.Players
                            orderby p.Name
                            select p;

                foreach (var player in query)
                {
                    ProfilesLB.Items.Add(player);
                }
                if (ProfilesLB.Items.Count > 0)
                    ProfilesLB.SelectedIndex = 0;
            }
        }


        private void LoadBtn_Click(object sender, EventArgs e)
        {
            if (ProfilesLB.SelectedItem == null)
            {
                MessageBox.Show("Select Profile!");
            }
            else
            {
                var player = ProfilesLB.SelectedItem;
                Program.state.player = (Player) player;
                if (Program.state.player.IsBanned == true)
                {
                    MessageBox.Show("This profile is banned!");
                }
                else 
                {
                    this.Close();
                    SelectLevel selectLevelForm = new SelectLevel();
                    selectLevelForm.Show();
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (ProfilesLB.SelectedItem == null)
            {
                MessageBox.Show("Select Profile!");
            }
            else
            {
                var player = (Player) ProfilesLB.SelectedItem;
                using (var db = new CourseGame_DbContext())
                {
                    var loadedPlayer = db.Players.Single(p => p.Id == player.Id);                   
                    db.Players.Remove(loadedPlayer);
                    db.SaveChanges();
                }
                loadAndPrintProfiles();
            }
        }
    }
}
