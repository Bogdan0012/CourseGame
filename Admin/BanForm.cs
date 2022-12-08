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

namespace CourseGame.Admin
{
    public partial class BanForm : Form
    {
        public BanForm()
        {
            InitializeComponent();
            loadAndPrint();
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

        private void BanBtn_Click(object sender, EventArgs e)
        {
            if (PlayersLB.SelectedItem == null)
            {
                MessageBox.Show("Select Player!");
            }
            else
            {
                var selectedPlayer = PlayersLB.SelectedItem;
                Player player = (Player)selectedPlayer;

                using (var db = new CourseGame_DbContext())
                {
                    Player pl = db.Players.Single(p => p.Id == player.Id);
                    pl.IsBanned = !pl.IsBanned;
                    db.SaveChanges();
                }
                loadAndPrint();
            }
        }
    }
}
