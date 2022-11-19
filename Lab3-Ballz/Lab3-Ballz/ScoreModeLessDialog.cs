using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Ballz
{
    public partial class ScoreModeLessDialog : Form
    {
        public delegate void delCloseForm(CheckBox cbx);
        public delCloseForm delClose = null;
        CheckBox cb = null;
        public CheckBox SetValue
        {
            set
            {
                cb = value;
            }
        }

        public int SetScore
        {
            set
            {
                //MessageBox.Show($"{value.ToString()}");
                UI_Score_Lbl.Text = value.ToString();

            }
        }

        public ScoreModeLessDialog()
        {
            InitializeComponent();
        }

        private void ScoreModeLessDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
         if(e.CloseReason == CloseReason.UserClosing)
            {
                if (delClose != null)
                {
                    //invoke the delegate like a method
                    delClose(cb);
                }

                //stop the close from happening
                e.Cancel = true;

                //hide the dialog
                Hide();
            }
        }

    }
}
