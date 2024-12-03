using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingCards_Assignment_3_
{
    public partial class Form1 : Form
    {


        private List<BasketballPlayer> players;

        public Form1()
        {
            InitializeComponent();
            InitializePlayers();
            DisplayPlayers();

            btnPlayer.Click += btnPlayer_Click;
            btnRemovePlayer.Click += btnRemovePlayer_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void InitializePlayers()
        {
            players = new List<BasketballPlayer>
        {
            new BasketballPlayer { Name = "Michael Jordan", Team = "Chicago Bulls", PhotoPath = "Michael_Jordan", PointsPerGame = GetRandomStat(), AssistsPerGame = GetRandomStat(), ReboundsPerGame = GetRandomStat(), StealsPerGame = GetRandomStat() },
            new BasketballPlayer { Name = "Magic Johnson", Team = "Los Angeles Lakers", PhotoPath = "Magic_Johnson", PointsPerGame = GetRandomStat(), AssistsPerGame = GetRandomStat(), ReboundsPerGame = GetRandomStat(), StealsPerGame = GetRandomStat() },
            new BasketballPlayer { Name = "Larry Bird", Team = "Boston Celtics", PhotoPath = "Larry_Bird_Lipofsky", PointsPerGame = GetRandomStat(), AssistsPerGame = GetRandomStat(), ReboundsPerGame = GetRandomStat(), StealsPerGame = GetRandomStat() },
            new BasketballPlayer { Name = "Shaquille O'Neal", Team = "Orlando Magic", PhotoPath = "Shaquille_O'Neal", PointsPerGame = GetRandomStat(), AssistsPerGame = GetRandomStat(), ReboundsPerGame = GetRandomStat(), StealsPerGame = GetRandomStat() },
            new BasketballPlayer { Name = "Tim Duncan", Team = "San Antonio Spurs", PhotoPath = "Tim_Duncan", PointsPerGame = GetRandomStat(), AssistsPerGame = GetRandomStat(), ReboundsPerGame = GetRandomStat(), StealsPerGame = GetRandomStat() },
            new BasketballPlayer { Name = "Allen Iverson", Team = "Philadelphia 76ers", PhotoPath = "Allen_Iverson_Lipofsky (2)", PointsPerGame = GetRandomStat(), AssistsPerGame = GetRandomStat(), ReboundsPerGame = GetRandomStat(), StealsPerGame = GetRandomStat() },
            new BasketballPlayer { Name = "Kobe Bryant", Team = "Los Angeles Lakers", PhotoPath = "Kobe_Bryant_8", PointsPerGame = GetRandomStat(), AssistsPerGame = GetRandomStat(), ReboundsPerGame = GetRandomStat(), StealsPerGame = GetRandomStat() },
            new BasketballPlayer { Name = "Kevin Garnett", Team = "Minnesota Timberwolves", PhotoPath = "Kevin_Garnett", PointsPerGame = GetRandomStat(), AssistsPerGame = GetRandomStat(), ReboundsPerGame = GetRandomStat(), StealsPerGame = GetRandomStat() },
            new BasketballPlayer { Name = "Dwyane Wade", Team = "Miami Heat", PhotoPath = "Dwyane_Wade", PointsPerGame = GetRandomStat(), AssistsPerGame = GetRandomStat(), ReboundsPerGame = GetRandomStat(), StealsPerGame = GetRandomStat() },
            new BasketballPlayer { Name = "Dirk Nowitzki", Team = "Dallas Mavericks", PhotoPath = "Dirk_Nowitzki_2", PointsPerGame = GetRandomStat(), AssistsPerGame = GetRandomStat(), ReboundsPerGame = GetRandomStat(), StealsPerGame = GetRandomStat() },
        };
        }
        private void DisplayPlayers()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = players;
            listBox1.DisplayMember = "Name";
        }


        private void UpdatePlayerView(BasketballPlayer player)
        {
            lblName.Text = player.Name;
            lblTeam.Text = player.Team;
            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(player.PhotoPath);

            lblPoints.Text = $"Points/Game: {player.PointsPerGame}";
            lblAssists.Text = $"Assists/Game: {player.AssistsPerGame}";
            lblRebounds.Text = $"Rebounds/Game: {player.ReboundsPerGame}";
            lblSteals.Text = $"Steals/Game: {player.StealsPerGame}";
            // Additional UI updates can be added here based on your requirements
            //pictureBoxPlayer.Image = (Image)Properties.Resources.ResourceManager.GetObject(player.PhotoPath);

            // Example: Change the background color of the panel based on random color
            //panelPlayerView.BackColor = GetRandomColor();

            // Example: Change the font color based on random color
            // lblPoints.ForeColor = GetRandomColor();
        }
        private static readonly Random random = new Random();
        private int GetRandomStat()
        {
            lock (random)
            {
                // Generate a random number between 10 and 30 for player stats
                return random.Next(10, 31);
            }
        }

        private Color GetRandomColor()

        // Generate a random color

        {
            return Color.FromArgb(new Random().Next(256), new Random().Next(256), new Random().Next(256));
        }


        public class BasketballPlayer
        {
            public string Name { get; set; }
            public string Team { get; set; }
            public string PhotoPath { get; set; }
            public int PointsPerGame { get; set; }
            public int AssistsPerGame { get; set; }
            public int ReboundsPerGame { get; set; }
            public int StealsPerGame { get; set; }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                var selectedPlayer = (BasketballPlayer)listBox1.SelectedItem;
                UpdatePlayerView(selectedPlayer);
            }
        }

        private void btnPlayer_Click(object sender, EventArgs e)
        {
            BasketballPlayer newPlayer = new BasketballPlayer
           
        {
            Name = "New Player",
            Team = "New Team",
            // Set default or random stats as needed
        };

            players.Add(newPlayer); // Add the new player to the players list

            // Update the ListBox display with the updated player list
            DisplayPlayers();
        }

        private void btnRemovePlayer_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                var selectedPlayer = (BasketballPlayer)listBox1.SelectedItem;
                players.Remove(selectedPlayer);
                DisplayPlayers(); // Update the player list display
                ClearPlayerView(); // Clear the player view details

                // Refresh the list box to reflect the updated player list
                listBox1.DataSource = null; // Clear the data source
                listBox1.DataSource = players; // Re-bind the updated player list
                listBox1.DisplayMember = "Name"; // Set the display member
            }
        }

        // Method to clear player view details
        private void ClearPlayerView()
        {
            lblName.Text = string.Empty;
            lblTeam.Text = string.Empty;
            pictureBox1.Image = null;
            lblPoints.Text = "Points/Game: ";
            lblAssists.Text = "Assists/Game: ";
            lblRebounds.Text = "Rebounds/Game: ";
            lblSteals.Text = "Steals/Game: ";
            // Additional UI elements to clear can be added here
        }
    }
    }

