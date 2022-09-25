using System.Diagnostics;

namespace Prog_4_test_
{
    public partial class FindTheIslandGame : Form
    {
        public int guessCounter = 0;

        // creating a global instance of object 'nav' of type NaviagtionSystem
        NavigationSystem nav = new NavigationSystem(StartScreen.r, StartScreen.c);

        // Method calls to create island location
        // and print map to label
        public FindTheIslandGame()
        {
            InitializeComponent();
           
            nav.IslandLoc();
            label3.Text = nav.PrintMap();
  
        }

        // Method closes game window
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        // Method restarts game
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        // Method accepts user's guess and stores in variable
        // Also tracks number of guesses and updates guess display
        private void guessButton_Click(object sender, EventArgs e)
        {
            string userGuess = guessBox.Text; 
            List<int> guess = userGuess.Split(',').Select(int.Parse).ToList();
            int rowGuess = guess[0];
            int colGuess = guess[1];
            guessBox.Clear();
            guessCounter++;
            numGuessBox.Text = guessCounter.ToString();           
            
        }
    }
}