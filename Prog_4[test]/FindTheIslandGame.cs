// Aodhan Shaw / Alex Ryan
// CMPS 4143
// 09/26/2022
// Program 4: Find Island Game

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
            label3.Text = nav.printMap(); // display to GUI
  
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
            bool validInput = true;
            string userGuess = guessBox.Text;
            char guessResult = 'A';
            List<int> guess = userGuess.Split(',').Select(int.Parse).ToList();
            int rowGuess = guess[0];
            int colGuess = guess[1];
            guessBox.Clear();
            guessCounter++;
            numGuessBox.Text = guessCounter.ToString(); // display to GUI

            // if statements validate user guess
            // Displays message box indicating input is invalid
            if (rowGuess > StartScreen.r || rowGuess < 0)
            {
                validInput = false;
                rowGuess = 0;
                MessageBox.Show("ERROR: Input exceeds bounds of map");
            }

            if (colGuess > StartScreen.c || colGuess < 0)
            {
                colGuess = 0;
                validInput = false;
                MessageBox.Show("ERROR: Input exceeds bounds of map");
            }

            

            //This lets the game know where the users guess is in relation to the island
            //the result is stored as a char in the guessResult variable
            if (userGuess == nav.getIslandLoc() && validInput == true)
            {
                //YOU WIN
                guessResult = 'I';
            
            }
            else if (rowGuess == nav.getIslandRow() && validInput == true)
            {
                guessResult = 'R';
            }
            else if (colGuess == nav.getIslandCol() && validInput == true)
            {
                guessResult = 'C';
            }
            else if (validInput==true)
            {
                int isEven = guessCounter % 2;
                int NSorWE = (isEven == 0) ? 1 : 0;
                if (NSorWE == 1)
                {
                    guessResult = (colGuess < nav.getIslandCol()) ? 'N' : 'S';
                }
                else
                {
                    guessResult = (rowGuess < nav.getIslandRow()) ? 'W' : 'E';
                }
            }
            
            nav.updateMap(guessResult, rowGuess, colGuess);
            label3.Text = nav.printMap(); // display to GUI
        }                
    }
}