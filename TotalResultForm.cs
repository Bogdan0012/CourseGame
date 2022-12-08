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
    public partial class TotalResultForm : Form
    {
        public TotalResultForm(string bonusTime, string bonusNoDamage, string bonusAllMoney, int score, string totalRank)
        {
            InitializeComponent();
            ResultPB.Image = Image.FromFile(@"..\..\Assets\rank" + totalRank + ".png");
            levelLabel.Text = "Level " + "1";
            timeLabel.Text = "Time: " + bonusTime;
            damageLabel.Text = "Caution: " + bonusNoDamage;
            moneyLabel.Text = "Money: " + bonusAllMoney;
            scoreLabel.Text = "Score: " + score.ToString();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            SelectLevel slform = new SelectLevel();
            slform.Show();
        }
    }
}
