﻿using System;
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

        public static int r = 0;
        public static int c = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("mogus");
            string userInput = textBox1.Text;
            List<int> nums = userInput.Split(',').Select(int.Parse).ToList();
            r = nums[0];
            c = nums[1];

            //Debug.Write(r);
            //Debug.Write(c);



            // Hides start screen
            this.Hide();

            GameScreen gameScreen = new GameScreen();
            gameScreen.Show();
        }
    }
}
