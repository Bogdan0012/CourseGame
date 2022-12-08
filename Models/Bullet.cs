using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace CourseGame
{
    class Bullet
    {
        public string direction;
        public int bulletLeft;
        public int bulletTop;

        private int speed = 20;
        private PictureBox bullet = new PictureBox();
        private Timer bulletTimer = new Timer();

        public void MakeBullet(Form form) { 
            bullet.BackColor = Color.DarkOrange;
            bullet.Size = new Size(10, 5);
            bullet.Tag = "bullet";
            bullet.Left = bulletLeft;
            bullet.Top = bulletTop;

            //bullet.BringToFront();
            form.Controls.Add(bullet);
            bullet.BringToFront();


            bulletTimer.Interval = speed;
            bulletTimer.Tick += new EventHandler(bulletTimerEvent);
            bulletTimer.Start();
        }

        private void bulletTimerEvent(object sender, EventArgs e)
        {
            if (direction == "left") { 
                bullet.Left -= speed;
            }
            if (direction == "right")
            {
                bullet.Left += speed;
            }

            if (bullet.Left < 2 || bullet.Left > 860) { 
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet.Dispose();
                bulletTimer = null;
                bullet = null;
            }
        }
    }
}
