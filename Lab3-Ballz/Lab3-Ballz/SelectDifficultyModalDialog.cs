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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Lab3_Ballz
{
    public partial class SelectDifficultyModalDialog : Form
    {
        /*   TEST
        public const int WIDTH = 200;
        public const int HEIGHT = 100;
        */
        public string gameDifficulty;
      public  const int WIDTH=800;
       public const int HEIGHT=600;
      public  const int BALL_SIZE=50;
       public const int ROW_COUNT=HEIGHT/BALL_SIZE;
      public  const int COLUMN_COUNT=WIDTH/BALL_SIZE;
        public int xPosition = 0;
        public int yPosition = 0;
   
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

        public void Display(GameElements[,] games)
        {
            drawer.Clear();
            for(int row=0; row<games.GetLength(0); row++)
            {
            
                for (int col = 0; col < games.GetLength(1); col++)
                {


                    if (games[row,col].stateOfObject==StateOfObjects.Alive)
                    {


                            drawer.AddEllipse(col * BALL_SIZE, row*BALL_SIZE, BALL_SIZE, BALL_SIZE, games[row, col].ballColor);

                 
                    }
                  
         }
                
            }
           
        }

        private void UI_Cancel_Btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; 
        }
    }
}
