using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperTicTacToe
{

    public partial class Main : Form
    {
        public int ChosenTable = 0;
        public List<List<CustomButton>> buttonList = new List<List<CustomButton>>();         //buttonList[y][x]
        public List<List<CustomButton>> smallTableAndOrder = new List<List<CustomButton>>(); //smallTableAndOrder[smalltable][order]
        public string turn = "X";
        public static int SCALE100_BUTTON_SIZE = 48;
        public static int SQUARE_SIZE;


        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            Graphics graphics = CreateGraphics();
            float dpiX = graphics.DpiX;
            SQUARE_SIZE = Convert.ToInt32(SCALE100_BUTTON_SIZE * (dpiX / 96));
            //SQUARE_SIZE = 53;
            //MessageBox.Show(SQUARE_SIZE.ToString());
            graphics.Dispose();

            btTurn.BackColor = Color.FromArgb(128, 128, 255);
            Button lastButton = new Button() { Width = 0, Location = new Point(0, 0) };
            int padding = 10;
            int[] nextTableCount = new int[10];
            for (int i = 0; i < 10; i++)
            {
                nextTableCount[i] = 1;
                CustomButton button = new CustomButton(); //Add empty button to the first element of array because I only use the array from 1
                smallTableAndOrder.Add(new List<CustomButton>());
                smallTableAndOrder[i].Add(button);
            }

            for (int y = 0; y < 9; y++)
            {
                buttonList.Add(new List<CustomButton>());
                for (int x = 0; x <= 9; x++)
                {
                    CustomButton buttonRepresentFor3x3Table = new CustomButton();
                    buttonRepresentFor3x3Table.BackColor = Color.White;
                    smallTableAndOrder[0].Add(buttonRepresentFor3x3Table);  //This button does not show in the table, only use it's color to check for all game win

                    CustomButton button = new CustomButton()
                    {
                        BackColor = Color.Wheat,
                        FlatStyle = FlatStyle.Flat,
                        Width = SQUARE_SIZE,
                        Height = SQUARE_SIZE,
                        Location = new Point(lastButton.Location.X + lastButton.Width + padding, lastButton.Location.Y),
                        Name = "bt" + x + "_" + y,
                        X = x,
                        Y = y,
                        Checked = "",
                    };
                    button.FlatAppearance.BorderColor = Color.Gainsboro;
                    button.Click += btn_Click;
                    pnTable.Controls.Add(button);
                    buttonList[y].Add(button);
                    lastButton = button;

                    int blockX = x / 3;
                    int blockY = y / 3;
                    // Đặt text tương ứng cho từng button dựa trên bảng 3x3 tương ứng
                    if (blockX == 0 && blockY == 0)
                    {
                        if (x <= 2 && y <= 2)
                        {
                            // Khoảng (0, 0) đến (2, 2) là bảng 3x3 đầu tiên, đặt text là "1"
                            buttonList[y][x].Table = 1;
                            buttonList[y][x].NextTable = nextTableCount[1]++;
                            smallTableAndOrder[1].Add(button);
                        }
                    }
                    else if (blockX == 1 && blockY == 0)
                    {
                        if (x >= 3 && x <= 5 && y <= 2)
                        {
                            // Khoảng (3, 0) đến (5, 2) là bảng 3x3 thứ hai, đặt text là "2"
                            buttonList[y][x].Table = 2;
                            buttonList[y][x].NextTable = nextTableCount[2]++;
                            smallTableAndOrder[2].Add(button);
                        }
                    }
                    else if (blockX == 2 && blockY == 0)
                    {
                        if (x >= 6 && y <= 2)
                        {
                            // Khoảng (6, 0) đến (8, 2) là bảng 3x3 thứ ba, đặt text là "3"
                            buttonList[y][x].Table = 3;
                            buttonList[y][x].NextTable = nextTableCount[3]++;
                            smallTableAndOrder[3].Add(button);
                        }
                    }

                    else if (blockX == 0 && blockY == 1)
                    {
                        if (x <= 2 && y >= 3 && y <= 5)
                        {
                            // Khoảng (0, 3) đến (2, 5) là bảng 3x3 thứ tư, đặt text là "4"
                            buttonList[y][x].Table = 4;
                            buttonList[y][x].NextTable = nextTableCount[4]++;
                            smallTableAndOrder[4].Add(button);
                        }
                    }
                    else if (blockX == 1 && blockY == 1)
                    {
                        if (x >= 3 && x <= 5 && y >= 3 && y <= 5)
                        {
                            // Khoảng (3, 3) đến (5, 5) là bảng 3x3 thứ năm, đặt text là "5"
                            buttonList[y][x].Table = 5;
                            buttonList[y][x].NextTable = nextTableCount[5]++;
                            smallTableAndOrder[5].Add(button);
                        }
                    }
                    else if (blockX == 2 && blockY == 1)
                    {
                        if (x >= 6 && y >= 3 && y <= 5)
                        {
                            // Khoảng (6, 3) đến (8, 5) là bảng 3x3 thứ sáu, đặt text là "6"
                            buttonList[y][x].Table = 6;
                            buttonList[y][x].NextTable = nextTableCount[6]++;
                            smallTableAndOrder[6].Add(button);
                        }
                    }
                    else if (blockX == 0 && blockY == 2)
                    {
                        if (x <= 2 && y >= 6)
                        {
                            // Khoảng (0, 6) đến (2, 8) là bảng 3x3 thứ bảy, đặt text là "7"
                            buttonList[y][x].Table = 7;
                            buttonList[y][x].NextTable = nextTableCount[7]++;
                            smallTableAndOrder[7].Add(button);
                        }
                    }
                    else if (blockX == 1 && blockY == 2)
                    {
                        if (x >= 3 && x <= 5 && y >= 6)
                        {
                            // Khoảng (3, 6) đến (5, 8) là bảng 3x3 thứ tám, đặt text là "8"
                            buttonList[y][x].Table = 8;
                            buttonList[y][x].NextTable = nextTableCount[8]++;
                            smallTableAndOrder[8].Add(button);
                        }
                    }
                    else if (blockX == 2 && blockY == 2)
                    {
                        if (x >= 6 && y >= 6)
                        {
                            // Khoảng (6, 6) đến (8, 8) là bảng 3x3 thứ chín, đặt text là "9"
                            buttonList[y][x].Table = 9;
                            buttonList[y][x].NextTable = nextTableCount[9]++;
                            smallTableAndOrder[9].Add(button);
                        }
                    }
                    button.Text = button.X.ToString() + "_" + button.Y.ToString();
                }
                lastButton.Location = new Point(0, lastButton.Location.Y + SQUARE_SIZE + padding);
                lastButton.Width = 0;
                lastButton.Height = 0;
            }


        }

        private void btn_Click(object? sender, EventArgs e)
        {


            CustomButton? button = sender as CustomButton;
            if (button?.BackColor != Color.Wheat)
                return;
            ChangeAllButtonColor(Color.Wheat, Color.White);

            if (button?.Checked == "")
            {
                bool havingEmptyButton = false;
                //Check if the next table have empty button, if not, NextTable = 0 meaning player can go anywhere
                for (int i = 1; i <= 9; i++)
                {
                    if (smallTableAndOrder[button.NextTable][i].BackColor == Color.White)
                    {
                        smallTableAndOrder[button.NextTable][i].BackColor = Color.Wheat;
                        havingEmptyButton = true;
                    }
                }
                if (!havingEmptyButton)
                {
                    button.NextTable = 0;
                    ChangeAllButtonColor(Color.White, Color.Wheat);
                }

                //Mark player move
                button.Checked = turn;
                if (turn == "X")
                {
                    button.BackColor = Color.FromArgb(128, 128, 255);
                    btTurn.BackColor = Color.FromArgb(255, 128, 128);
                }
                else
                {
                    button.BackColor = Color.FromArgb(255, 128, 128);
                    btTurn.BackColor = Color.FromArgb(128, 128, 255);

                }
                string s = WinnerCheck(button.Checked, smallTableAndOrder[ChosenTable]).ToString();
                if (s != "")
                {
                    MessageBox.Show(s);
                    ChangeSmallTableButtonColor(button.BackColor, ChosenTable); //Next table equal the order in the small table
                    //MessageBox.Show(WinnerCheck(button.Checked, smallTableAndOrder[0]).ToString());

                    //    for (int i = 1; i <= 9; i++)
                    //        MessageBox.Show(smallTableAndOrder[0][i].BackColor.ToString() + i);
                    //
                }
                TurnChange();
                ChosenTable = button.NextTable;
            }


        }

        private void ChangeSmallTableButtonColor(Color backColor, int currentOrder)
        {
            for (int i = 0; i <= 9; i++)
            {
                smallTableAndOrder[ChosenTable][i].BackColor = backColor;
            }
            smallTableAndOrder[0][currentOrder].BackColor = backColor; //button only represent for 3x3 table, not showing 
            smallTableAndOrder[0][currentOrder].Checked = turn;
            for (int i=1; i<=9; i++)
            {
                MessageBox.Show(smallTableAndOrder[0][i].Checked + i);
            }

        }

        private string? WinnerCheck(string Checked, List<CustomButton> smallTable)
        {
            if (ChosenTable != 0)
            {
                bool isWin = false;
                if (smallTable[1].Checked == Checked && smallTable[1].Checked == smallTable[2].Checked &&
                smallTable[2].Checked == smallTable[3].Checked)
                    isWin = true;

                if (smallTable[1].Checked == Checked && smallTable[1].Checked == smallTable[4].Checked &&
                smallTable[4].Checked == smallTable[7].Checked)
                    isWin = true;

                if (smallTable[1].Checked == Checked && smallTable[1].Checked == smallTable[5].Checked &&
                    smallTable[5].Checked == smallTable[9].Checked)
                    isWin = true;

                if (smallTable[2].Checked == Checked && smallTable[2].Checked == smallTable[5].Checked &&
                    smallTable[5].Checked == smallTable[8].Checked)
                    isWin = true;

                if (smallTable[3].Checked == Checked && smallTable[3].Checked == smallTable[6].Checked &&
                    smallTable[6].Checked == smallTable[9].Checked)
                    isWin = true;

                if (smallTable[3].Checked == Checked && smallTable[3].Checked == smallTable[5].Checked &&
                    smallTable[5].Checked == smallTable[7].Checked)
                    isWin = true;

                if (smallTable[4].Checked == Checked && smallTable[4].Checked == smallTable[5].Checked &&
                    smallTable[5].Checked == smallTable[6].Checked)
                    return Checked;

                if (smallTable[7].Checked == Checked && smallTable[7].Checked == smallTable[8].Checked &&
                    smallTable[8].BackColor == smallTable[9].BackColor)
                    isWin = true;
                if (isWin)
                    return Checked;
            }
            return "";
        }

        private void ChangeAllButtonColor(Color from, Color to)
        {
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9 + 1; x++)
                {
                    if (buttonList[y][x].BackColor == from)
                    {
                        buttonList[y][x].BackColor = to;
                    }
                }
            }
        }

        private void TurnChange()
        {
            if (turn == "X")
                turn = "O";
            else
                turn = "X";
        }
    }
}


