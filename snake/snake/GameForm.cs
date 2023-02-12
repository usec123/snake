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
    public partial class GameForm : Form
    {
        const int size = 40;

        int score = 0;
        int diff; // possible values: 1 2 3
        char impossible; // possible values: W A S D
        static char dir; // possible values: W A S D
        static Label player;
        static List<Label> extensions = new List<Label>() {};
        Label food;
        Random r = new Random();
        static int cellsX;
        static int cellsY;
        static bool endGame = false;
        static bool dead = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            // calculates forbidden directions
            impossible = "WASD"[("WASD".IndexOf(dir) + 2) % 4];

            // moves the player
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            if (dir != null) movePlayer();
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'

            // teleports the player if they go out of bounds
            if (player.Location.X >= Width) player.Location = new Point(0, player.Location.Y); // right
            if (player.Location.X + size <= 0) player.Location = new Point((cellsX-1)*size, player.Location.Y); // left *
            if (player.Location.Y >= Height) player.Location = new Point(player.Location.X, 0); // bottom
            if (player.Location.Y + size <= 0) player.Location = new Point(player.Location.X, (cellsY - 1) * size); // top *

            // snake tail logic
            foreach (Label ext in extensions)
            {
                // moves the tail of the snake by reading their tag
                switch (ext.Tag.ToString())
                {
                    case "W": ext.Top -= size; break;
                    case "A": ext.Left -= size; break;
                    case "S": ext.Top += size; break;
                    case "D": ext.Left += size; break;
                }

                // teleports parts of the tail if they go out of bounds
                if (ext.Location.X >= Width) ext.Location = new Point(0, ext.Location.Y); // right
                if (ext.Location.X + size <= 0) ext.Location = new Point((cellsX-1) * size, ext.Location.Y); // left
                if (ext.Location.Y >= Height) ext.Location = new Point(ext.Location.X, 0); // bottom
                if (ext.Location.Y + size <= 0) ext.Location = new Point(ext.Location.X, (cellsY-1) * size); // top

                // ends the game if the player runs into their tail
                if (player.Bounds.IntersectsWith(ext.Bounds)) endGame = true;
            }
            // shifts label tags by 1 (tag of extensions[2] becomes the tag of extenions[1], tag of extensions[1] becomes tag of extensions[0] etc.)
            for (int i = extensions.Count - 2; i >= 0; i--) extensions[i + 1].Tag = extensions[i].Tag;

            // sets tag of the first extension to player's movement direction
            if (extensions.Count>0) extensions[0].Tag = dir.ToString();

            // food logic
            if (player.Bounds.IntersectsWith(food.Bounds))
            {
                score++;
                label1.Text = score.ToString();
                spawnExtension();
                spawnFood();
            }

            // ends game if a condition is met
            if (endGame)
            {
                dead = true;
                Close();
            }
        }

        // extension generator
        private void spawnExtension()
        {
            Point spawnpoint = new Point(); // where the extension will be spawned

            // calculates spawnpoint
            if (extensions.Count == 0) spawnpoint = new Point(player.Location.X, player.Location.Y);
            else spawnpoint = new Point(extensions[extensions.Count - 1].Location.X, extensions[extensions.Count - 1].Location.Y);

            // adds the extension to the form and makes it visible
            extensions.Add(new Label()
            {
                AutoSize = false,
                Size = new Size(size, size),
                Location = spawnpoint,
                BackColor = Color.Green,
                Text = "",
                Tag = ""
            });
            Controls.Add(extensions[extensions.Count - 1]);
            extensions[extensions.Count - 1].Show();
        }

        // player movement function
        private void movePlayer()
        {
            switch(dir)
            {
                case 'W': player.Top -= size; break;
                case 'A': player.Left -= size; break;
                case 'S': player.Top += size; break;
                case 'D': player.Left += size; break;
            }
        }
        
        // food spawning logic
        private void spawnFood()
        {
            // tries random spawn locations until a valid one is found
            for(; ; )
            {
                int foodX = r.Next(1, cellsX + 1) * size;
                int foodY = r.Next(1, cellsY + 1) * size;
                food.Location = new Point(foodX, foodY);

                // checks if spawn location is valid
                if (food.Bounds.IntersectsWith(player.Bounds)) continue;
                if (food.Location.X>Width-size || food.Location.Y>Height-size) continue;
                foreach (Label a in extensions) if (food.Bounds.IntersectsWith(a.Bounds)) continue;
                break;
            }
        }

        // constructor
        public GameForm(int difficulty)
        {
            diff = difficulty;
            InitializeComponent();
        }

        // calculates and defines commonly used variables, adds the player and the food, and starts the game
        private void GameForm_Load(object sender, EventArgs e)
        {
            cellsX = Width / size;
            cellsY = Height / size;
            timer1.Interval = (4 - diff) * 50;
            player = new Label()
            {
                AutoSize = false,
                Size = new Size(size, size),
                Location = new Point(cellsX/2*size, cellsY/2*size),
                BackColor = Color.Lime,
                Text = ""
            };
            food = new Label()
            {
                AutoSize = false,
                Size = new Size(size, size),
                Location = new Point(-size, -size),
                BackColor = Color.Red,
                Text = ""
            };

            dead = false;
            endGame = false;

            Controls.Add(player);
            Controls.Add(food);
            player.Show();
            food.Show();
            spawnFood();
            extensions.Clear();
            timer1.Start();
        }

        // saves the score to the scoreboard before closing the form
        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string d = "undefined";
            switch(diff)
            {
                case 1: d = "easy"; break;
                case 2: d = "medium"; break;
                case 3: d = "hard"; break;
            }
            StreamWriter a = new StreamWriter("..\\\\..\\\\scoreboard.txt", true);
            if (dead) a.WriteLine($"{score} ; {d} ; (dead)");
            else a.WriteLine($"{score} ; {d} ; (closed)");
            a.Close();
            //Application.Restart();
        }

        // input
        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ("WASD".Contains((char)e.KeyValue) && (char)e.KeyValue != impossible) dir = (char)e.KeyValue;
        }

        private void closeLbl_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
