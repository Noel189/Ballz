using System;
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
    
        SelectDifficultyModalDialog dialog=null;
        AnimationModeLessDialog animationModeLessDialog = null;
        ScoreModeLessDialog scoreModeLessDialog = null;
        public Form1()
        {
            InitializeComponent();
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

                    UI_Play_Btn.Enabled = false; //disable play button
                   
                }
                else if(DialogResult==DialogResult.Cancel)
                {
                    dialog.Close();
                    dialog = null;
                }
            }

        }

        private void UI_ShowScore_Cbx_CheckedChanged(object sender, EventArgs e)
        {
            
            if (scoreModeLessDialog==null)
            {
                scoreModeLessDialog = new ScoreModeLessDialog();
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
