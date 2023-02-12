using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{
    public partial class ScoreboardForm : Form
    {
        public ScoreboardForm()
        {
            InitializeComponent();
        }

        private void ScoreboardForm_Load(object sender, EventArgs e)
        {
            // reads scoreboard.txt file
            StreamReader r = new StreamReader("..\\\\..\\\\scoreboard.txt");

            // outputs scoreboard to listbox
            string l = r.ReadLine();
            while (l != null)
            {
                listBox1.Items.Add(l);
                l = r.ReadLine();
            }
            r.Close();
        }

        private void clearLbl_Click(object sender, EventArgs e)
        {
            StreamWriter w = new StreamWriter("..\\\\..\\\\scoreboard.txt", false);
            w.Write(string.Empty);
            w.Close();
            listBox1.Items.Clear();
        }
    }
}
