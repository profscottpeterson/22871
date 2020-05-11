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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label floorlbl;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbEnemy1 = new System.Windows.Forms.PictureBox();
            this.lblEnemyDesc = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTip = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbSky = new System.Windows.Forms.PictureBox();
            this.rb1Minute = new System.Windows.Forms.RadioButton();
            this.rb2Minutes = new System.Windows.Forms.RadioButton();
            this.rb3Minutes = new System.Windows.Forms.RadioButton();
            this.rb4Minutes = new System.Windows.Forms.RadioButton();
            floorlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSky)).BeginInit();
            this.SuspendLayout();
            // 
            // floorlbl
            // 
            floorlbl.AutoSize = true;
            floorlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(232)))), ((int)(((byte)(87)))));
            floorlbl.Cursor = System.Windows.Forms.Cursors.Default;
            floorlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            floorlbl.Location = new System.Drawing.Point(565, 582);
            floorlbl.Name = "floorlbl";
            floorlbl.Size = new System.Drawing.Size(355, 36);
            floorlbl.TabIndex = 8;
            floorlbl.Text = "Avoid touching the floor";
            floorlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(845, 217);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(208, 79);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(69, 217);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(208, 79);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ImageIndex = 5;
            this.lblDescription.Location = new System.Drawing.Point(296, 134);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(664, 48);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Push up arrow key or space bar to move up.";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbPlayer
            // 
            this.pbPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.pbPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayer.Image")));
            this.pbPlayer.Location = new System.Drawing.Point(219, 126);
            this.pbPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(51, 50);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayer.TabIndex = 3;
            this.pbPlayer.TabStop = false;
            // 
            // pbEnemy1
            // 
            this.pbEnemy1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.pbEnemy1.Image = global::FinalProject.Properties.Resources.pipe_top;
            this.pbEnemy1.Location = new System.Drawing.Point(1275, 11);
            this.pbEnemy1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbEnemy1.Name = "pbEnemy1";
            this.pbEnemy1.Size = new System.Drawing.Size(101, 275);
            this.pbEnemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEnemy1.TabIndex = 4;
            this.pbEnemy1.TabStop = false;
            // 
            // lblEnemyDesc
            // 
            this.lblEnemyDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.lblEnemyDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyDesc.Location = new System.Drawing.Point(1382, 23);
            this.lblEnemyDesc.Name = "lblEnemyDesc";
            this.lblEnemyDesc.Size = new System.Drawing.Size(165, 147);
            this.lblEnemyDesc.TabIndex = 5;
            this.lblEnemyDesc.Text = "Avoid hitting pipes";
            this.lblEnemyDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 9000;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.lblTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.Location = new System.Drawing.Point(88, 331);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(775, 37);
            this.lblTip.TabIndex = 6;
            this.lblTip.Text = "Tip: Press shift key to alter your movement speed.";
            this.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGreen;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, 627);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1568, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(-8, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1568, 21);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(581, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 36);
            this.label2.TabIndex = 10;
            this.label2.Text = "Avoid touching the top";
            // 
            // pbSky
            // 
            this.pbSky.Image = ((System.Drawing.Image)(resources.GetObject("pbSky.Image")));
            this.pbSky.Location = new System.Drawing.Point(-168, -150);
            this.pbSky.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pbSky.Name = "pbSky";
            this.pbSky.Size = new System.Drawing.Size(1728, 780);
            this.pbSky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSky.TabIndex = 11;
            this.pbSky.TabStop = false;
            // 
            // rb1Minute
            // 
            this.rb1Minute.AutoSize = true;
            this.rb1Minute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.rb1Minute.Checked = true;
            this.rb1Minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.rb1Minute.Location = new System.Drawing.Point(344, 193);
            this.rb1Minute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb1Minute.Name = "rb1Minute";
            this.rb1Minute.Size = new System.Drawing.Size(101, 32);
            this.rb1Minute.TabIndex = 2;
            this.rb1Minute.TabStop = true;
            this.rb1Minute.Text = "1 Minute";
            this.rb1Minute.UseVisualStyleBackColor = false;
            // 
            // rb2Minutes
            // 
            this.rb2Minutes.AutoSize = true;
            this.rb2Minutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.rb2Minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.rb2Minutes.Location = new System.Drawing.Point(579, 193);
            this.rb2Minutes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb2Minutes.Name = "rb2Minutes";
            this.rb2Minutes.Size = new System.Drawing.Size(109, 32);
            this.rb2Minutes.TabIndex = 3;
            this.rb2Minutes.TabStop = true;
            this.rb2Minutes.Text = "2 Minutes";
            this.rb2Minutes.UseVisualStyleBackColor = false;
            // 
            // rb3Minutes
            // 
            this.rb3Minutes.AutoSize = true;
            this.rb3Minutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.rb3Minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.rb3Minutes.Location = new System.Drawing.Point(341, 269);
            this.rb3Minutes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb3Minutes.Name = "rb3Minutes";
            this.rb3Minutes.Size = new System.Drawing.Size(109, 32);
            this.rb3Minutes.TabIndex = 4;
            this.rb3Minutes.TabStop = true;
            this.rb3Minutes.Text = "3 Minutes";
            this.rb3Minutes.UseVisualStyleBackColor = false;
            // 
            // rb4Minutes
            // 
            this.rb4Minutes.AutoSize = true;
            this.rb4Minutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.rb4Minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.rb4Minutes.Location = new System.Drawing.Point(579, 269);
            this.rb4Minutes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb4Minutes.Name = "rb4Minutes";
            this.rb4Minutes.Size = new System.Drawing.Size(109, 32);
            this.rb4Minutes.TabIndex = 5;
            this.rb4Minutes.TabStop = true;
            this.rb4Minutes.Text = "4 Minutes";
            this.rb4Minutes.UseVisualStyleBackColor = false;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 694);
            this.Controls.Add(this.rb4Minutes);
            this.Controls.Add(this.rb3Minutes);
            this.Controls.Add(this.rb2Minutes);
            this.Controls.Add(this.rb1Minute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(floorlbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblEnemyDesc);
            this.Controls.Add(this.pbEnemy1);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pbSky);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSky)).EndInit();
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
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbSky;
        private System.Windows.Forms.RadioButton rb1Minute;
        private System.Windows.Forms.RadioButton rb2Minutes;
        private System.Windows.Forms.RadioButton rb3Minutes;
        private System.Windows.Forms.RadioButton rb4Minutes;
    }
}

