using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{
    public partial class DifficultySelectForm : Form
    {
        public int diff = 0; // saves difficulty
        public DifficultySelectForm()
        {
            InitializeComponent();
        }

        // labels trigger hidden buttons (buttons have DialogResult property)
        // set difficulty to easy (1)
        private void lblEasy_Click(object sender, EventArgs e)
        {
            buttonEasy.PerformClick();
            Close();
        }

        // set difficulty to normal (2)
        private void lblNormal_Click(object sender, EventArgs e)
        {
            buttonNormal.PerformClick();
            Close();
        }

        // set difficulty to hard (3)
        private void lblHard_Click(object sender, EventArgs e)
        {
            buttonHard.PerformClick();
            Close();
        }

        // button events
        // set difficulty to easy (1)
        private void buttonEasy_Click(object sender, EventArgs e)
        {
            diff = 1;
            DialogResult = DialogResult.OK;
        }

        // set difficulty to normal (2)
        private void buttonNormal_Click(object sender, EventArgs e)
        {
            diff = 2;
            DialogResult = DialogResult.OK;
        }

        // set difficulty to hard (3)
        private void buttonHard_Click(object sender, EventArgs e)
        {
            diff = 3;
            DialogResult = DialogResult.OK;
        }
    }
}
