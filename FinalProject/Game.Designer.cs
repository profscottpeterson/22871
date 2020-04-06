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
            this.pbEnemy1 = new System.Windows.Forms.PictureBox();
            this.timerMakeEnemy = new System.Windows.Forms.Timer(this.components);
            this.pbEnemy2 = new System.Windows.Forms.PictureBox();
            this.pbEnemy3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy3)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.SystemColors.Highlight;
            this.pbPlayer.Location = new System.Drawing.Point(66, 215);
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
            // pbEnemy1
            // 
            this.pbEnemy1.BackColor = System.Drawing.Color.Red;
            this.pbEnemy1.Location = new System.Drawing.Point(950, 0);
            this.pbEnemy1.Name = "pbEnemy1";
            this.pbEnemy1.Size = new System.Drawing.Size(100, 200);
            this.pbEnemy1.TabIndex = 1;
            this.pbEnemy1.TabStop = false;
            // 
            // timerMakeEnemy
            // 
            this.timerMakeEnemy.Interval = 2000;
            this.timerMakeEnemy.Tick += new System.EventHandler(this.timerMakeEnemy_Tick);
            // 
            // pbEnemy2
            // 
            this.pbEnemy2.BackColor = System.Drawing.Color.Red;
            this.pbEnemy2.Location = new System.Drawing.Point(950, 200);
            this.pbEnemy2.Name = "pbEnemy2";
            this.pbEnemy2.Size = new System.Drawing.Size(100, 200);
            this.pbEnemy2.TabIndex = 2;
            this.pbEnemy2.TabStop = false;
            // 
            // pbEnemy3
            // 
            this.pbEnemy3.BackColor = System.Drawing.Color.Red;
            this.pbEnemy3.Location = new System.Drawing.Point(950, 400);
            this.pbEnemy3.Name = "pbEnemy3";
            this.pbEnemy3.Size = new System.Drawing.Size(100, 200);
            this.pbEnemy3.TabIndex = 3;
            this.pbEnemy3.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 712);
            this.Controls.Add(this.pbEnemy3);
            this.Controls.Add(this.pbEnemy2);
            this.Controls.Add(this.pbEnemy1);
            this.Controls.Add(this.pbPlayer);
            this.Name = "Game";
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Timer timerMoveEnemy;
        private System.Windows.Forms.PictureBox pbEnemy1;
        private System.Windows.Forms.Timer timerMakeEnemy;
        private System.Windows.Forms.PictureBox pbEnemy2;
        private System.Windows.Forms.PictureBox pbEnemy3;
    }
}