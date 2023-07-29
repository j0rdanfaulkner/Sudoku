using System.Diagnostics.Eventing.Reader;

namespace Sudoku
{
    public partial class MainWindow : Form
    {
        private Color _activeSpace = Color.LightSkyBlue;
        private Color _generatedSpace = Color.DarkGray;
        private string _activeSpaceID = default!;
        private Button[,] spaces = new Button[9, 9];
        private string[,] board = new string[9, 9];
        public MainWindow()
        {
            InitializeComponent();
            StartGame();
        }
        public void StartGame()
        {
            CreateSpaces();
            GenerateGame();
            _activeSpaceID = "";
        }
        private void CreateSpaces()
        {
            // A ROW
            spaces[0, 0] = btnA1;
            spaces[1, 0] = btnA2;
            spaces[2, 0] = btnA3;
            spaces[3, 0] = btnA4;
            spaces[4, 0] = btnA5;
            spaces[5, 0] = btnA6;
            spaces[6, 0] = btnA7;
            spaces[7, 0] = btnA8;
            spaces[8, 0] = btnA9;
            // B ROW
            spaces[0, 1] = btnB1;
            spaces[1, 1] = btnB2;
            spaces[2, 1] = btnB3;
            spaces[3, 1] = btnB4;
            spaces[4, 1] = btnB5;
            spaces[5, 1] = btnB6;
            spaces[6, 1] = btnB7;
            spaces[7, 1] = btnB8;
            spaces[8, 1] = btnB9;
            // C ROW
            spaces[0, 2] = btnC1;
            spaces[1, 2] = btnC2;
            spaces[2, 2] = btnC3;
            spaces[3, 2] = btnC4;
            spaces[4, 2] = btnC5;
            spaces[5, 2] = btnC6;
            spaces[6, 2] = btnC7;
            spaces[7, 2] = btnC8;
            spaces[8, 2] = btnC9;
            // D ROW
            spaces[0, 3] = btnD1;
            spaces[1, 3] = btnD2;
            spaces[2, 3] = btnD3;
            spaces[3, 3] = btnD4;
            spaces[4, 3] = btnD5;
            spaces[5, 3] = btnD6;
            spaces[6, 3] = btnD7;
            spaces[7, 3] = btnD8;
            spaces[8, 3] = btnD9;
            // E ROW
            spaces[0, 4] = btnE1;
            spaces[1, 4] = btnE2;
            spaces[2, 4] = btnE3;
            spaces[3, 4] = btnE4;
            spaces[4, 4] = btnE5;
            spaces[5, 4] = btnE6;
            spaces[6, 4] = btnE7;
            spaces[7, 4] = btnE8;
            spaces[8, 4] = btnE9;
            // F ROW
            spaces[0, 5] = btnF1;
            spaces[1, 5] = btnF2;
            spaces[2, 5] = btnF3;
            spaces[3, 5] = btnF4;
            spaces[4, 5] = btnF5;
            spaces[5, 5] = btnF6;
            spaces[6, 5] = btnF7;
            spaces[7, 5] = btnF8;
            spaces[8, 5] = btnF9;
            // G ROW
            spaces[0, 6] = btnG1;
            spaces[1, 6] = btnG2;
            spaces[2, 6] = btnG3;
            spaces[3, 6] = btnG4;
            spaces[4, 6] = btnG5;
            spaces[5, 6] = btnG6;
            spaces[6, 6] = btnG7;
            spaces[7, 6] = btnG8;
            spaces[8, 6] = btnG9;
            // H ROW
            spaces[0, 7] = btnH1;
            spaces[1, 7] = btnH2;
            spaces[2, 7] = btnH3;
            spaces[3, 7] = btnH4;
            spaces[4, 7] = btnH5;
            spaces[5, 7] = btnH6;
            spaces[6, 7] = btnH7;
            spaces[7, 7] = btnH8;
            spaces[8, 7] = btnH9;
            // I ROW
            spaces[0, 8] = btnI1;
            spaces[1, 8] = btnI2;
            spaces[2, 8] = btnI3;
            spaces[3, 8] = btnI4;
            spaces[4, 8] = btnI5;
            spaces[5, 8] = btnI6;
            spaces[6, 8] = btnI7;
            spaces[7, 8] = btnI8;
            spaces[8, 8] = btnI9;
        }
        private void GenerateGame()
        {
            board[0, 0] = "5";
            board[1, 0] = "3";
            board[5, 0] = "7";
            board[0, 1] = "6";
            board[3, 1] = "1";
            board[4, 1] = "9";
            board[5, 1] = "5";
            board[2, 2] = "9";
            board[3, 2] = "8";
            board[7, 2] = "6";
            int i;
            int j;
            for (i = 0; i < 9; i++)
            {
                for (j = 0; j < 9; j++)
                {
                    if (board[i, j] != null)
                    {
                        spaces[i, j].BackColor = _generatedSpace;
                        spaces[i, j].Text = board[i, j];
                        spaces[i, j].Enabled = false;
                    }
                }
            }
        }
        private void SetSelectedSpace(string spaceID)
        {
            _activeSpaceID = spaceID;
        }
        private Button FindSpace(string name)
        {
            int i;
            int j;
            for (i = 0; i < 9; i++)
            {
                for (j = 0; j < 9; j++)
                {
                    string id = spaces[i, j].Name.ToString();
                    if (name == id)
                    {
                        return spaces[i, j];
                    }
                }
            }
            return null;
        }
        private void FillSpaceWithNumber(string number)
        {
            if (_activeSpaceID == null)
            {
                MessageBox.Show("You must choose a space to fill before selecting a number", "Space Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string buttonName = _activeSpaceID;
                Control btn = FindSpace(buttonName);
                btn.Text = number;
                btn.Enabled = true;
                SetSelectedSpace("");
                btn.BackColor = Color.White;
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            FillSpaceWithNumber("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            FillSpaceWithNumber("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            FillSpaceWithNumber("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            FillSpaceWithNumber("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            FillSpaceWithNumber("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            FillSpaceWithNumber("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            FillSpaceWithNumber("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            FillSpaceWithNumber("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            FillSpaceWithNumber("9");
        }
        private void CheckSpace(Button btn)
        {
            if (_activeSpaceID != "")
            {
                MessageBox.Show("You are already filling another space", "Space Already Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (btn.Text != "")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to overwrite this space?", "Space Already Filled", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        btn.Text = "";
                        SetSelectedSpace(btn.Name);
                        btn.BackColor = _activeSpace;
                        btn.Enabled = false;
                    }
                }
                else
                {
                    SetSelectedSpace(btn.Name);
                    btn.BackColor = _activeSpace;
                    btn.Enabled = false;
                }
            }
        }
        private void btnA1_Click(object sender, EventArgs e)
        {
            CheckSpace(btnA1);
        }
        private void btnA2_Click(object sender, EventArgs e)
        {
            CheckSpace(btnA2);
        }
        private void btnA3_Click(object sender, EventArgs e)
        {
            CheckSpace(btnA3);
        }

        private void btnA4_Click(object sender, EventArgs e)
        {
            CheckSpace(btnA4);
        }

        private void btnA5_Click(object sender, EventArgs e)
        {
            CheckSpace(btnA5);
        }

        private void btnA6_Click(object sender, EventArgs e)
        {
            CheckSpace(btnA6);
        }

        private void btnA7_Click(object sender, EventArgs e)
        {
            CheckSpace(btnA7);
        }

        private void btnA8_Click(object sender, EventArgs e)
        {
            CheckSpace(btnA8);
        }

        private void btnA9_Click(object sender, EventArgs e)
        {
            CheckSpace(btnA9);
        }
    }
}