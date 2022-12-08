using CourseGame.Admin;
using CourseGame.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseGame
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            loadAndPrint();
        }

        private void loadAndPrint()
        {
            using (var db = new CourseGame_DbContext())
            {
                playersDataGridView.DataSource = db.Players.ToList();
                itemsDataGridView.DataSource = db.Items.ToList();
                enemiesDataGridView.DataSource = db.Enemies.ToList();
            }
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            loadAndPrint();
        }

        private void BanBtn_Click(object sender, EventArgs e)
        {
            BanForm bf = new BanForm();
            bf.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateForm uf = new UpdateForm();
            uf.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteForm df = new DeleteForm();
            df.Show();
        }
    }
}
