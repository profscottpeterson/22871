namespace FinalProject
{
    partial class GameOver
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
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.setTimeLoseTxtBox = new System.Windows.Forms.TextBox();
            this.rb4Minutes = new System.Windows.Forms.RadioButton();
            this.rb3Minutes = new System.Windows.Forms.RadioButton();
            this.rb2Minutes = new System.Windows.Forms.RadioButton();
            this.rb1Minute = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(632, 588);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(240, 95);
            this.btnNewGame.TabIndex = 5;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(933, 588);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(245, 95);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(613, 215);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(565, 113);
            this.lblGameOver.TabIndex = 2;
            this.lblGameOver.Text = "Game Over";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(627, 351);
            this.time.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(86, 32);
            this.time.TabIndex = 3;
            this.time.Text = "Time:";
            // 
            // setTimeLoseTxtBox
            // 
            this.setTimeLoseTxtBox.Location = new System.Drawing.Point(725, 346);
            this.setTimeLoseTxtBox.Margin = new System.Windows.Forms.Padding(5);
            this.setTimeLoseTxtBox.Name = "setTimeLoseTxtBox";
            this.setTimeLoseTxtBox.ReadOnly = true;
            this.setTimeLoseTxtBox.Size = new System.Drawing.Size(452, 38);
            this.setTimeLoseTxtBox.TabIndex = 7;
            this.setTimeLoseTxtBox.TabStop = false;
            // 
            // rb4Minutes
            // 
            this.rb4Minutes.AutoSize = true;
            this.rb4Minutes.Location = new System.Drawing.Point(897, 504);
            this.rb4Minutes.Name = "rb4Minutes";
            this.rb4Minutes.Size = new System.Drawing.Size(175, 36);
            this.rb4Minutes.TabIndex = 4;
            this.rb4Minutes.TabStop = true;
            this.rb4Minutes.Text = "4 Minutes";
            this.rb4Minutes.UseVisualStyleBackColor = true;
            // 
            // rb3Minutes
            // 
            this.rb3Minutes.AutoSize = true;
            this.rb3Minutes.Location = new System.Drawing.Point(633, 504);
            this.rb3Minutes.Name = "rb3Minutes";
            this.rb3Minutes.Size = new System.Drawing.Size(175, 36);
            this.rb3Minutes.TabIndex = 3;
            this.rb3Minutes.TabStop = true;
            this.rb3Minutes.Text = "3 Minutes";
            this.rb3Minutes.UseVisualStyleBackColor = true;
            // 
            // rb2Minutes
            // 
            this.rb2Minutes.AutoSize = true;
            this.rb2Minutes.Location = new System.Drawing.Point(897, 441);
            this.rb2Minutes.Name = "rb2Minutes";
            this.rb2Minutes.Size = new System.Drawing.Size(175, 36);
            this.rb2Minutes.TabIndex = 2;
            this.rb2Minutes.TabStop = true;
            this.rb2Minutes.Text = "2 Minutes";
            this.rb2Minutes.UseVisualStyleBackColor = true;
            // 
            // rb1Minute
            // 
            this.rb1Minute.AutoSize = true;
            this.rb1Minute.Checked = true;
            this.rb1Minute.Location = new System.Drawing.Point(633, 441);
            this.rb1Minute.Name = "rb1Minute";
            this.rb1Minute.Size = new System.Drawing.Size(161, 36);
            this.rb1Minute.TabIndex = 1;
            this.rb1Minute.TabStop = true;
            this.rb1Minute.Text = "1 Minute";
            this.rb1Minute.UseVisualStyleBackColor = true;
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1824, 861);
            this.Controls.Add(this.rb4Minutes);
            this.Controls.Add(this.rb3Minutes);
            this.Controls.Add(this.rb2Minutes);
            this.Controls.Add(this.rb1Minute);
            this.Controls.Add(this.setTimeLoseTxtBox);
            this.Controls.Add(this.time);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameOver";
            this.Text = "Game Over";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.TextBox setTimeLoseTxtBox;
        private System.Windows.Forms.RadioButton rb4Minutes;
        private System.Windows.Forms.RadioButton rb3Minutes;
        private System.Windows.Forms.RadioButton rb2Minutes;
        private System.Windows.Forms.RadioButton rb1Minute;
    }
}