namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        enum enPlayer
        {
            Player1,
            Player2
        }

        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;

        }

        stGameStatus GameStatus;
        enPlayer PlayerTurn = enPlayer.Player1;

        void EndGame()
        {
            lbl_turn.Text = "Game Over ";

            switch (GameStatus.Winner)
            {
                case enWinner.Player1:
                    lblWinner.Text = "Player 1";
                    break;

                case enWinner.Player2:
                    lblWinner.Text = "Player 2";
                    break;

                default:
                    lblWinner.Text = "Draw";
                    break;
            }
            MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        public bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString())
            {

                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                if (btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }

            }
            GameStatus.GameOver = false;
            return false;
        }


        public void CheckWinner()
        {

            //check Row1
            if (CheckValues(button1, button2, button3))
                return;

            //check Row2
            if (CheckValues(button4, button5, button6))
                return;

            //check Row3
            if (CheckValues(button7, button8, button9))
                return;


            //check col1
            if (CheckValues(button1, button4, button7))
                return;

            //check col2
            if (CheckValues(button2, button5, button8))
                return;

            //check col3
            if (CheckValues(button3, button6, button9))
                return;



            //check Diagonal1
            if (CheckValues(button1, button5, button9))
                return;

            //check Diagonal2
            if (CheckValues(button3, button5, button7))
                return;

        }

        public void ChangeImage(Button btn)
        {
            if (btn.Tag.ToString() == "?")
            {
                switch (PlayerTurn)
                {
                    case enPlayer.Player1:

                        Image img_x = Image.FromFile(@"C:\Users\hp\Downloads\x.jpg");

                        // Resize the image to fit the button size
                        Bitmap resizedImage_x = new Bitmap(img_x, btn.Width, btn.Height);

                        btn.Image = resizedImage_x;
                        btn.ImageAlign = ContentAlignment.MiddleCenter;
                        btn.Text = "";


                        PlayerTurn = enPlayer.Player2;

                        lbl_turn.Text = "Player 2";

                        GameStatus.PlayCount++;

                        btn.Tag = "X";

                        CheckWinner();

                        break;

                    case enPlayer.Player2:

                        Image img = Image.FromFile(@"C:\Users\hp\Downloads\o.jpg");

                        // Resize the image to fit the button size
                        Bitmap resizedImage = new Bitmap(img, btn.Width, btn.Height);

                        btn.Image = resizedImage;
                        btn.ImageAlign = ContentAlignment.MiddleCenter;
                        btn.Text = "";


                        PlayerTurn = enPlayer.Player1;

                        lbl_turn.Text = "Player 1";

                        GameStatus.PlayCount++;

                        btn.Tag = "O";

                        CheckWinner();

                        break;

                }

            }
            else
            {
                MessageBox.Show("Wrong Choice", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (GameStatus.PlayCount == 9) // 9 BOX
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }

        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.White;
            Pen pen = new Pen(White, 10);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            e.Graphics.DrawLine(pen, 300, 220, 700, 220);
            e.Graphics.DrawLine(pen, 300, 320, 700, 320);


            e.Graphics.DrawLine(pen, 430, 120, 430, 420);
            e.Graphics.DrawLine(pen, 570, 120, 570, 420);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            ChangeImage((Button) sender);
        }


        private void ResetButton(Button btn)
        {

            Image img = Image.FromFile(@"C:\Users\hp\Downloads\qques.jpg");

            // Resize it to match button size
            Bitmap resizedImage = new Bitmap(img, button1.Width, button1.Height);

            // Set the resized image to the button
            btn.Image = resizedImage;
            btn.ImageAlign = ContentAlignment.MiddleCenter;

            // remove text if you want only the image
            button1.Text = "";


            btn.BackColor = Color.Transparent;
            btn.Tag = "?";
        }

        void RestartGame()
        {
            ResetButton(button1);
            ResetButton(button2);
            ResetButton(button3);
            ResetButton(button4);
            ResetButton(button5);
            ResetButton(button6);
            ResetButton(button7);
            ResetButton(button8);
            ResetButton(button9);

            PlayerTurn = enPlayer.Player1;
            lbl_turn.Text = "Player 1";
            lblWinner.Text = "In Progress";
            GameStatus.PlayCount = 0;
            GameStatus.Winner = enWinner.GameInProgress;
            GameStatus.GameOver = false;

        }

        private void btn_RestartGame_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
