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
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            pnTable.SuspendLayout();
            SuspendLayout();
            // 
            // pnTable
            // 
            pnTable.Controls.Add(panel2);
            pnTable.Controls.Add(panel1);
            pnTable.Location = new Point(55, 61);
            pnTable.Name = "pnTable";
            pnTable.Size = new Size(746, 710);
            pnTable.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.ForeColor = SystemColors.ActiveBorder;
            panel2.Location = new Point(0, 472);
            panel2.Name = "panel2";
            panel2.Size = new Size(1095, 5);
            panel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.ForeColor = SystemColors.ActiveBorder;
            panel1.Location = new Point(0, 233);
            panel1.Name = "panel1";
            panel1.Size = new Size(1095, 5);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.ForeColor = SystemColors.ActiveBorder;
            panel3.Location = new Point(298, 61);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 749);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveBorder;
            panel4.ForeColor = SystemColors.ActiveBorder;
            panel4.Location = new Point(537, 61);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 749);
            panel4.TabIndex = 3;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 826);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(pnTable);
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
    }
}