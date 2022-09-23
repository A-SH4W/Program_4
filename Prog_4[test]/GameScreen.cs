namespace Prog_4_test_
{
    public partial class GameScreen : Form
    {
        public int r { get; set; }
        public int c { get; set; }

        public GameScreen()
        {
            InitializeComponent();
            mapGrid.RowCount = r;
            mapGrid.ColumnCount = c;
            mapGrid.AutoSize = true;

            for (int i = 0; i < mapGrid.RowCount; i++)
            {
                for (int j = 0; j < mapGrid.ColumnCount; j++)
                {
                   Label testLabel = new Label();
                   this.Controls.Add(testLabel);
                   testLabel.Text = "~"; 
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