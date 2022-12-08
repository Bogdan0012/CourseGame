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
    public partial class MainMenuScreen : Form
    {
        public MainMenuScreen()
        {
            InitializeComponent();
        }

        private void CreateProfileBtn_Click(object sender, EventArgs e)
        {
            CreatingProfileForm crPrForm = new CreatingProfileForm();
            crPrForm.Show();

            //this.Enabled = false;
            //this.Close();
        }

        private void LoadProfileBtn_Click(object sender, EventArgs e)
        {
            LoadProfileForm lpf = new LoadProfileForm();
            lpf.Show();
        }

        private void CloseGameBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MapCreateBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В разработке...");
        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            HelpForm hf = new HelpForm();
            hf.Show();
        }
    }
}
