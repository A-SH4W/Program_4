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

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("mogus");
            GameScreen gameScreen = new GameScreen();
            gameScreen.Show();
            string userInput = textBox1.Text;
            List<int> nums = userInput.Split(',').Select(int.Parse).ToList();
            int r = nums[0];
            int c = nums[1];
            Console.WriteLine(r);
            Console.WriteLine(c);



            // Hides start screen
            this.Hide();
        }
    }
}
