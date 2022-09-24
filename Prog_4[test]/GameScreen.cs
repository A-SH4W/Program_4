using System.Diagnostics;

namespace Prog_4_test_
{
    public partial class GameScreen : Form
    {
        //public int r { get; set; }
        //public int c { get; set; }


        public GameScreen()
        {
            InitializeComponent();
            mapGrid.RowCount = StartScreen.r;
            mapGrid.ColumnCount = StartScreen.c;
            mapGrid.AutoSize = true;

            for (int i = 0; i < mapGrid.RowCount; i++)
            {
                for (int j = 0; j < mapGrid.ColumnCount; j++)
                {
                   Label testLabel = new Label();
                   testLabel.Text = "~";
                   mapGrid.Controls.Add(testLabel,i,j);
                    
                }
            }

            // this randomly generates island location (needs to be put in a method)
            Random rnd = new Random();
            int islandRow  = rnd.Next(mapGrid.RowCount);
            int islandCol = rnd.Next(mapGrid.ColumnCount);

            //print to terminal to see if working... it does
            Debug.Write("Random Coordinate-> ");
            Debug.Write(islandRow);
            Debug.Write(",");
            Debug.Write(islandCol);
            Debug.Write("\n");
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            string userGuess = guessBox.Text;
            List<int> guess = userGuess.Split(',').Select(int.Parse).ToList();
            int rowGuess = guess[0];
            int colGuess = guess[1];
            Debug.Write("User Guess -> ");
            Debug.Write(userGuess);
            Debug.Write("\n");
        }
    }
}