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
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace CourseGame
{
    public partial class Form1 : Form
    {
        int seconds = 0;

        string bonusTime = "C";
        string bonusNoDamage = "C";
        string bonusAllMoney = "C";
        string totalRank = "C";

        int money = 0;
        bool goLeft, goRight, jumping, hasKey;
        int jumpSpeed = 13;
        int playerSpeed = 12;
        int force = 8;
        int score = 0;
        int backgroundSpeed = 11;
        int enemieSpeed = 2;

        int playerHp = Program.state.player.HP.Value;
        
        int ammo = 7;
        Dictionary<Control, Enemy> enemies = new Dictionary<Control, Enemy>();
        Dictionary<Control, Item> items = new Dictionary<Control, Item>();
        string facing = "right";

        public Form1()
        {
            InitializeComponent();
            InetializeEnemies();
            InetializeItems();
            Program.state.startTime = DateTime.Now;            
            if (Program.state.player.Skin == 1)
                player.Image= Properties.Resources.playerRight;
            if (Program.state.player.Skin == 2)
                player.Image = Properties.Resources.player2Right;

            if (Program.state.player.HP > 100)
                healthBar.Maximum = Program.state.player.HP.Value;
        }

        private void InetializeItems()
        {
            Item coinTemplate;
            Item ammoTemplate;
            using (var db = new CourseGame_DbContext())
            {
                coinTemplate = db.Items.Single(e => e.Name == "Coin");
                ammoTemplate = db.Items.Single(e => e.Name == "Ammo");
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "coin")
                {
                    items.Add(x, Item.from(coinTemplate));
                }
                if (x is PictureBox && (string)x.Tag == "ammo")
                {
                    items.Add(x, Item.from(ammoTemplate));
                }
            }
        }

        private void InetializeEnemies()
        {
            Enemy ghostTemplate;
            using (var db = new CourseGame_DbContext())
            {
                ghostTemplate = db.Enemies.Single(e => e.Name == "Ghost");
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "enemy")
                {
                    enemies.Add(x, Enemy.from(ghostTemplate));
                }
            }
        }

        private void ShootBullet(string direction) { 
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = player.Left + (player.Width / 2);
            shootBullet.bulletTop = player.Top + (player.Height / 2);
            shootBullet.MakeBullet(this);
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            if (playerHp > 0)
            {
                healthBar.Value = playerHp;
            }
            else {
                healthBar.Value = playerHp;
                GameTimer.Stop();

                Program.state.player.TimeInGame += DateTime.Now.Subtract(Program.state.startTime);
                using (var db = new CourseGame_DbContext())
                {
                    Player pl = db.Players.Single(p => p.Id == Program.state.player.Id);
                    pl.TimeInGame = Program.state.player.TimeInGame;
                    
                    Program.state.player = pl;
                    db.SaveChanges();
                }
                MessageBox.Show("YOU DIED" + Environment.NewLine + "Click OK to play again!");
                RestartGame();
            }

            seconds++;
            txtScore.Text = "Score: " + score;
            bulletsLabel.Text = "Bullets: " + ammo;
            MoneyLabel.Text = "Gold: " + money;
            player.Top += jumpSpeed;

            if (goLeft == true && player.Left > 140) {
                player.Left -= playerSpeed;
            }
            if (goRight == true && player.Left + (player.Width + 220) < this.ClientSize.Width) {
                player.Left += playerSpeed;
            }

            if (goLeft == true && background.Left < 0) {
                background.Left += backgroundSpeed;
                MoveGameElements("forward");
            }
            if (goRight == true && background.Left > -1251) {
                background.Left -= backgroundSpeed;
                MoveGameElements("back");
            }

            if (jumping == true) {
                jumpSpeed = -15;
                force -= 1;
            }
            else {
                jumpSpeed = 15;
            }
            if (jumping == true && force < 0) {
                jumping = false;
            }

            foreach (Control x in this.Controls)
            {               
                if (x is PictureBox && (string)x.Tag == "platform")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && jumping == false)
                    {
                        force = 9;
                        player.Top = x.Top - player.Height;
                        jumpSpeed = 0;
                    }
                    x.BringToFront();
                }

                if (x is PictureBox && (string)x.Tag == "coin")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        x.Visible = false;
                        int count = items[x].Damage.Value;
                        score += count;
                        money += 1;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        int count = items[x].Damage.Value;
                        ammo += count;
                    }
                }
                if (x is PictureBox && (string)x.Tag == "enemy") 
                {
                    if (player.Bounds.IntersectsWith(x.Bounds)) {
                        playerHp -= enemies[x].Damage.Value;
                    }
                    
                    if (x.Left > player.Left) 
                    {
                        x.Left -= enemieSpeed;
                        ((PictureBox)x).Image = Image.FromFile(@"..\..\Assets\" + enemies[x].Skin + "Left.png");
                    }
                    if (x.Left < player.Left)
                    {
                        x.Left += enemieSpeed;
                        ((PictureBox)x).Image = Image.FromFile(@"..\..\Assets\" + enemies[x].Skin + "Right.png");
                    }
                    if (x.Top > player.Top)
                    {
                        x.Top -= enemieSpeed;
                    }
                    if (x.Top < player.Top)
                    {
                        x.Top += enemieSpeed;
                    }
                }
                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "enemy")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds)) {
                            enemies[x].HP -= 2;                            
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();

                            if (enemies[x].HP < 1) {
                                score += enemies[x].Points.Value;
                                this.Controls.Remove(x);
                                ((PictureBox)x).Dispose();
                            }
                        }
                    }
                }

                if (player.Bounds.IntersectsWith(key.Bounds))
                {
                    key.Visible = false;
                    hasKey = true;
                }

                if (player.Bounds.IntersectsWith(door.Bounds) && hasKey == true)
                {
                    this.Close();
                    door.Image = Properties.Resources.door_open;
                    GameTimer.Stop();

                    //  RANK 
                    if (seconds <= 400) { score += 15; bonusTime = "S"; }
                    else if (seconds > 400 && seconds <= 490) { score += 11; bonusTime = "A"; }
                    else if (seconds > 490 && seconds < 650) { score += 6; bonusTime = "B"; }
                    else if (seconds >= 650) { score += 2; }
                    if (playerHp <= 50) { score += 2; }
                    else if (playerHp > 50 && playerHp <= 75) { score += 6; bonusNoDamage = "B"; }
                    else if (playerHp > 75 && playerHp < Program.state.player.HP) { score += 9; bonusNoDamage = "A"; }
                    else if (playerHp == Program.state.player.HP) { score += 12; bonusNoDamage = "S"; }
                    if (money <= 2) { score += 1; }
                    else if (money > 2 && money <= 4) { score += 3; bonusAllMoney = "B"; }
                    else if (money > 4 && money < 6) { score += 6; bonusAllMoney = "A"; }
                    else if (money == 6) { score += 10; bonusAllMoney = "S"; }
                    if (score >= 49) totalRank = "SuperStyle!";
                    else if (score > 39) totalRank = "S";
                    else if (score > 30) totalRank = "A";
                    else if (score > 25) totalRank = "B";

                    Program.state.player.TimeInGame += DateTime.Now.Subtract(Program.state.startTime);
                    using (var db = new CourseGame_DbContext())
                    {
                        Player pl = db.Players.Single(p => p.Id == Program.state.player.Id);
                        pl.Score += score;
                        //pl.Score = Program.state.player.Score;
                        pl.TimeInGame = Program.state.player.TimeInGame;

                        if (Program.state.player.Progress < 1){
                            pl.HP = 110;
                            pl.Progress = 1;
                        }
                        Program.state.player = pl;                        
                        db.SaveChanges();
                    }

                    TotalResultForm resf = new TotalResultForm(bonusTime, bonusNoDamage, bonusAllMoney, score, totalRank);
                    resf.Show();
                }

                if (player.Top + player.Height > this.ClientSize.Height)
                {
                    playerHp = 0;
                }
            }
        }

        private void IsKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) {
                goLeft = true;
                facing = "left";
                if (Program.state.player.Skin == 1)
                    player.Image = Properties.Resources.playerLeft;
                if (Program.state.player.Skin == 2)
                    player.Image = Properties.Resources.player2Left;
            }
            if (e.KeyCode == Keys.Right) {
                goRight = true;
                facing = "right";
                if (Program.state.player.Skin == 1)
                    player.Image = Properties.Resources.playerRight;
                if (Program.state.player.Skin == 2)
                    player.Image = Properties.Resources.player2Right;
            }
            if (e.KeyCode == Keys.Space && jumping == false) {
                jumping = true;
            }
        }

        private void IsKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right) {
                goRight = false;
            }
            if (jumping == true) {
                jumping = false;
            }

            if (e.KeyCode == Keys.C && ammo > 0) {
                ammo--;
                ShootBullet(facing);
            }
        }

        private void RestartGame()
        {
            Form1 newWindow = new Form1();
            newWindow.Show();
            this.Hide();
        }

        private void MoveGameElements(string direction)
        {
            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform" || x is PictureBox && (string)x.Tag == "coin" || x is PictureBox && (string)x.Tag == "key" || x is PictureBox && (string)x.Tag == "door" || x is PictureBox && (string)x.Tag == "ammo" || x is PictureBox && (string)x.Tag == "enemy") {
                    if (direction == "back") {
                        x.Left -= backgroundSpeed;
                    }
                    if (direction == "forward") {
                        x.Left += backgroundSpeed;
                    }
                }
            }
        }
        //private void CloseGame(object sender, FormClosedEventArgs e)
        //{
        //    Application.Exit();
        //}
    }
}
