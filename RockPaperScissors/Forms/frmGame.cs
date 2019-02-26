using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RockPaperScissors
{
    public partial class frmGame : Form
    {
        public int Wins { get; set; }
        public int WinsTotal { get; set; }
        public int Loses { get; set; }
        public int LosesTotal { get; set; }

        public frmGame()
        {
            InitializeComponent();
            VersionChecker.CheckVersion(true);

            LoadScores();
        }

        private void smiResetScores_Click(object sender, EventArgs e)
        {
            Wins = 0;
            WinsTotal = 0;
            Loses = 0;
            LosesTotal = 0;

            UpdateScores();
            SaveScores();
        }
        private void smiUpdate_Click(object sender, EventArgs e)
        {
            VersionChecker.CheckVersion();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            Play(1);
        }
        private void btnPaper_Click(object sender, EventArgs e)
        {
            Play(2);
        }
        private void btnScissors_Click(object sender, EventArgs e)
        {
            Play(3);
        }

        private void Play(int player1)
        {
            Random rnd = new Random();
            int player2 = rnd.Next(1, 4);

            if (rnd.Next(1, 100 + 1) <= 5)
                player2 = 3;
            
            pb1.Image = GetImageById(player1);
            pb2.Image = GetImageById(player2);

            if (player1 == player2)
                Draw();
            else if (player2 == 4)
                Troll();
            else
            {
                if (player1 == 1)
                {
                    if (player2 == 2)
                        Lost();
                    else if (player2 == 3)
                        Won();
                }
                else if(player1 == 2)
                {
                    if (player2 == 1)
                        Won();
                    else if (player2 == 3)
                        Lost();
                }
                else if (player1 == 3)
                {
                    if (player2 == 1)
                        Lost();
                    else if (player2 == 2)
                        Won();
                }
            }

            UpdateScores();
            SaveScores();
        }

        private Image GetImageById(int id)
        {
            switch(id)
            {
                default:
                case 0: return Properties.Resources.None;
                case 1: return Properties.Resources.Rock;
                case 2: return Properties.Resources.Paper;
                case 3: return Properties.Resources.Scissors;
                case 4: return Properties.Resources.Troll;
            }
        }

        private void Won()
        {
            Wins += 1;
            WinsTotal += 1;

            lblStatus.ForeColor = Color.Green;
            lblStatus.Text = "Won";
        }
        private void Lost()
        {
            Loses += 1;
            LosesTotal += 1;

            lblStatus.ForeColor = Color.DarkRed;
            lblStatus.Text = "Lost";
        }
        private void Draw()
        {
            lblStatus.ForeColor = Color.Black;
            lblStatus.Text = "Draw";
        }
        private void Troll()
        {
            lblStatus.ForeColor = Color.Gold;
            lblStatus.Text = "Trolled";

            MessageBox.Show("You sir, have just been trolled xD", "TROLOLO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void SaveScores()
        {
            File.WriteAllText("scores", WinsTotal + ":" + LosesTotal);
        }
        private void LoadScores()
        {
            if(File.Exists("scores"))
                try
                {
                    string[] score = File.ReadAllText("scores").Split(':');

                    WinsTotal = int.Parse(score[0]);
                    LosesTotal = int.Parse(score[1]);

                    UpdateScores();
                }
                catch { }
        }
        private void UpdateScores()
        {
            lblWins.Text = "Wins: " + Wins;
            lblWinsTotal.Text = "Total Wins: " + WinsTotal;
            lblLoses.Text = "Loses: " + Loses;
            lblLosesTotal.Text = "Total Loses: " + LosesTotal;
        }
    }
}
