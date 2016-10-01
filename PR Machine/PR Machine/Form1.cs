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

namespace PR_Machine
{
    public partial class Form1 : Form
    {
        private FileProcessor fileProcessor = new FileProcessor();
        private string currentInputFile, currentSaveFile, currentExportFile;
        private List<string> joojQuotes = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initializeJoojQuotes();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Place_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(fileProcessor.Players.Count == 0)
            {
                DisplayBox.Text = "No Tournament Data Loaded!";
            }
            else
            {
                Player PlayerFromBox = fileProcessor.getPlayerFromName(PlayerNameDropBox.SelectedItem.ToString());
                Placing newPlacing = new Placing((int)PlacingNumberBox.Value, MonthlyCheckBox.Checked, TournamentNameBox.Text);
                PlayerFromBox.AddPlacing(newPlacing);

                DisplayBox.Text = ("Placing Added: " + PlayerFromBox.Name + " - " + newPlacing.displayPlacing());
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void DisplayAllInformation()
        {
            List<Player> playerList = fileProcessor.Players;

            foreach(Player p in playerList)
            {
                p.DisplayPlayer(this);
            }
        }

        private void PlayerNameDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlayerNameDropBox.Update();
        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {

            if (NewPlayerEntryBox.Text != "" && NewPlayerEntryBox.Text != "Box is empty!")
            {
                if (!fileProcessor.PlayerExist(NewPlayerEntryBox.Text))
                {
                    Player newPlayer = new Player(NewPlayerEntryBox.Text);
                    fileProcessor.AddPlayerToList(newPlayer);
                    NewPlayerEntryBox.Text = "";
                    
                }
                else
                {
                    NewPlayerEntryBox.Text = "Player Already Exists!";
                }
            }
            else
            {
                NewPlayerEntryBox.Text = "Box is empty!";
            }
            fileProcessor.PlayerStrings.Sort();
            resetDropBox();
        }

        private void NewPlayerEntryBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplayPlayersButton_Click(object sender, EventArgs e)
        {
            DisplayBox.Clear();
            foreach(Player p in fileProcessor.Players)
            {
                p.DisplayPlayer(this);
            }
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            // TODO: Prompt user for saving when exiting
        }

        private void loadTournamentDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.ShowDialog();

            if(OFD.FileName != "")
            {
                StreamReader reader = new StreamReader(OFD.FileName);

                fileProcessor.ReadTournamentData(reader);
                reader.Close();
            }
            currentInputFile = OFD.FileName;
            fileProcessor.PlayerStrings.Sort();
            PlayerNameDropBox.DataSource = fileProcessor.PlayerStrings;
        }

        private void saveTournamentDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.ShowDialog();

            if (SFD.FileName != "")
            {
                StreamWriter writer = new StreamWriter(SFD.FileName);

                fileProcessor.WriteTournamentData(writer);
                writer.Close();
            }
            currentSaveFile = SFD.FileName;
        }

        private void exportCurrentPRStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.ShowDialog();

            if (SFD.FileName != "")
            {
                StreamWriter writer = new StreamWriter(SFD.FileName);

                writer.Write(fileProcessor.GeneratePR());
                writer.Close();
            }
            currentExportFile = SFD.FileName;
        }

        private void generatePRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayBox.Text = fileProcessor.GeneratePR();
        }

        private void addPlacingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPlayerButton_Click(sender, e);
        }

        private void displayAllPlayerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayPlayersButton_Click(sender, e);
        }

        private void showCurrentFileInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayBox.Clear();

            DisplayBox.AppendText("Current data input file: " + currentInputFile + Environment.NewLine);
            DisplayBox.AppendText("Current data output file: " + currentSaveFile + Environment.NewLine);
            DisplayBox.AppendText("Current PR export file: " + currentExportFile + Environment.NewLine);
        }

        private void initializeJoojQuotes()
        {
            string quote = "Would ya quit pokin' me?!";
            joojQuotes.Add(quote);
            quote = "It's cuz I'm a bean, ain't it?";
            joojQuotes.Add(quote);
            quote = "Nice.";
            joojQuotes.Add(quote);
            quote = "Yikes.";
            joojQuotes.Add(quote);
            quote = "Dear Lord.";
            joojQuotes.Add(quote);
            quote = "ITS MAAAHBLE BABY!";
            joojQuotes.Add(quote);
            quote = "I'm getting a job!";
            joojQuotes.Add(quote);
            quote = "Not like this...";
            joojQuotes.Add(quote);
            quote = "Owwwww!!!";
            joojQuotes.Add(quote);
            quote = "Wasp is so cool";
            joojQuotes.Add(quote);
            quote = "I wish I were as good as Wasp";
            joojQuotes.Add(quote);
            quote = "Ooh Ooh";
            joojQuotes.Add(quote);
            quote = "Aah Aah";
            joojQuotes.Add(quote);
        }

        private void WinkyFace_Click(object sender, EventArgs e)
        {
            int randomNumber = 0;
            Random rng = new Random();

            randomNumber = rng.Next(13);    // Number of quotes in joojQuotes

            DisplayBox.Text = joojQuotes.ElementAt(randomNumber);
        }

        private void clearTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayBox.Clear();
        }

        private void resetDropBox()
        {
            PlayerNameDropBox.DataSource = null;
            PlayerNameDropBox.DataSource = fileProcessor.PlayerStrings;
        }

    }
}
