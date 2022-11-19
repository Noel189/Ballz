namespace Lab3_Ballz
{
    partial class AnimationModeLessDialog
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
            this.UI_AnimationSpeed_Tbr = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UI_AnimationSpeed_Tbr)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_AnimationSpeed_Tbr
            // 
            this.UI_AnimationSpeed_Tbr.Location = new System.Drawing.Point(54, 80);
            this.UI_AnimationSpeed_Tbr.Maximum = 200;
            this.UI_AnimationSpeed_Tbr.Minimum = 10;
            this.UI_AnimationSpeed_Tbr.Name = "UI_AnimationSpeed_Tbr";
            this.UI_AnimationSpeed_Tbr.Size = new System.Drawing.Size(662, 56);
            this.UI_AnimationSpeed_Tbr.TabIndex = 0;
            this.UI_AnimationSpeed_Tbr.TickFrequency = 10;
            this.UI_AnimationSpeed_Tbr.Value = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "10 ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(672, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "200 ms";
            // 
            // AnimationModeLessDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 192);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_AnimationSpeed_Tbr);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnimationModeLessDialog";
            this.Text = "AnimationSpeed";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnimationModeLessDialog_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.UI_AnimationSpeed_Tbr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar UI_AnimationSpeed_Tbr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}