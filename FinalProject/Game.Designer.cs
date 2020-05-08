﻿namespace FinalProject
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.pbSky = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.timerMoveEnemy = new System.Windows.Forms.Timer(this.components);
            this.timerMakeEnemy = new System.Windows.Forms.Timer(this.components);
            this.pbRoof = new System.Windows.Forms.PictureBox();
            this.pbGround = new System.Windows.Forms.PictureBox();
            this.countTime = new System.Windows.Forms.Timer(this.components);
            this.timerCountLab = new System.Windows.Forms.Label();
            this.timerPlayerFalls = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoof)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSky
            // 
            this.pbSky.Image = ((System.Drawing.Image)(resources.GetObject("pbSky.Image")));
            this.pbSky.Location = new System.Drawing.Point(0, 0);
            this.pbSky.Margin = new System.Windows.Forms.Padding(8);
            this.pbSky.Name = "pbSky";
            this.pbSky.Size = new System.Drawing.Size(1826, 727);
            this.pbSky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSky.TabIndex = 5;
            this.pbSky.TabStop = false;
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayer.Image")));
            this.pbPlayer.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbPlayer.InitialImage")));
            this.pbPlayer.Location = new System.Drawing.Point(64, 364);
            this.pbPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(70, 62);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            // 
            // timerMoveEnemy
            // 
            this.timerMoveEnemy.Enabled = true;
            this.timerMoveEnemy.Tick += new System.EventHandler(this.timerMoveEnemy_Tick);
            // 
            // timerMakeEnemy
            // 
            this.timerMakeEnemy.Enabled = true;
            this.timerMakeEnemy.Interval = 3500;
            this.timerMakeEnemy.Tick += new System.EventHandler(this.timerMakeEnemy_Tick);
            // 
            // pbRoof
            // 
            this.pbRoof.BackColor = System.Drawing.Color.Black;
            this.pbRoof.Location = new System.Drawing.Point(0, -48);
            this.pbRoof.Margin = new System.Windows.Forms.Padding(2);
            this.pbRoof.Name = "pbRoof";
            this.pbRoof.Size = new System.Drawing.Size(1826, 48);
            this.pbRoof.TabIndex = 4;
            this.pbRoof.TabStop = false;
            // 
            // pbGround
            // 
            this.pbGround.BackColor = System.Drawing.Color.Transparent;
            this.pbGround.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbGround.BackgroundImage")));
            this.pbGround.Image = ((System.Drawing.Image)(resources.GetObject("pbGround.Image")));
            this.pbGround.Location = new System.Drawing.Point(0, 725);
            this.pbGround.Margin = new System.Windows.Forms.Padding(2);
            this.pbGround.Name = "pbGround";
            this.pbGround.Size = new System.Drawing.Size(1826, 141);
            this.pbGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGround.TabIndex = 3;
            this.pbGround.TabStop = false;
            // 
            // countTime
            // 
            this.countTime.Enabled = true;
            this.countTime.Interval = 1000;
            this.countTime.Tick += new System.EventHandler(this.countTime_Tick);
            // 
            // timerCountLab
            // 
            this.timerCountLab.AutoSize = true;
            this.timerCountLab.Location = new System.Drawing.Point(1294, 21);
            this.timerCountLab.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.timerCountLab.Name = "timerCountLab";
            this.timerCountLab.Size = new System.Drawing.Size(177, 32);
            this.timerCountLab.TabIndex = 0;
            this.timerCountLab.Text = "TimerCounts";
            // 
            // timerPlayerFalls
            // 
            this.timerPlayerFalls.Enabled = true;
            this.timerPlayerFalls.Tick += new System.EventHandler(this.timerPlayerFalls_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1824, 860);
            this.Controls.Add(this.timerCountLab);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.pbGround);
            this.Controls.Add(this.pbRoof);
            this.Controls.Add(this.pbSky);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbSky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoof)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Timer timerMoveEnemy;
        private System.Windows.Forms.Timer timerMakeEnemy;
        private System.Windows.Forms.PictureBox pbRoof;
        private System.Windows.Forms.PictureBox pbGround;
        private System.Windows.Forms.Timer countTime;
        private System.Windows.Forms.Label timerCountLab;
        private System.Windows.Forms.Timer timerPlayerFalls;
        private System.Windows.Forms.PictureBox pbSky;
    }
}