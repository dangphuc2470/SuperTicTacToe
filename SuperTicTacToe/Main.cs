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
        public static int SQUARE_SIZE = 70;


        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
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
                for (int x = 0; x < 9 + 1; x++)
                {
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
                    button.BackColor = Color.FromArgb(128, 128, 255);
                else
                    button.BackColor = Color.FromArgb(255, 128, 128);
                TurnChange();
                ChosenTable = button.NextTable;
            }
            //if (button.BackColor == Color.Black)
            //    return;
            //bool notCheckedAll = false;
            //for (int i = 1; i < 10; i++)
            //{
            //    smallTableAndOrder[button.NextTable][i].ForeColor = Color.Wheat;
            //    if (button.BackColor != Color.Black)
            //        notCheckedAll = true;
            //}
            //if (!notCheckedAll)
            //{
            //    ChosenTable = 0;
            //}

            //if (ChosenTable!= 0)
            //{
            //    if (button.Table == ChosenTable)
            //        button.BackColor = Color.Black;
            //    else
            //        return;
            //}
            //else
            //    button.BackColor = Color.Black;
            //ChosenTable = button.NextTable;

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
                turn ="Y";
            else 
                turn = "X";
        }
    }
}


