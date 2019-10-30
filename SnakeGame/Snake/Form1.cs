using System;
using System.Windows.Forms;

namespace Snake
{   
    public partial class Form1 : Form
    {

        Snake mySnake;
        Board mainBoard;
        Rewards apples;

        //test
        bool isPaused = false;
        bool isStarted = false;

        string mode;
        Timer clock;
        int duration; //How long the game has been running
        int speed = 500; //500ms
        int score;
        int level;
        int foodIncrement = 1;

        //Sounds
        System.Media.SoundPlayer eatFood = new System.Media.SoundPlayer(Resource1.eatFood);
        System.Media.SoundPlayer startGame = new System.Media.SoundPlayer(Resource1.startGame);
        System.Media.SoundPlayer endGame = new System.Media.SoundPlayer(Resource1.endGame);


        public Form1()
        {
            InitializeComponent();

            //You don't have to worry about the auto-size
            this.AutoSize = true;       //The size of the Form will autoadjust.
            boardPanel.AutoSize = true; //The size of the panel grouping all the squares will auto-adjust

            //Set up the main board
            mainBoard = new Board(this);

            //Set up the game timer at the given speed
            clock = new Timer();
            clock.Interval = speed; //Set the clock to tick every 500ms
            clock.Tick += new EventHandler(refresh); //Call the refresh method at every tick to redraw the board and snake.

            //setup the highscorre class
            highscore hs = new highscore();

            duration = 0;
            score = 0;
            level = 1;
            levelLBL.Text = Convert.ToString(level);
            scoreLBL.Text = Convert.ToString(score);

            gotoNextLevel(level);

        }

        private void gotoNextLevel(int nextLevel)
        {
            mode = "REST";
            mySnake = new Snake(mainBoard); //Brand new snake with length 1
            apples = new Rewards(5 + foodIncrement++, mainBoard); //<--- Generate 5 apples
            startGame.Play();
        }


        private string moveSnake()
        {
            string result = "";
            if(GameInput.PressedKey(Keys.Up)) { result = "UP"; }
            else if(GameInput.PressedKey(Keys.Down)) { result = "DOWN"; }
            else if (GameInput.PressedKey(Keys.Left)) { result = "LEFT"; }
            else if (GameInput.PressedKey(Keys.Right)) { result = "RIGHT"; }
            else { result = "REST"; }
            return result;
        }

        private void refresh(Object myObject, EventArgs myEventArgs)
        {
            if(!isPaused)
            {
                mySnake.move(mode); //Move the snake based on mode
            }
            

            mainBoard.draw();
            apples.draw();  //<----- draw apples
            mySnake.draw();

            //increment the duration by amount of time that has passed
            //this method is called every speed millisecond
            duration += speed;
            timerLBL.Text = Convert.ToString(duration / 1000); //Show time passed

            //Check if snke is biting itself. If so, call GameOver.
            if (mySnake.checkEatItself() == true)
            {
                GameOver();
            }
            else if (apples.checkIFSnakeEatApple(mySnake) == true)
            {
                eatFood.Play();

                score += apples.eatAppleAtPostion(mySnake.getHeadPosition());

                scoreLBL.Text = Convert.ToString(score);


                if (apples.noMoreApples() == true)
                {
                    isStarted = false;
                    clock.Stop();
                    level++;
                    levelLBL.Text = Convert.ToString(level);
                    gotoNextLevel(level);
                    MessageBox.Show("Press enter to go to Level " + level, "Congrats");
                    clock.Interval = speed -= 100;
                }
                else
                {
                    //Length the snake and continue with the Game
                    mySnake.extendBody();
                }
            }
        }

        private void startBTN_Click(object sender, EventArgs e) { clock.Start(); isStarted = true; }
        private void pauseBTN_Click(object sender, EventArgs e) { clock.Stop(); isPaused = true; }

        private void resetGame()
        {
            level = 0;
            score = 0;
            clock.Stop();
            clock.Start();
        }
        private void GameOver()
        {
            isStarted = false;
            clock.Stop();
            endGame.Play();
            highscore.setHighscore(score);
            highscore.getScoreReport(score);
            this.Close();
        }
        private void pauseGame()
        {
            if(GameInput.PressedKey(Keys.Space))
            {
                string tmp = mode;
                
                isPaused = !isPaused;
                pauseLBL.Visible = !pauseLBL.Visible;
                if (!isPaused)
                {
                    tmp = mode;
                }
                else
                {
                    mode = tmp;
                }
            }
        }

        private void finishBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new settings().Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            GameInput.ChangeState(e.KeyCode, true);
            mode = moveSnake();
            lblDebug.Text = mode;
            if (!isStarted || isPaused)
            {
                if (GameInput.PressedKey(Keys.Enter))
                {
                    clock.Start(); isStarted = true;
                }
            }
            if (!isPaused && isStarted)
            {
                mode = moveSnake();
            }
            pauseGame();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            GameInput.ChangeState(e.KeyCode, false);
        }
    }
}
