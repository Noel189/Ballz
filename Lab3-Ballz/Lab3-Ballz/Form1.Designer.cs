namespace Lab3_Ballz
{
    partial class Form1
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
            this.UI_ShowScore_Cbx = new System.Windows.Forms.CheckBox();
            this.UI_ShowAnimSpeed_Cbx = new System.Windows.Forms.CheckBox();
            this.UI_Play_Btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UI_ShowScore_Cbx
            // 
            this.UI_ShowScore_Cbx.AutoSize = true;
            this.UI_ShowScore_Cbx.Location = new System.Drawing.Point(198, 40);
            this.UI_ShowScore_Cbx.Name = "UI_ShowScore_Cbx";
            this.UI_ShowScore_Cbx.Size = new System.Drawing.Size(101, 20);
            this.UI_ShowScore_Cbx.TabIndex = 0;
            this.UI_ShowScore_Cbx.Text = "Show Score";
            this.UI_ShowScore_Cbx.UseVisualStyleBackColor = true;
            this.UI_ShowScore_Cbx.CheckedChanged += new System.EventHandler(this.UI_ShowScore_Cbx_CheckedChanged);
            // 
            // UI_ShowAnimSpeed_Cbx
            // 
            this.UI_ShowAnimSpeed_Cbx.AutoSize = true;
            this.UI_ShowAnimSpeed_Cbx.Location = new System.Drawing.Point(198, 102);
            this.UI_ShowAnimSpeed_Cbx.Name = "UI_ShowAnimSpeed_Cbx";
            this.UI_ShowAnimSpeed_Cbx.Size = new System.Drawing.Size(168, 20);
            this.UI_ShowAnimSpeed_Cbx.TabIndex = 1;
            this.UI_ShowAnimSpeed_Cbx.Text = "Show Animation Speed";
            this.UI_ShowAnimSpeed_Cbx.UseVisualStyleBackColor = true;
            this.UI_ShowAnimSpeed_Cbx.CheckedChanged += new System.EventHandler(this.UI_ShowAnimSpeed_Cbx_CheckedChanged);
            // 
            // UI_Play_Btn
            // 
            this.UI_Play_Btn.Location = new System.Drawing.Point(254, 148);
            this.UI_Play_Btn.Name = "UI_Play_Btn";
            this.UI_Play_Btn.Size = new System.Drawing.Size(193, 49);
            this.UI_Play_Btn.TabIndex = 2;
            this.UI_Play_Btn.Text = "Play";
            this.UI_Play_Btn.UseVisualStyleBackColor = true;
            this.UI_Play_Btn.Click += new System.EventHandler(this.UI_Play_Btn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 214);
            this.Controls.Add(this.UI_Play_Btn);
            this.Controls.Add(this.UI_ShowAnimSpeed_Cbx);
            this.Controls.Add(this.UI_ShowScore_Cbx);
            this.Name = "Form1";
            this.Text = "CMPE1666-Lab 3 -Ballz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox UI_ShowScore_Cbx;
        private System.Windows.Forms.CheckBox UI_ShowAnimSpeed_Cbx;
        private System.Windows.Forms.Button UI_Play_Btn;
        private System.Windows.Forms.Timer timer1;
    }
}

