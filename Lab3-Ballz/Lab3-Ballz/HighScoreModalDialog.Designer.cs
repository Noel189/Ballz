namespace Lab3_Ballz
{
    partial class HighScoreModalDialog
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
            this.UI_Ok_Btn = new System.Windows.Forms.Button();
            this.UI_Cancel_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UI_Player_Tbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UI_Ok_Btn
            // 
            this.UI_Ok_Btn.Location = new System.Drawing.Point(275, 158);
            this.UI_Ok_Btn.Name = "UI_Ok_Btn";
            this.UI_Ok_Btn.Size = new System.Drawing.Size(159, 37);
            this.UI_Ok_Btn.TabIndex = 0;
            this.UI_Ok_Btn.Text = "OK";
            this.UI_Ok_Btn.UseVisualStyleBackColor = true;
            // 
            // UI_Cancel_Btn
            // 
            this.UI_Cancel_Btn.Location = new System.Drawing.Point(553, 158);
            this.UI_Cancel_Btn.Name = "UI_Cancel_Btn";
            this.UI_Cancel_Btn.Size = new System.Drawing.Size(159, 37);
            this.UI_Cancel_Btn.TabIndex = 1;
            this.UI_Cancel_Btn.Text = "Cancel";
            this.UI_Cancel_Btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player Name:";
            // 
            // UI_Player_Tbx
            // 
            this.UI_Player_Tbx.Location = new System.Drawing.Point(275, 76);
            this.UI_Player_Tbx.Multiline = true;
            this.UI_Player_Tbx.Name = "UI_Player_Tbx";
            this.UI_Player_Tbx.Size = new System.Drawing.Size(437, 32);
            this.UI_Player_Tbx.TabIndex = 3;
            // 
            // HighScoreModalDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 256);
            this.Controls.Add(this.UI_Player_Tbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_Cancel_Btn);
            this.Controls.Add(this.UI_Ok_Btn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HighScoreModalDialog";
            this.Text = "High Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_Ok_Btn;
        private System.Windows.Forms.Button UI_Cancel_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UI_Player_Tbx;
    }
}