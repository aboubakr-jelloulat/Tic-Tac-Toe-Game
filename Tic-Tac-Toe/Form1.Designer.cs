namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            l_Title = new Label();
            l_Turn = new Label();
            l_winner = new Label();
            btn_RestartGame = new Button();
            lbl_turn = new Label();
            lblWinner = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // l_Title
            // 
            l_Title.AutoSize = true;
            l_Title.Font = new Font("Dungeon", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_Title.ForeColor = Color.Transparent;
            l_Title.Location = new Point(300, 30);
            l_Title.Name = "l_Title";
            l_Title.Size = new Size(284, 30);
            l_Title.TabIndex = 0;
            l_Title.Text = "Tic-Tac-Toe Game";
            // 
            // l_Turn
            // 
            l_Turn.AutoSize = true;
            l_Turn.Font = new Font("Dungeon", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            l_Turn.ForeColor = Color.Yellow;
            l_Turn.Location = new Point(12, 91);
            l_Turn.Name = "l_Turn";
            l_Turn.Size = new Size(100, 30);
            l_Turn.TabIndex = 1;
            l_Turn.Text = "Turn : ";
            // 
            // l_winner
            // 
            l_winner.AutoSize = true;
            l_winner.Font = new Font("Dungeon", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            l_winner.ForeColor = Color.Yellow;
            l_winner.Location = new Point(12, 258);
            l_winner.Name = "l_winner";
            l_winner.Size = new Size(133, 30);
            l_winner.TabIndex = 2;
            l_winner.Text = "Winner : ";
            // 
            // btn_RestartGame
            // 
            btn_RestartGame.BackColor = SystemColors.ActiveCaptionText;
            btn_RestartGame.Font = new Font("Dungeon", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_RestartGame.ForeColor = Color.Lime;
            btn_RestartGame.Location = new Point(684, 438);
            btn_RestartGame.Name = "btn_RestartGame";
            btn_RestartGame.Size = new Size(150, 38);
            btn_RestartGame.TabIndex = 3;
            btn_RestartGame.Text = "Restart Game";
            btn_RestartGame.UseVisualStyleBackColor = false;
            btn_RestartGame.Click += btn_RestartGame_Click;
            // 
            // lbl_turn
            // 
            lbl_turn.AutoSize = true;
            lbl_turn.Font = new Font("Dungeon", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_turn.ForeColor = Color.Lime;
            lbl_turn.Location = new Point(87, 159);
            lbl_turn.Name = "lbl_turn";
            lbl_turn.Size = new Size(122, 30);
            lbl_turn.TabIndex = 4;
            lbl_turn.Text = "Player 1";
            lbl_turn.Click += label1_Click;
            // 
            // lblWinner
            // 
            lblWinner.AutoSize = true;
            lblWinner.Font = new Font("Dungeon", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWinner.ForeColor = Color.Lime;
            lblWinner.Location = new Point(30, 344);
            lblWinner.Name = "lblWinner";
            lblWinner.Size = new Size(179, 30);
            lblWinner.TabIndex = 5;
            lblWinner.Text = "In Progress";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.qques;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(325, 134);
            button1.Name = "button1";
            button1.Size = new Size(96, 72);
            button1.TabIndex = 6;
            button1.Tag = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.qques;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(456, 134);
            button2.Name = "button2";
            button2.Size = new Size(96, 72);
            button2.TabIndex = 7;
            button2.Tag = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.qques;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(594, 134);
            button3.Name = "button3";
            button3.Size = new Size(96, 72);
            button3.TabIndex = 8;
            button3.Tag = "?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.qques;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(325, 242);
            button4.Name = "button4";
            button4.Size = new Size(96, 72);
            button4.TabIndex = 9;
            button4.Tag = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = Properties.Resources.qques;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.Cursor = Cursors.Hand;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Location = new Point(456, 242);
            button5.Name = "button5";
            button5.Size = new Size(96, 72);
            button5.TabIndex = 10;
            button5.Tag = "?";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            // 
            // button6
            // 
            button6.BackgroundImage = Properties.Resources.qques;
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.Cursor = Cursors.Hand;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Location = new Point(594, 242);
            button6.Name = "button6";
            button6.Size = new Size(96, 72);
            button6.TabIndex = 11;
            button6.Tag = "?";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            // 
            // button7
            // 
            button7.BackgroundImage = Properties.Resources.qques;
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.Cursor = Cursors.Hand;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Location = new Point(325, 344);
            button7.Name = "button7";
            button7.Size = new Size(96, 72);
            button7.TabIndex = 12;
            button7.Tag = "?";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            // 
            // button8
            // 
            button8.BackgroundImage = Properties.Resources.qques;
            button8.BackgroundImageLayout = ImageLayout.Zoom;
            button8.Cursor = Cursors.Hand;
            button8.FlatStyle = FlatStyle.Popup;
            button8.Location = new Point(456, 344);
            button8.Name = "button8";
            button8.Size = new Size(96, 72);
            button8.TabIndex = 13;
            button8.Tag = "?";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            // 
            // button9
            // 
            button9.BackgroundImage = Properties.Resources.qques;
            button9.BackgroundImageLayout = ImageLayout.Zoom;
            button9.Cursor = Cursors.Hand;
            button9.FlatStyle = FlatStyle.Popup;
            button9.Location = new Point(594, 344);
            button9.Name = "button9";
            button9.Size = new Size(96, 72);
            button9.TabIndex = 14;
            button9.Tag = "?";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(846, 488);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblWinner);
            Controls.Add(lbl_turn);
            Controls.Add(btn_RestartGame);
            Controls.Add(l_winner);
            Controls.Add(l_Turn);
            Controls.Add(l_Title);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Tic-Tac-Toe";
            Load += Form1_Load;
            Paint += Form1_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label l_Title;
        private Label l_Turn;
        private Label l_winner;
        private Button btn_RestartGame;
        private Label lbl_turn;
        private Label lblWinner;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}
