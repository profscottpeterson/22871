﻿namespace FinalProject
{
    partial class VictoryScreen
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
            this.lblWin = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.setTimeWinTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(239, 187);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(1);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(74, 34);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(396, 187);
            this.btnExit.Margin = new System.Windows.Forms.Padding(1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 34);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.Location = new System.Drawing.Point(185, 95);
            this.lblWin.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(333, 31);
            this.lblWin.TabIndex = 2;
            this.lblWin.Text = "Congratulations, you Win!!";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(236, 146);
            this.time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(33, 13);
            this.time.TabIndex = 5;
            this.time.Text = "Time:";
            // 
            // setTimeWinTxtBox
            // 
            this.setTimeWinTxtBox.Location = new System.Drawing.Point(273, 143);
            this.setTimeWinTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.setTimeWinTxtBox.Name = "setTimeWinTxtBox";
            this.setTimeWinTxtBox.ReadOnly = true;
            this.setTimeWinTxtBox.Size = new System.Drawing.Size(171, 20);
            this.setTimeWinTxtBox.TabIndex = 6;
            // 
            // VictoryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.setTimeWinTxtBox);
            this.Controls.Add(this.time);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VictoryScreen";
            this.Text = "VictoryScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.TextBox setTimeWinTxtBox;
    }
}