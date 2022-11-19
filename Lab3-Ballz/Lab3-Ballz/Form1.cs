﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;
using System.Diagnostics;
using System.Security.Cryptography;
using static Lab3_Ballz.SelectDifficultyModalDialog;

namespace Lab3_Ballz
{
    public partial class Form1 : Form
    {
        //declare an object of the modal dialog
        ScoreModeLessDialog scoreModeLessDialog = new ScoreModeLessDialog();
        SelectDifficultyModalDialog dialog=null;
        AnimationModeLessDialog animationModeLessDialog = null;
        //ScoreModeLessDialog scoreModeLessDialog = null;
        Stopwatch stopwatch=null;   
        int row;
        int col;
        int count = 1;
        int numberOfBallsKilled;
        int score;
        Point pos;
        public Form1()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
        }

        private void UI_Play_Btn_Click(object sender, EventArgs e)
        {
            if(dialog==null)
            {
                //create an object of the modal dialog
                dialog = new SelectDifficultyModalDialog();
                DialogResult = dialog.ShowDialog(); //show dialog and save the dialog result
                if(DialogResult==DialogResult.OK)
                {
                    dialog.Close();//closes the dialog

                    //start the timer
                    timer1.Enabled = true;

                    UI_Play_Btn.Enabled = false; //disable play button
                   
                }
                else if(DialogResult==DialogResult.Cancel)
                {
                    dialog.Close();
                    dialog = null;
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //  dialog.drawer.MouseLeftClick += Canvas_MouseLeftClick;
            bool isValid = dialog.drawer.GetLastMouseLeftClick(out pos);
            if(isValid)
            {
                score += Pick();
                scoreModeLessDialog.SetScore = score;

            }
    
            //call BallsAlive and check for a zero return value
            int value = BallsAlive();

            if(value==0)
            {
                timer1.Enabled = false; 
            }
     
        }

        private int Pick()
        {
                int score = 0;
                col = pos.X / SelectDifficultyModalDialog.BALL_SIZE;
                row = pos.Y / SelectDifficultyModalDialog.BALL_SIZE;
                if(dialog.gameElements[row, col].stateOfObject == SelectDifficultyModalDialog.StateOfObjects.Dead)
                {

                }
                else
                {
                  score =  CheckBalls(row, col, dialog.gameElements[row, col].ballColor);
                }
            
            return score;
        }

        private int CheckBalls(int row, int col, Color ballColor)
        {
            if (row >  11 || col>15 || row <0 || col<0)
            { 
             return 0;
            }
        else if (dialog.gameElements[row, col].stateOfObject == SelectDifficultyModalDialog.StateOfObjects.Dead)
            {
                return 0;
            }
      else   if (dialog.gameElements[row,col].ballColor != ballColor)
            {
                return 0;
            }
            else
            {
    
                dialog.gameElements[row, col].stateOfObject = SelectDifficultyModalDialog.StateOfObjects.Dead;
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

        private void UI_ShowScore_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            
            if (scoreModeLessDialog!=null)
            {
              
                scoreModeLessDialog.SetValue = (CheckBox)sender;
                
                scoreModeLessDialog.delClose = UncheckTheBox;
                
            }
          
            scoreModeLessDialog.Show();
        }

        private void UncheckTheBox(CheckBox cbx)
        {
            if (cbx == UI_ShowScore_Cbx)
            {
                UI_ShowScore_Cbx.Checked = false;
            }
            else if(cbx == UI_ShowAnimSpeed_Cbx)
            {
                UI_ShowAnimSpeed_Cbx.Checked = false;
            }
            
        }

        private void UI_ShowAnimSpeed_Cbx_CheckedChanged(object sender, EventArgs e)
        {

            if (animationModeLessDialog == null)
            {
                animationModeLessDialog = new AnimationModeLessDialog();
                animationModeLessDialog.SetValue = (CheckBox)sender;
                animationModeLessDialog.delClose = UncheckTheBox;

            }
            animationModeLessDialog.Show();
        }
    }
}
