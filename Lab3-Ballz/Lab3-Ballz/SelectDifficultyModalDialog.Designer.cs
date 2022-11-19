namespace Lab3_Ballz
{
    partial class SelectDifficultyModalDialog
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UI_Hard_Rbn = new System.Windows.Forms.RadioButton();
            this.UI_Medium_Rbn = new System.Windows.Forms.RadioButton();
            this.UI_Easy_Rbn = new System.Windows.Forms.RadioButton();
            this.UI_Ok_Btn = new System.Windows.Forms.Button();
            this.UI_Cancel_Btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UI_Hard_Rbn);
            this.groupBox1.Controls.Add(this.UI_Medium_Rbn);
            this.groupBox1.Controls.Add(this.UI_Easy_Rbn);
            this.groupBox1.Location = new System.Drawing.Point(38, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Difficulty";
            // 
            // UI_Hard_Rbn
            // 
            this.UI_Hard_Rbn.AutoSize = true;
            this.UI_Hard_Rbn.Location = new System.Drawing.Point(6, 121);
            this.UI_Hard_Rbn.Name = "UI_Hard_Rbn";
            this.UI_Hard_Rbn.Size = new System.Drawing.Size(58, 20);
            this.UI_Hard_Rbn.TabIndex = 3;
            this.UI_Hard_Rbn.Text = "Hard";
            this.UI_Hard_Rbn.UseVisualStyleBackColor = true;
            this.UI_Hard_Rbn.CheckedChanged += new System.EventHandler(this.SelectDifficulty_Radio);
            // 
            // UI_Medium_Rbn
            // 
            this.UI_Medium_Rbn.AutoSize = true;
            this.UI_Medium_Rbn.Location = new System.Drawing.Point(6, 77);
            this.UI_Medium_Rbn.Name = "UI_Medium_Rbn";
            this.UI_Medium_Rbn.Size = new System.Drawing.Size(76, 20);
            this.UI_Medium_Rbn.TabIndex = 2;
            this.UI_Medium_Rbn.Text = "Medium";
            this.UI_Medium_Rbn.UseVisualStyleBackColor = true;
            this.UI_Medium_Rbn.CheckedChanged += new System.EventHandler(this.SelectDifficulty_Radio);
            // 
            // UI_Easy_Rbn
            // 
            this.UI_Easy_Rbn.AutoSize = true;
            this.UI_Easy_Rbn.Checked = true;
            this.UI_Easy_Rbn.Location = new System.Drawing.Point(6, 30);
            this.UI_Easy_Rbn.Name = "UI_Easy_Rbn";
            this.UI_Easy_Rbn.Size = new System.Drawing.Size(59, 20);
            this.UI_Easy_Rbn.TabIndex = 1;
            this.UI_Easy_Rbn.TabStop = true;
            this.UI_Easy_Rbn.Text = "Easy";
            this.UI_Easy_Rbn.UseVisualStyleBackColor = true;
            this.UI_Easy_Rbn.CheckedChanged += new System.EventHandler(this.SelectDifficulty_Radio);
            // 
            // UI_Ok_Btn
            // 
            this.UI_Ok_Btn.Location = new System.Drawing.Point(38, 227);
            this.UI_Ok_Btn.Name = "UI_Ok_Btn";
            this.UI_Ok_Btn.Size = new System.Drawing.Size(106, 36);
            this.UI_Ok_Btn.TabIndex = 1;
            this.UI_Ok_Btn.Text = "OK";
            this.UI_Ok_Btn.UseVisualStyleBackColor = true;
            this.UI_Ok_Btn.Click += new System.EventHandler(this.UI_Ok_Btn_Click);
            // 
            // UI_Cancel_Btn
            // 
            this.UI_Cancel_Btn.Location = new System.Drawing.Point(223, 227);
            this.UI_Cancel_Btn.Name = "UI_Cancel_Btn";
            this.UI_Cancel_Btn.Size = new System.Drawing.Size(106, 36);
            this.UI_Cancel_Btn.TabIndex = 2;
            this.UI_Cancel_Btn.Text = "Cancel";
            this.UI_Cancel_Btn.UseVisualStyleBackColor = true;
            this.UI_Cancel_Btn.Click += new System.EventHandler(this.UI_Cancel_Btn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SelectDifficultyModalDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 296);
            this.Controls.Add(this.UI_Cancel_Btn);
            this.Controls.Add(this.UI_Ok_Btn);
            this.Controls.Add(this.groupBox1);
            this.Name = "SelectDifficultyModalDialog";
            this.Text = "SelectDifficultyModalDialog";
            this.Load += new System.EventHandler(this.SelectDifficulty_Radio);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton UI_Hard_Rbn;
        private System.Windows.Forms.RadioButton UI_Medium_Rbn;
        private System.Windows.Forms.RadioButton UI_Easy_Rbn;
        private System.Windows.Forms.Button UI_Ok_Btn;
        private System.Windows.Forms.Button UI_Cancel_Btn;
        private System.Windows.Forms.Timer timer1;
    }
}