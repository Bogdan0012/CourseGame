using CourseGame.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseGame.Admin
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
            loadAndPrint();

            if (PlayersLB.Items.Count > 0) 
            {
                var selectedPlayer = PlayersLB.SelectedItem;
                Player player = (Player)selectedPlayer;
                NameTB.Text = player.Name;
                HpTB.Text = player.HP.ToString();
                SkinTB.Text = player.Skin.ToString();
                ScoreTB.Text = player.Score.ToString();
                ProgressTB.Text = player.Progress.ToString();
            }
        }

        private void loadAndPrint()
        {
            PlayersLB.Items.Clear();
            using (var db = new CourseGame_DbContext())
            {
                var query = from p in db.Players
                            orderby p.Name
                            select p;

                foreach (var player in query)
                {
                    PlayersLB.Items.Add(player);
                }
                if (PlayersLB.Items.Count > 0)
                    PlayersLB.SelectedIndex = 0;
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (PlayersLB.SelectedItem == null)
                MessageBox.Show("Select Player!");
            else
            {
                if (string.IsNullOrEmpty(NameTB.Text) || string.IsNullOrEmpty(HpTB.Text) || string.IsNullOrEmpty(SkinTB.Text) || string.IsNullOrEmpty(ScoreTB.Text) || string.IsNullOrEmpty(ProgressTB.Text))
                    MessageBox.Show("Please enter correct data!");
                else
                {
                    var selectedPlayer = PlayersLB.SelectedItem;
                    Player player = (Player)selectedPlayer;
                    using (var db = new CourseGame_DbContext())
                    {
                        Player pl = db.Players.Single(p => p.Id == player.Id);
                        pl.Name = NameTB.Text;
                        pl.HP = Int32.Parse(HpTB.Text);
                        pl.Skin = Int32.Parse(SkinTB.Text);
                        pl.Score = Int32.Parse(ScoreTB.Text);
                        pl.Progress = Int32.Parse(ProgressTB.Text);
                        db.SaveChanges();
                    }
                    loadAndPrint();
                }
            }
        }

        private void OnlyNums_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void PlayersLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPlayer = PlayersLB.SelectedItem;
            Player player = (Player)selectedPlayer;
            NameTB.Text = player.Name;
            HpTB.Text = player.HP.ToString();
            SkinTB.Text = player.Skin.ToString();
            ScoreTB.Text = player.Score.ToString();
            ProgressTB.Text = player.Progress.ToString();
        }
    }
}
