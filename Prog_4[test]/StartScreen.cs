using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_4_test_
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        // static variables that define the size of the map
        public static int r = 0;
        public static int c = 0;
        // temporary variables use to verify user input
        int tempR; 
        int tempC;

        // Captures user input and parses the string to store values as integers
        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text;
            List<int> nums = userInput.Split(',').Select(int.Parse).ToList();
            tempR = nums[0];
            tempC = nums[1];


            // if/else statments verify that user input isn't too low (<=0)
            // or too high (>10)
            if (tempR <= 0)          
                r = 2;
            else
            r = (tempR > 10) ? 10 : tempR;

            if (tempC <= 0)
                c = 2;
            else
            c = (tempC > 10) ? 10 : tempC;

            // Launches new window for actual game screen
            FindTheIslandGame gameScreen = new FindTheIslandGame();
            gameScreen.Show();
        }

    }
}
