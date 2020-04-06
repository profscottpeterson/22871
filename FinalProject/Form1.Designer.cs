namespace FinalProject
{
    partial class FormMainMenu
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbEnemy1 = new System.Windows.Forms.PictureBox();
            this.lblEnemyDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(475, 554);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(207, 79);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(119, 554);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(182, 83);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(212, 323);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(470, 88);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Push up arrow key to move up and down arrow key to move down";
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.SystemColors.Highlight;
            this.pbPlayer.Location = new System.Drawing.Point(119, 323);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(50, 50);
            this.pbPlayer.TabIndex = 3;
            this.pbPlayer.TabStop = false;
            // 
            // pbEnemy1
            // 
            this.pbEnemy1.BackColor = System.Drawing.Color.Red;
            this.pbEnemy1.Location = new System.Drawing.Point(1178, 211);
            this.pbEnemy1.Name = "pbEnemy1";
            this.pbEnemy1.Size = new System.Drawing.Size(100, 200);
            this.pbEnemy1.TabIndex = 4;
            this.pbEnemy1.TabStop = false;
            // 
            // lblEnemyDesc
            // 
            this.lblEnemyDesc.AutoSize = true;
            this.lblEnemyDesc.Location = new System.Drawing.Point(1172, 429);
            this.lblEnemyDesc.Name = "lblEnemyDesc";
            this.lblEnemyDesc.Size = new System.Drawing.Size(202, 32);
            this.lblEnemyDesc.TabIndex = 5;
            this.lblEnemyDesc.Text = "Avoid enemies";
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 694);
            this.Controls.Add(this.lblEnemyDesc);
            this.Controls.Add(this.pbEnemy1);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.Name = "FormMainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbEnemy1;
        private System.Windows.Forms.Label lblEnemyDesc;
    }
}

