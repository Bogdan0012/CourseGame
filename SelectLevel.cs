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
    public partial class SelectLevel : Form
    {
        public SelectLevel()
        {
            InitializeComponent();
            PlayerNameLabel.Text = Program.state.player.Name;
            TotalScoreLabel.Text = "Total score: " + Program.state.player.Score.ToString();
            TimeLabel.Text = "Time in game: " + Program.state.player.TimeInGame.ToString();

            if (Program.state.player.Progress > 0) button1.Text = "✓";
            if (Program.state.player.Progress > 1) button2.Text = "✓";
            if (Program.state.player.Progress > 2) button3.Text = "✓";
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Program.state.player.Progress >= 1)
            {
                MessageBox.Show("В разработке...");
            }
            else 
            {
                MessageBox.Show("Для разблокировки пройдите уровень 1");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Program.state.player.Progress >= 2)
            {
                MessageBox.Show("В разработке...");
            }
            else
            {
                MessageBox.Show("Для разблокировки пройдите уровень 2");
            }
        }

        private void Skin1PBox_Click(object sender, EventArgs e)
        {
            Skin1PBox.BorderStyle = BorderStyle.Fixed3D;
            Skin2PBox.BorderStyle = BorderStyle.None;
            using (var db = new CourseGame_DbContext())
            {
                Player pl = db.Players.Single(p => p.Id == Program.state.player.Id);
                pl.Skin = 1;
                Program.state.player = pl;
                db.SaveChanges();
            }
        }

        private void Skin2PBox_Click(object sender, EventArgs e)
        {
            using (var db = new CourseGame_DbContext())
            {
                Player pl = db.Players.Single(p => p.Id == Program.state.player.Id);
                if (Program.state.player.Progress >= 1)
                {
                    Skin1PBox.BorderStyle = BorderStyle.None;
                    Skin2PBox.BorderStyle = BorderStyle.Fixed3D;
                    pl.Skin = 2;
                }
                else
                    MessageBox.Show("Для разблокировки пройдите уровень 1");
                Program.state.player = pl;
                db.SaveChanges();
            }
        }
    }
}
