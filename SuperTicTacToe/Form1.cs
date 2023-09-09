using System;
using System.Drawing;
using System.Windows.Forms;

namespace SuperTicTacToe
{
    public partial class Form1 : Form
    {
        private Panel[,] board;
        private Button[,] buttons;
        private string player;
        private int nextBoardRow;
        private int nextBoardCol;

        public Form1()
        {
            InitializeComponent();
            InitializeBoard();
            Reset();
        }

        private void InitializeBoard()
        {
            // Tạo các Panel để tạo bảng 9x9 và các bảng con 3x3
            board = new Panel[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Panel panel = new Panel();
                    panel.Location = new Point(j * 150, i * 150);
                    panel.Size = new Size(150, 150);
                    panel.BorderStyle = BorderStyle.FixedSingle;
                    panel.Name = "panel" + i.ToString() + j.ToString();
                    this.Controls.Add(panel);
                    board[i, j] = panel;
                }
            }

            // Tạo các Button để đại diện cho các ô trên bảng
            buttons = new Button[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button button = new Button();
                    button.Location = new Point(j * 50, i * 50);
                    button.Size = new Size(50, 50);
                    button.Name = "button" + i.ToString() + j.ToString();
                    button.Click += new EventHandler(Button_Click);
                    board[i / 3, j / 3].Controls.Add(button);
                    buttons[i, j] = button;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int row = int.Parse(button.Name.Substring(6, 1));
            int col = int.Parse(button.Name.Substring(7, 1));
            int boardRow = row / 3;
            int boardCol = col / 3;

            // Xác định bảng con tiếp theo mà đối thủ của người chơi phải đánh vào
            if (nextBoardRow == -1 && nextBoardCol == -1)
            {
                nextBoardRow = boardRow;
                nextBoardCol = boardCol;
            }

            // Kiểm tra xem ô đã được đánh chưa
            if (button.Text != "")
            {
                return;
            }

            // Đặt text cho ô
            button.Text = player;
            player = (player == "X") ? "O" : "X";

            // Kiểm tra xem người chơi đã chiến thắng trên một bảng con hoặc trên cả bảng 9x9 chưa
            if (CheckWin(board[boardRow, boardCol]) || CheckWin(board))
            {
                MessageBox.Show("Player " + player + " wins!");
                Reset();
                return;
            }

            // Kiểm tra xem bảng con tiếp theo đã bị đầy hoặc đã có người chiến thắng chưa
            if (CheckFull(board[nextBoardRow, nextBoardCol]) || CheckWin(board[nextBoardRow, nextBoardCol]))
            {
                nextBoardRow = -1;
                nextBoardCol = -1;
            }
            else
            {
                nextBoardRow = row % 3;
                nextBoardCol = col % 3;
            }

            // Đặt border cho bảng con tiếp theo
            board[nextBoardRow, nextBoardCol].BorderStyle = BorderStyle.FixedSingle;
        }

        private bool CheckWin(Panel panel)
        {
            // Kiểm tra hàng và cột
            for (int i = 0; i < 3; i++)
            {
                if (panel.Controls[i * 3].Text == player && panel.Controls[i * 3 + 1].Text == player && panel.Controls[i * 3 + 2].Text == player)
                {
                    return true;
                }
                if (panel.Controls[i].Text == player && panel.Controls[i + 3].Text == player && panel.Controls[i + 6].Text == player)
                {
                    return true;
                }
            }
            // Kiểm tra đường chéo
            if (panel.Controls[0].Text == "X" && panel.Controls[4].Text == "X" && panel.Controls[8].Text == "X" ||
                panel.Controls[2].Text == "X" && panel.Controls[4].Text == "X" && panel.Controls[6].Text == "X" ||
                panel.Controls[0].Text == "O" && panel.Controls[4].Text == "O" && panel.Controls[8].Text == "O" ||
                panel.Controls[2].Text == "O" && panel.Controls[4].Text == "O" && panel.Controls[6].Text == "O")
            {
                return true;
            }
            return false;
        }

        private bool CheckWin(Panel[,] board)
        {
            // Kiểm tra hàng và cột
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0].Controls[0].Text == player && board[i, 1].Controls[0].Text == player && board[i, 2].Controls[0].Text == player)
                {
                    return true;
                }
                if (board[0, i].Controls[0].Text == player && board[1, i].Controls[0].Text == player && board[2, i].Controls[0].Text == player)
                {
                    return true;
                }
            }
            // Kiểm tra đường chéo
            if (board[0, 0].Controls[0].Text == player && board[1, 1].Controls[0].Text == player && board[2, 2].Controls[0].Text == player)
            {
                return true;
            }
            if (board[0, 2].Controls[0].Text == player && board[1, 1].Controls[0].Text == player && board[2, 0].Controls[0].Text == player)
            {
                return true;
            }
            return false;
        }

        private bool CheckFull(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control.Text == "")
                {
                    return false;
                }
            }
            return true;
        }

        private void Reset()
        {
            // Đặt player và bảng con tiếp theo về giá trị ban đầu
            player = "X";
            nextBoardRow = -1;
            nextBoardCol = -1;

            // Đặt text của tất cả các ô về giá trị rỗng
            foreach (Button button in buttons)
            {
                button.Text = "";
            }

            // Đặt border của tất cả các bảng về giá trị không có border
            foreach (Panel panel in board)
            {
                panel.BorderStyle = BorderStyle.None;
            }
        }
    }
}