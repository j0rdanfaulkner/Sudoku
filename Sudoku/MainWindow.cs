using System.Runtime.CompilerServices;

namespace Sudoku
{
    public partial class MainWindow : Form
    {
        private Color _activeSpace = Color.LightSkyBlue;
        private Color _generatedSpace = Color.DarkGray;
        private string _activeSpaceID = default!;
        private Button[,] spaces = new Button[9, 9];
        private string[,] board = new string[9, 9];
        private int _correctSpaces = 0;
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("This is the initial release; more game boards will be added in time", "Not Fully Developed", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // given values
            board[0, 0] = "5";
            board[1, 0] = "3";
            board[4, 0] = "7";
            board[0, 1] = "6";
            board[3, 1] = "1";
            board[4, 1] = "9";
            board[5, 1] = "5";
            board[1, 2] = "9";
            board[2, 2] = "8";
            board[7, 2] = "6";
            board[0, 3] = "8";
            board[4, 3] = "6";
            board[8, 3] = "3";
            board[0, 4] = "4";
            board[3, 4] = "8";
            board[5, 4] = "3";
            board[8, 4] = "1";
            board[0, 5] = "7";
            board[4, 5] = "2";
            board[8, 5] = "6";
            board[1, 6] = "6";
            board[6, 6] = "2";
            board[7, 6] = "8";
            board[3, 7] = "4";
            board[4, 7] = "1";
            board[5, 7] = "9";
            board[8, 7] = "5";
            board[4, 8] = "8";
            board[7, 8] = "7";
            board[8, 8] = "9";
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
            // rest of values
            board[2, 0] = "4";
            board[3, 0] = "6";
            board[5, 0] = "8";
            board[6, 0] = "9";
            board[7, 0] = "1";
            board[8, 0] = "2";
            board[1, 1] = "7";
            board[2, 1] = "2";
            board[6, 1] = "3";
            board[7, 1] = "4";
            board[8, 1] = "8";
            board[0, 2] = "1";
            board[3, 2] = "3";
            board[4, 2] = "4";
            board[5, 2] = "2";
            board[6, 2] = "5";
            board[8, 2] = "7";
            board[1, 3] = "5";
            board[2, 3] = "9";
            board[3, 3] = "7";
            board[5, 3] = "1";
            board[6, 3] = "4";
            board[7, 3] = "2";
            board[1, 4] = "2";
            board[2, 4] = "6";
            board[4, 4] = "5";
            board[6, 4] = "7";
            board[7, 4] = "9";
            board[1, 5] = "1";
            board[2, 5] = "3";
            board[3, 5] = "9";
            board[5, 5] = "4";
            board[6, 5] = "8";
            board[7, 5] = "5";
            board[0, 6] = "9";
            board[2, 6] = "1";
            board[3, 6] = "5";
            board[4, 6] = "3";
            board[5, 6] = "7";
            board[8, 6] = "4";
            board[0, 7] = "2";
            board[1, 7] = "8";
            board[2, 7] = "7";
            board[6, 7] = "6";
            board[7, 7] = "3";
            board[0, 8] = "3";
            board[1, 8] = "4";
            board[2, 8] = "5";
            board[3, 8] = "2";
            board[5, 8] = "6";
            board[6, 8] = "1";
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
                Button btn = FindSpace(buttonName);
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

        private void btnB1_Click(object sender, EventArgs e)
        {
            CheckSpace(btnB1);
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            CheckSpace(btnB2);
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            CheckSpace(btnB3);
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            CheckSpace(btnB4);
        }

        private void btnB5_Click(object sender, EventArgs e)
        {
            CheckSpace(btnB5);
        }

        private void btnB6_Click(object sender, EventArgs e)
        {
            CheckSpace(btnB6);
        }

        private void btnB7_Click(object sender, EventArgs e)
        {
            CheckSpace(btnB7);
        }

        private void btnB8_Click(object sender, EventArgs e)
        {
            CheckSpace(btnB8);
        }

        private void btnB9_Click(object sender, EventArgs e)
        {
            CheckSpace(btnB9);
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            CheckSpace(btnC1);
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            CheckSpace(btnC2);
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            CheckSpace(btnC3);
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            CheckSpace(btnC4);
        }

        private void btnC5_Click(object sender, EventArgs e)
        {
            CheckSpace(btnC5);
        }

        private void btnC6_Click(object sender, EventArgs e)
        {
            CheckSpace(btnC6);
        }

        private void btnC7_Click(object sender, EventArgs e)
        {
            CheckSpace(btnC7);
        }

        private void btnC8_Click(object sender, EventArgs e)
        {
            CheckSpace(btnC8);
        }

        private void btnC9_Click(object sender, EventArgs e)
        {
            CheckSpace(btnC9);
        }

        private void btnD1_Click(object sender, EventArgs e)
        {
            CheckSpace(btnD1);
        }

        private void btnD2_Click(object sender, EventArgs e)
        {
            CheckSpace(btnD2);
        }

        private void btnD3_Click(object sender, EventArgs e)
        {
            CheckSpace(btnD3);
        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            CheckSpace(btnD4);
        }

        private void btnD5_Click(object sender, EventArgs e)
        {
            CheckSpace(btnD5);
        }

        private void btnD6_Click(object sender, EventArgs e)
        {
            CheckSpace(btnD6);
        }

        private void btnD7_Click(object sender, EventArgs e)
        {
            CheckSpace(btnD7);
        }

        private void btnD8_Click(object sender, EventArgs e)
        {
            CheckSpace(btnD8);
        }

        private void btnD9_Click(object sender, EventArgs e)
        {
            CheckSpace(btnD9);
        }

        private void btnE1_Click(object sender, EventArgs e)
        {
            CheckSpace(btnE1);
        }

        private void btnE2_Click(object sender, EventArgs e)
        {
            CheckSpace(btnE2);
        }

        private void btnE3_Click(object sender, EventArgs e)
        {
            CheckSpace(btnE3);
        }

        private void btnE4_Click(object sender, EventArgs e)
        {
            CheckSpace(btnE4);
        }

        private void btnE5_Click(object sender, EventArgs e)
        {
            CheckSpace(btnE5);
        }

        private void btnE6_Click(object sender, EventArgs e)
        {
            CheckSpace(btnE6);
        }

        private void btnE7_Click(object sender, EventArgs e)
        {
            CheckSpace(btnE7);
        }

        private void btnE8_Click(object sender, EventArgs e)
        {
            CheckSpace(btnE8);
        }

        private void btnE9_Click(object sender, EventArgs e)
        {
            CheckSpace(btnE9);
        }

        private void btnF1_Click(object sender, EventArgs e)
        {
            CheckSpace(btnF1);
        }

        private void btnF2_Click(object sender, EventArgs e)
        {
            CheckSpace(btnF2);
        }

        private void btnF3_Click(object sender, EventArgs e)
        {
            CheckSpace(btnF3);
        }

        private void btnF4_Click(object sender, EventArgs e)
        {
            CheckSpace(btnF4);
        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            CheckSpace(btnF5);
        }

        private void btnF6_Click(object sender, EventArgs e)
        {
            CheckSpace(btnF6);
        }

        private void btnF7_Click(object sender, EventArgs e)
        {
            CheckSpace(btnF7);
        }

        private void btnF8_Click(object sender, EventArgs e)
        {
            CheckSpace(btnF8);
        }

        private void btnF9_Click(object sender, EventArgs e)
        {
            CheckSpace(btnF9);
        }

        private void btnG1_Click(object sender, EventArgs e)
        {
            CheckSpace(btnG1);
        }

        private void btnG2_Click(object sender, EventArgs e)
        {
            CheckSpace(btnG2);
        }

        private void btnG3_Click(object sender, EventArgs e)
        {
            CheckSpace(btnG3);
        }

        private void btnG4_Click(object sender, EventArgs e)
        {
            CheckSpace(btnG4);
        }

        private void btnG5_Click(object sender, EventArgs e)
        {
            CheckSpace(btnG5);
        }

        private void btnG6_Click(object sender, EventArgs e)
        {
            CheckSpace(btnG6);
        }

        private void btnG7_Click(object sender, EventArgs e)
        {
            CheckSpace(btnG7);
        }

        private void btnG8_Click(object sender, EventArgs e)
        {
            CheckSpace(btnG8);
        }

        private void btnG9_Click(object sender, EventArgs e)
        {
            CheckSpace(btnG9);
        }

        private void btnH1_Click(object sender, EventArgs e)
        {
            CheckSpace(btnH1);
        }

        private void btnH2_Click(object sender, EventArgs e)
        {
            CheckSpace(btnH2);
        }

        private void btnH3_Click(object sender, EventArgs e)
        {
            CheckSpace(btnH3);
        }

        private void btnH4_Click(object sender, EventArgs e)
        {
            CheckSpace(btnH4);
        }

        private void btnH5_Click(object sender, EventArgs e)
        {
            CheckSpace(btnH5);
        }

        private void btnH6_Click(object sender, EventArgs e)
        {
            CheckSpace(btnH6);
        }

        private void btnH7_Click(object sender, EventArgs e)
        {
            CheckSpace(btnH7);
        }

        private void btnH8_Click(object sender, EventArgs e)
        {
            CheckSpace(btnH8);
        }

        private void btnH9_Click(object sender, EventArgs e)
        {
            CheckSpace(btnH9);
        }

        private void btnI1_Click(object sender, EventArgs e)
        {
            CheckSpace(btnI1);
        }

        private void btnI2_Click(object sender, EventArgs e)
        {
            CheckSpace(btnI2);
        }

        private void btnI3_Click(object sender, EventArgs e)
        {
            CheckSpace(btnI3);
        }

        private void btnI4_Click(object sender, EventArgs e)
        {
            CheckSpace(btnI4);
        }

        private void btnI5_Click(object sender, EventArgs e)
        {
            CheckSpace(btnI5);
        }

        private void btnI6_Click(object sender, EventArgs e)
        {
            CheckSpace(btnI6);
        }

        private void btnI7_Click(object sender, EventArgs e)
        {
            CheckSpace(btnI7);
        }

        private void btnI8_Click(object sender, EventArgs e)
        {
            CheckSpace(btnI8);
        }

        private void btnI9_Click(object sender, EventArgs e)
        {
            CheckSpace(btnI9);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int i;
            int j;
            for (i = 0; i < 9; i++)
            {
                for (j = 0; j < 9; j++)
                {
                    if (spaces[i, j].Text == board[i, j])
                    {
                        if (spaces[i, j].BackColor != _generatedSpace)
                        {
                            spaces[i, j].BackColor = Color.DarkGreen;
                            spaces[i, j].Enabled = false;
                            _correctSpaces++;
                        }
                    }
                    else
                    {
                        spaces[i, j].BackColor = Color.DarkRed;
                    }
                }
            }
            string title = string.Format("{0} Correct Spaces", _correctSpaces);
            string message = string.Format("You have correctly solved {0} spaces of the board", _correctSpaces);
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            _correctSpaces = 0;
        }
    }
}