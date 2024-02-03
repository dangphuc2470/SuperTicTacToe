namespace SuperTicTacToe
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnTable = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1 = new Panel();
            btTurn = new Button();
            pnTable.SuspendLayout();
            SuspendLayout();
            // 
            // pnTable
            // 
            pnTable.Controls.Add(panel2);
            pnTable.Controls.Add(panel3);
            pnTable.Controls.Add(panel4);
            pnTable.Controls.Add(panel1);
            pnTable.Location = new Point(39, 49);
            pnTable.Margin = new Padding(2);
            pnTable.Name = "pnTable";
            pnTable.Size = new Size(631, 614);
            pnTable.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.ForeColor = SystemColors.ActiveBorder;
            panel2.Location = new Point(10, 413);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(876, 4);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.ForeColor = SystemColors.ActiveBorder;
            panel3.Location = new Point(213, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(4, 700);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveBorder;
            panel4.ForeColor = SystemColors.ActiveBorder;
            panel4.Location = new Point(423, 0);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(4, 700);
            panel4.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.ForeColor = SystemColors.ActiveBorder;
            panel1.Location = new Point(10, 203);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(876, 4);
            panel1.TabIndex = 1;
            // 
            // btTurn
            // 
            btTurn.Location = new Point(27, 15);
            btTurn.Margin = new Padding(2);
            btTurn.Name = "btTurn";
            btTurn.Size = new Size(90, 27);
            btTurn.TabIndex = 4;
            btTurn.Text = "Turn";
            btTurn.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 702);
            Controls.Add(btTurn);
            Controls.Add(pnTable);
            Margin = new Padding(2);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            pnTable.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnTable;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button btTurn;
    }
}