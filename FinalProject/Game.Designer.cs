namespace FinalProject
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
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.timerMoveEnemy = new System.Windows.Forms.Timer(this.components);
            this.pbTree = new System.Windows.Forms.PictureBox();
            this.timerMakeEnemy = new System.Windows.Forms.Timer(this.components);
            this.pbRoof = new System.Windows.Forms.PictureBox();
            this.pbGround = new System.Windows.Forms.PictureBox();
            this.countTime = new System.Windows.Forms.Timer(this.components);
            this.timerCountLab = new System.Windows.Forms.Label();
            this.timerPlayerFalls = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoof)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.SystemColors.Highlight;
            this.pbPlayer.Location = new System.Drawing.Point(66, 215);
            this.pbPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(50, 50);
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            // 
            // timerMoveEnemy
            // 
            this.timerMoveEnemy.Enabled = true;
            this.timerMoveEnemy.Interval = 50;
            this.timerMoveEnemy.Tick += new System.EventHandler(this.timerMoveEnemy_Tick);
            // 
            // pbTree
            // 
            this.pbTree.BackColor = System.Drawing.Color.Tan;
            this.pbTree.Location = new System.Drawing.Point(815, 630);
            this.pbTree.Margin = new System.Windows.Forms.Padding(2);
            this.pbTree.Name = "pbTree";
            this.pbTree.Size = new System.Drawing.Size(30, 111);
            this.pbTree.TabIndex = 1;
            this.pbTree.TabStop = false;
            // 
            // timerMakeEnemy
            // 
            this.timerMakeEnemy.Enabled = true;
            this.timerMakeEnemy.Interval = 2000;
            this.timerMakeEnemy.Tick += new System.EventHandler(this.timerMakeEnemy_Tick);
            // 
            // pbRoof
            // 
            this.pbRoof.BackColor = System.Drawing.Color.Black;
            this.pbRoof.Location = new System.Drawing.Point(-4, -33);
            this.pbRoof.Margin = new System.Windows.Forms.Padding(2);
            this.pbRoof.Name = "pbRoof";
            this.pbRoof.Size = new System.Drawing.Size(1887, 46);
            this.pbRoof.TabIndex = 2;
            this.pbRoof.TabStop = false;
            // 
            // pbGround
            // 
            this.pbGround.BackColor = System.Drawing.Color.LightGreen;
            this.pbGround.Location = new System.Drawing.Point(-4, 733);
            this.pbGround.Margin = new System.Windows.Forms.Padding(2);
            this.pbGround.Name = "pbGround";
            this.pbGround.Size = new System.Drawing.Size(1887, 146);
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
            this.timerCountLab.Location = new System.Drawing.Point(1234, 17);
            this.timerCountLab.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.timerCountLab.Name = "timerCountLab";
            this.timerCountLab.Size = new System.Drawing.Size(177, 32);
            this.timerCountLab.TabIndex = 4;
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
            this.ClientSize = new System.Drawing.Size(1878, 876);
            this.Controls.Add(this.timerCountLab);
            this.Controls.Add(this.pbGround);
            this.Controls.Add(this.pbRoof);
            this.Controls.Add(this.pbTree);
            this.Controls.Add(this.pbPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoof)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Timer timerMoveEnemy;
        private System.Windows.Forms.PictureBox pbTree;
        private System.Windows.Forms.Timer timerMakeEnemy;
        private System.Windows.Forms.PictureBox pbRoof;
        private System.Windows.Forms.PictureBox pbGround;
        private System.Windows.Forms.Timer countTime;
        private System.Windows.Forms.Label timerCountLab;
        private System.Windows.Forms.Timer timerPlayerFalls;
    }
}