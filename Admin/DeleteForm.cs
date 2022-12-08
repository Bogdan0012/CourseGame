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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (PlayersLB.SelectedItem == null)
            {
                MessageBox.Show("Select Player!");
            }
            else
            {
                var selectedPlayer = (Player)PlayersLB.SelectedItem;
                using (var db = new CourseGame_DbContext())
                {
                    var loadedPlayer = db.Players.Single(p => p.Id == selectedPlayer.Id);
                    db.Players.Remove(loadedPlayer);
                    db.SaveChanges();
                }
                loadAndPrint();
            }
        }
    }
}
