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
            Debug.Write("->");
            Debug.Write(mapGrid.RowCount);

            for (int i = 0; i < mapGrid.RowCount; i++)
            {
                for (int j = 0; j < mapGrid.ColumnCount; j++)
                {
                   Label testLabel = new Label();
                   testLabel.Text = "~";
                   mapGrid.Controls.Add(testLabel,i,j);
                    
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}