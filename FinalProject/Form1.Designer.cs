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
            this.btnExit.Location = new System.Drawing.Point(178, 232);
            this.btnExit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 33);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(45, 232);
            this.btnStart.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(68, 35);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(80, 135);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(176, 37);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Push up arrow key to move up and down arrow key to move down";
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.SystemColors.Highlight;
            this.pbPlayer.Location = new System.Drawing.Point(45, 135);
            this.pbPlayer.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(19, 21);
            this.pbPlayer.TabIndex = 3;
            this.pbPlayer.TabStop = false;
            // 
            // pbEnemy1
            // 
            this.pbEnemy1.BackColor = System.Drawing.Color.Red;
            this.pbEnemy1.Location = new System.Drawing.Point(442, 88);
            this.pbEnemy1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pbEnemy1.Name = "pbEnemy1";
            this.pbEnemy1.Size = new System.Drawing.Size(38, 84);
            this.pbEnemy1.TabIndex = 4;
            this.pbEnemy1.TabStop = false;
            // 
            // lblEnemyDesc
            // 
            this.lblEnemyDesc.AutoSize = true;
            this.lblEnemyDesc.Location = new System.Drawing.Point(425, 173);
            this.lblEnemyDesc.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEnemyDesc.Name = "lblEnemyDesc";
            this.lblEnemyDesc.Size = new System.Drawing.Size(76, 13);
            this.lblEnemyDesc.TabIndex = 5;
            this.lblEnemyDesc.Text = "Avoid enemies";
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 291);
            this.Controls.Add(this.lblEnemyDesc);
            this.Controls.Add(this.pbEnemy1);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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

