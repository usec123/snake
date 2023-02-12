using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace snake
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void playLbl_Click(object sender, EventArgs e)
        {
            DifficultySelectForm dsf = new DifficultySelectForm();
            DialogResult dsfr = dsf.ShowDialog();
            if (dsfr == DialogResult.OK)
            {
                int diff = dsf.diff;
                Hide();
                GameForm a = new GameForm(diff);
                a.ShowDialog();
                a.Dispose();
                Show();
            }
        }

        private void scoreboardLbl_Click(object sender, EventArgs e)
        {
            new ScoreboardForm().ShowDialog();
        }

        private void rulesLbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The player controls the snake!\n" +
                "\nControls - arrow keys or W/A/S/D" +
                "\nGoal - reach the highest score possible!" +
                "\nA point is given for each food consumed." +
                "\nThe game ends when the player runs into their own tail!" +
                "\n\nHave fun! :D", "Rules:");
        }
    }
}
