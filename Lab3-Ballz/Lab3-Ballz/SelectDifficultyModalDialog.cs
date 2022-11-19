using GDIDrawer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Lab3_Ballz
{
    public partial class SelectDifficultyModalDialog : Form
    {
       public string gameDifficulty;
      public  const int WIDTH=800;
       public const int HEIGHT=600;
      public  const int BALL_SIZE=50;
       public const int ROW_COUNT=HEIGHT/BALL_SIZE;
      public  const int COLUMN_COUNT=WIDTH/BALL_SIZE;
        public int xPosition = 0;
        public int yPosition = 0;
        int numberOfBallsKilled;
        int score;
        Point pos;
        int row;
        int col;
        int count = 1;
        public delegate void delScore(int score);
        public delScore delScoreUpdate = null;
        ScoreModeLessDialog scoreModeLessDialog1 = new ScoreModeLessDialog();

        //create a cdrawer object 
        public  CDrawer drawer = new CDrawer();
        //create an enum that holds state of an object
        public enum StateOfObjects
        {
            Alive=0,Dead=1
        };
        public SelectDifficultyModalDialog()
        {
            InitializeComponent();
        }

        public struct GameElements
        {
            public Color ballColor;
            public StateOfObjects stateOfObject; 

            public GameElements(Color ballColor,StateOfObjects stateOfObjects)
            {
                this.ballColor = ballColor;
                this.stateOfObject = stateOfObjects;
            }
        }

     public  GameElements[,] gameElements = new GameElements[ROW_COUNT, COLUMN_COUNT];
        private void UI_Ok_Btn_Click(object sender, EventArgs e)
        {
            //start the timer
            timer1.Enabled = true;
            DialogResult = DialogResult.OK;
            Randomize();

        }

        private void Randomize()
        {
            //declare an array of 5 colors
            Color[] colorArray = { Color.Red, Color.Yellow, Color.Blue,Color.Green,Color.Purple };
            //declare a 2d array of type struct
           
            GameElements gameElem;
            Array.Clear(gameElements, 0, gameElements.Length);
            Random random = new Random();
         
            //Game created using the selected mode
            if (gameDifficulty == UI_Easy_Rbn.Text)
            {
                //use 3 ball colors
                //iteratte through the two dimensional array
                for (int row = 0; row < gameElements.GetLength(0); row++)
                {
                    for (int col = 0; col < gameElements.GetLength(1); col++)
                    {
                        gameElem.stateOfObject = StateOfObjects.Alive;
                        gameElem.ballColor = colorArray[random.Next(3)];

                        //create the struct
                        gameElements[row, col] = new GameElements(gameElem.ballColor, gameElem.stateOfObject);

                    }
                }
            }
            else if (gameDifficulty == UI_Medium_Rbn.Text)
            {
                //use 4 bll colors
                //iteratte through the two dimensional array
                for (int row = 0; row < gameElements.GetLength(0); row++)
                {
                    for (int col = 0; col < gameElements.GetLength(1); col++)
                    {
                        gameElem.stateOfObject = StateOfObjects.Alive;
                        gameElem.ballColor = colorArray[random.Next(4)];

                        //create the struct
                        gameElements[row, col] = new GameElements(gameElem.ballColor, gameElem.stateOfObject);

                    }
                }
            }
            else if (gameDifficulty == UI_Hard_Rbn.Text)
            {
                //use 5 ball colors
                //iteratte through the two dimensional array
                for (int row = 0; row < gameElements.GetLength(0); row++)
                {
                    for (int col = 0; col < gameElements.GetLength(1); col++)
                    {
                        gameElem.stateOfObject = StateOfObjects.Alive;
                        gameElem.ballColor = colorArray[random.Next(5)];

                        //create the struct and push the value to the two dimensional array
                        gameElements[row, col] = new GameElements(gameElem.ballColor, gameElem.stateOfObject);

                    }
                }
                
            }

            Display(gameElements);
        }

        private void SelectDifficulty_Radio(object sender, EventArgs e)
        {
            //select difficulty level
            if(UI_Easy_Rbn.Checked)
            {
                gameDifficulty = UI_Easy_Rbn.Text;
            }
            else if(UI_Medium_Rbn.Checked)
            {
                gameDifficulty=UI_Medium_Rbn.Text;  
            }
            else if(UI_Hard_Rbn.Checked)
            {
                gameDifficulty= UI_Hard_Rbn.Text;   
            }
        }

        private void Display(GameElements[,] games)
        {
            drawer.Clear();
            for(int row=0; row<games.GetLength(0); row++)
            {
            
                for (int col = 0; col < games.GetLength(1); col++)
                {


                    if (games[row,col].stateOfObject==StateOfObjects.Alive)
                    {

                        if(yPosition >= HEIGHT)
                        {
                            yPosition = 0;
                        }

                             if((col*BALL_SIZE)<WIDTH && yPosition < HEIGHT)
                        {
                            drawer.AddEllipse(col * BALL_SIZE, yPosition, BALL_SIZE, BALL_SIZE, games[row, col].ballColor);
                        }
                 
                    }
                  
         }
                yPosition += BALL_SIZE;
            }
           
        }

        private void UI_Cancel_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //  dialog.drawer.MouseLeftClick += Canvas_MouseLeftClick;
            bool isValid = drawer.GetLastMouseLeftClick(out pos);
            if (isValid)
            {
                score += Pick();
                MessageBox.Show($"{score}");
                scoreModeLessDialog1.SetScore = score;
               
            }

            //call BallsAlive and check for a zero return value
            int value = BallsAlive();

            if (value == 0)
            {
                timer1.Enabled = false;
            }

        }

        private int Pick()
        {
            int score = 0;
            col = pos.X / SelectDifficultyModalDialog.BALL_SIZE;
            row = pos.Y / SelectDifficultyModalDialog.BALL_SIZE;
            if (gameElements[row, col].stateOfObject == SelectDifficultyModalDialog.StateOfObjects.Dead)
            {

            }
            else
            {
                score = CheckBalls(row, col,gameElements[row, col].ballColor);
            }

            return score;
        }

        private int CheckBalls(int row, int col, Color ballColor)
        {
            if (row > 11 || col > 15 || row < 0 || col < 0)
            {
                return 0;
            }
            else if (gameElements[row, col].stateOfObject == SelectDifficultyModalDialog.StateOfObjects.Dead)
            {
                return 0;
            }
            else if (gameElements[row, col].ballColor != ballColor)
            {
                return 0;
            }
            else
            {
                gameElements[row, col].stateOfObject = SelectDifficultyModalDialog.StateOfObjects.Dead;
                numberOfBallsKilled += 1;

            }

            //make the recursive calls
            CheckBalls(row + 1, col, ballColor);//down
            CheckBalls(row - 1, col, ballColor);//up
            CheckBalls(row, col + 1, ballColor);//right
            CheckBalls(row, col - 1, ballColor);//left

            return numberOfBallsKilled;
        }

        private void Canvas_MouseLeftClick(Point pos, CDrawer dr)
        {


            score += Pick();

            // MessageBox.Show(score.ToString());
        }

        private int BallsAlive()
        {

            return count;


        }
    }
}
