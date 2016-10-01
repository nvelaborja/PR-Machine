using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PR_Machine
{
    class FileProcessor
    {
        private List<string> PlayerNames = new List<string>();
        private List<Player> PlayerList = new List<Player>();

        public FileProcessor()
        {
        }

        public List<Player> Players
        {
            get { return PlayerList; }
        }

        public List<string> PlayerStrings
        {
            get { return PlayerNames; }
        }

        public bool PlayerExist(string playerName)
        {
            foreach( Player p in PlayerList)
            {
                if (p.Name == playerName)
                {
                    return true;
                }
            }
            return false;
        }               // Returns true if given player name matches the name of one currently in the system

        public void AddPlayerToList(Player player)
        {
            Players.Add(player);
            PlayerNames.Add(player.Name);
        }               // Adds player to Player List and players name to PlayerNames

        public Player getPlayerFromName(string name)
        {
            foreach(Player player in PlayerList)
            {
                if(player.Name.ToLower() == name.ToLower())
                {
                    return player;
                }
            }
            return PlayerList.ElementAt<Player>(0); 
        }             // Returns first player in the list of players if name not found, theoretically should never be called. Might implement nullplayer for error checking later

        public void ReadTournamentData(StreamReader reader)
        {
            string line = "";
            List<string> splitLine = new List<string>();
            Player player;

            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                splitLine = line.Split(',').ToList();

                // CSV Format: Name,Place,PointValue,Monthly,TournamentName(Optional)

                if(PlayerExist(splitLine[0]))
                {
                    player = getPlayerFromName(splitLine[0]);
                }
                else
                {
                    player = new Player(splitLine[0]);
                    PlayerList.Add(player);
                    PlayerNames.Add(player.Name);
                }

                if (splitLine.Count > 4)
                {
                    Placing newPlacing = new Placing(Convert.ToInt32(splitLine[1]), Convert.ToBoolean(splitLine[3]), splitLine[4]);
                    player.AddPlacing(newPlacing);
                }
                else
                {
                    Placing newPlacing = new Placing(Convert.ToInt32(splitLine[1]), Convert.ToBoolean(splitLine[3]));
                    player.AddPlacing(newPlacing);
                }
            }
        }

        public void WriteTournamentData(StreamWriter writer)
        {
            foreach (Player p in Players)
            {
                foreach (Placing place in p.placings)
                {
                    writer.WriteLine(p.Name + ',' + place.Place + ',' + place.PointValue + ',' + place.IsMonthly + ',' + place.Tournament);
                }
            }
            writer.Close();
        }

        public string GeneratePR()
        {
            StringBuilder builder = new StringBuilder();

            foreach (Player player in PlayerList)
            {
                player.getTotalScore();
            }

            IEnumerable<Player> sortedPlayers = PlayerList.OrderByDescending(Player => Player.TotalScore);
                
            int place = 1;

            foreach(Player player in sortedPlayers)
            {
                if (player.Name.Length > 7)
                {
                    builder.AppendLine(place + ": " + player.Name + "\t@\t" + player.TotalScore + "\tpoints.");
                }
                else
                {
                    builder.AppendLine(place + ": " + player.Name + "\t\t@\t" + player.TotalScore + "\tpoints.");
                }
                place++;
            }
            
            return builder.ToString();
        }
    }
}
