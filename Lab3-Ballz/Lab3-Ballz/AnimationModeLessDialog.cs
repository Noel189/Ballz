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
    public partial class AnimationModeLessDialog : Form
    {
        public delegate void delCloseForm(CheckBox cbx);
        public delegate void delAnimationChanged(int value);
        public delCloseForm delClose = null;
        public delAnimationChanged delAnimation = null;
        CheckBox cb = null;
        public CheckBox SetValue
        {
            set
            {
                cb = value;
            }
        }
        public AnimationModeLessDialog()
        {
            InitializeComponent();
        }

        private void AnimationModeLessDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
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

        private void UI_AnimationSpeed_Tbr_ValueChanged(object sender, EventArgs e)
        {
            if(delAnimation != null)
            {
                //invoke the delegate as a method
                delAnimation(UI_AnimationSpeed_Tbr.Value);
            }
        }
    }
}
