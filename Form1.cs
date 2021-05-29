using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace RugbyApp
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        class Player
        {//ID number (unique), name, birth date, height, weight, place of Birth and the team they are signed in.
            public int ID;
            public string Name { get; set; }
            public int DOB { get; set; }
            public int Height { get; set; }
            public int Weight { get; set; }
            public string PlaceOfBirth { get; set; }
            public string Team { get; set; }

            public Player(int id, string name, int dob, int height, int weight, string placeOfBirth, string team)
            {
                ID = id;
                Name = name;
                DOB = dob;
                Height = height;
                Weight = weight;
                PlaceOfBirth = placeOfBirth;
                Team = team;
                
            }


        }
        class Teams
        {// Teams
            public string Team { get; set; }
            public string Ground { get; set; }
            public string Coach { get; set; }
            public int YearFounded { get; set; }
            public string Region { get; set; }
            public string PlayersEnrolled { get; set; }
            public Teams(string teamName, string coach, string ground, int year_founded, string region, string players_enrolled)
            {
                Team = teamName;
                Ground = ground;
                Coach = coach;
                YearFounded = year_founded;
                Region = region;
                PlayersEnrolled = players_enrolled;
            }
        }
        private void loadData_Click(object sender, EventArgs e)
        { // Button
            List<Player> player_list = new List<Player>();
            myOpenFileDialog.Title = "Open Text File";
            myOpenFileDialog.Filter = "TextFile|*.txt";
            if (myOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fStream = File.OpenRead(myOpenFileDialog.FileName))
                    {
                        StreamReader reader = new StreamReader(fStream);
                        string eachPlayer;

                        while ((eachPlayer = reader.ReadLine()) != null)
                        {
                            List<string> tokens = new List<string>(eachPlayer.Split(';')); //int id, string name, int dob, int height, int weight, string placeOfBirth, string team
                            player_list.Add(new Player(Convert.ToInt32(tokens[0]), tokens[1], Convert.ToInt32(tokens[2]), Convert.ToInt32(tokens[3]), Convert.ToInt32(tokens[4]), tokens[5], tokens[6]));

                        }
                        if (reader != null)
                        {
                            reader.Close();
                        }
                        if (fStream != null)
                        {
                            fStream.Close();
                        }
                    }
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("File not found.");
                }
            }
        }
        

        private void saveData_Click(object sender, EventArgs e)
        { // Button
            
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Saved Players";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true; //int id, string name, int dob, int height, int weight, string placeOfBirth, string team
            Player tempPlayer = new Player(0, "", 0, 0, 0, "", "");

            string newPlayer = tempPlayer.ID.ToString() + ";";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    StreamWriter myWriter = new StreamWriter(mySaveFileDialog.FileName, true);
                    
                    if (newPlayer.Trim() != "") ;
                }

                    myStream.Close();
                }
            }
        

        private void players_Click(object sender, EventArgs e)
        { // Button

        }

        private void teams_Click(object sender, EventArgs e)
        { // Button

        }
        // Clock label
        public static DateTime Now { get; }
        private void time_And_Date_Click(object sender, EventArgs e)
        {
            this.time_And_Date.Text = DateTime.Now.ToString();
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time_And_Date.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void myOpenFileDialogue_FileOk(object sender, CancelEventArgs e)
        {

        }
        // Clock ends


    }
}
