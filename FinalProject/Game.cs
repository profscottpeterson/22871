//-----------------------------------------------------------------------
// <copyright file="Game.cs" company="Brandon Biles, Jeng Leng Lee, Nick Schuchard, Travis Lambert.">
//     Copyright (c) Brandon Biles, Jeng Leng Lee, Nick Schuchard, Travis Lambert. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace FinalProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class Game : Form
    {
        //Edited by: Jeng Leng
        // Initiate a soundplayer call audio.
        System.Media.SoundPlayer audio = new System.Media.SoundPlayer();

        // Declare instance of player
        Player player = new Player();

        // Time played
        private int time;

        // Int for time limit of the game.
        private int timeLimit;

        // Bool for Player still alive
        private bool gameContinues = true;

        // List of enemies
        List<Enemy> enemies = new List<Enemy>();

        // Value to control speed setting of player
        bool SpeedChange = false;

        //Edited by: Jeng Leng
        // Variable for count, seconds, minutes, and hours.
        private int count;
        private int countTimeSeconds = 0;
        private int countTimeMinutes = 0;
        private int countTimeHours = 0;

        // boolean for player movement
        int gravity = 10;

        // Getter and setter for timeLimit
        public int TimeLimit{
            get { return timeLimit; }
            set { timeLimit = value; }
        }

        public Game()
        {
            InitializeComponent();
            CenterToParent();

            //Edited by Jeng
            audio.SoundLocation = "Sounds/Our-Mountain_v003.wav";
            
        }

        ///<summary>
        /// Created by: Brandon Biles
        /// Last Edited by: Brandon Biles
        /// Last Edit date: 5/08/2020 
        /// Description: When button press occurs move player.
        /// </summary>
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            // if up arrow or space bar are pressed move player, but only when the game continues is true.
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Space && gameContinues)
            {

                // if SpeedChange false, move player by 6 each time.
                if (SpeedChange == false)
                {
                    // Move the player up.
                    gravity = -6;
                }

                // else when SpeedChange is true, move player by 12 each time.
                else
                {
                    // Move the player up.
                    gravity = -12;
                }
            }

            // When shift is pressed change the player speed.
            else if (e.KeyCode == Keys.ShiftKey && gameContinues) {
                if (SpeedChange == false)
                {
                    // If SpeedChange is false, change to true, doubleing the players speed.
                    SpeedChange = true;
                }
                else
                {
                    // Else if SpeedChange was true, change to false, halving the players speed.
                    SpeedChange = false;
                }
            }
        }

        ///<summary>
        /// Created by: Brandon Biles
        /// Last Edited by: Nicholas Schuchard
        /// Last Edit date: 5/10/2020 
        /// Description: Create new enemies after a certain amount of ticks.
        /// </summary>
        private void timerMoveEnemy_Tick(object sender, EventArgs e)
        {
            // If player is still alive and the game has not ended
            if(time < timeLimit && gameContinues)
            {               
                // Move every enemy in enemies list
                for(int i = 0; i < enemies.Count; i++)
                {
                    // If the enemy has reached the end of the left side of the window
                    if(enemies[i].Show.Left < 0)
                    {
                        // randNumb equals new random number between 1 and 300
                        Random rand = new Random();
                        int randNumb = rand.Next(1, 300);

                        // If Position equals 0 then delete enemy and reset Position.
                        enemies[i].Show.Visible = false;
                        enemies.RemoveAt(i);                        
                    }

                    // If enemy hitbox intersects with the player hitbox end game.
                    if (enemies[i].Show.Bounds.IntersectsWith(player.Bird.Bounds))
                    {
                        // Call EndGame method.
                        EndGame(false);

                        // Break out of loop of the player lost. Break prevents multiple EndGame methods from being called.
                        break;
                    }
                    
                    // if player hits the ground or the top, end the game
                    if (pbGround.Bounds.IntersectsWith(player.Bird.Bounds) || pbRoof.Bounds.IntersectsWith(player.Bird.Bounds))
                    {
                        // Call EndGame method.
                        EndGame(false);

                        // Break out of loop of the player lost. Break prevents multiple EndGame methods from being called.
                        break;
                    }

                    // Change enemy location
                    enemies[i].Show.Left -= 13;
                }                
            }
            else if(time >= timeLimit && gameContinues)
            {
                // end game player wins.
                EndGame(true);
            }            
        }

        ///<summary>
        /// Created by: Brandon Biles
        /// Last Edited by: Brandon Biles
        /// Last Edit date: 5/08/2020 
        /// Description: Method to create a new enemy.
        /// </summary>
        private void makeEnemy(bool topEnemy)
        {
            // Instantiate new instance of random value;
            Random rand = new Random();

            // when topEnemy is true create an enemy on the top of the screen
            if (topEnemy == true)
            {
                Enemy enemy = new Enemy
                {

                    // Set enemy values. X_axis is set to 0 for the top pipe to appear at the top of the window
                    // and Y_axis set to size 700 to set enemy to far right of window.                
                    X_axis = 0,
                    Y_axis = 700,
                    Width = rand.Next(35, 50),
                    Length = rand.Next(25, 200),
                };
                // Make enemy size.
                enemy.Show.Size = new Size(enemy.Width, enemy.Length);

                // Make enemy color.
                enemy.Show.Image = FinalProject.Properties.Resources.pipe_top;
                enemy.Show.SizeMode = PictureBoxSizeMode.StretchImage;

                // Set's the size and location.
                enemy.Show.Anchor = AnchorStyles.Top;
                enemy.Show.Left = enemy.Y_axis;
                enemy.Show.Top = enemy.X_axis;

                // Move enemy.
                enemy.Show.Visible = true;

                // adds enemy to screen
                Controls.Add(enemy.Show);

                // Display enemy on top of pbSky 
                enemy.Show.BringToFront();

                // Add enemy to list.
                enemies.Add(enemy);

            }

            // when topEnemy is false create an enemy on the bottom of the screen
            else if (topEnemy == false)
            {
                Enemy enemy = new Enemy
                {
                    
                    // Set enemy Width and Length values.                    
                    Width = rand.Next(40, 50),
                    Length = rand.Next(185, 200),

                    // Find the top pipe and set the X_axis of the new enemy (bottom pipe) to a set number of pixels greater 
                    // than the previous enemy's length. This ensure that there is always enough space for the player to advance.
                    X_axis = enemies[enemies.Count-1].Length + rand.Next(85, 120),
                    Y_axis = 700,
                };

                // Make enemy size.
                enemy.Show.Size = new Size(enemy.Width, enemy.Length);

                // set enemy image layout to zoom
                enemy.Show.BackgroundImageLayout = ImageLayout.Zoom;

                // Make enemy color.
                enemy.Show.Image = FinalProject.Properties.Resources.pipe_bottom;
                enemy.Show.SizeMode = PictureBoxSizeMode.StretchImage;

                // Set's the size and location.
                enemy.Show.Anchor = AnchorStyles.Bottom;
                enemy.Show.Left = enemy.Y_axis;
                enemy.Show.Top = enemy.X_axis;

                // Move enemy.
                enemy.Show.Visible = true;

                // adds enemy to screen
                Controls.Add(enemy.Show);

                // Display enemy on top of pbSky 
                enemy.Show.BringToFront();

                // Add enemy to list.
                enemies.Add(enemy);
            }
        }

        ///<summary>
        /// Created by: Brandon Biles
        /// Last Edited by: Jeng Leng
        /// Last Edit date: 5/06/2020 
        /// Description: Method to end the game. Is called when player is hit by enemy.
        /// </summary>
        private void EndGame(Boolean win)
        {
            // If player does not win the game
            if (win == false)
            {
                // Change gamecontinues to false
                gameContinues = false;

                // Stop all timers
                timerMoveEnemy.Stop();
                timerMakeEnemy.Stop();
                timerPlayerFalls.Stop();

                //Edited by: Jeng Leng
                // Stop counting time
                countTime.Stop();

                // Hide game.
                this.Hide();

                // New GameOver window.
                GameOver end = new GameOver()
                {
                    Width = 700,
                    Height = 400
                };

                //Edited by: Jeng Leng (5/6/2020)
                // Stop the music
                audio.Stop();

                //Edited by: Jeng Leng
                // Using the timerFormat method
                timerFormat(count);

                //Edited by Jeng Leng
                // Add the time total into the game over title.
                end.textBoxTimeSet = countTimeHours + " hours: " +
                            countTimeMinutes + " minutes: " +
                            countTimeSeconds + " seconds";

                // Show end window.
                end.ShowDialog();

                // Close window.
                this.Close();
            }

            // If player wins the game 
            else if(win == true)
            {
                // Change gamecontinues to false when game is ending
                gameContinues = false;

                // Stop all timers
                timerMoveEnemy.Stop();
                timerMakeEnemy.Stop();
                timerPlayerFalls.Stop();

                //Edited by: Jeng Leng
                // Stop counting time
                countTime.Stop();

                // Hide current window
                this.Hide();

                // Create instance of new game and bring it up.
                VictoryScreen victory = new VictoryScreen()
                {
                    Width = 700,
                    Height = 400

                };

                //Edited by: Jeng Leng (5/6/2020)
                // Stop the music
                audio.Stop();

                //Edited by: Jeng Leng
                // Using the timerFormat method
                timerFormat(count);

                //Edited by Jeng Leng
                // Add the time total into the game over title.
                victory.textBoxTimeSet = countTimeHours + " hours: " +
                            countTimeMinutes + " minutes: " +
                            countTimeSeconds + " seconds";

                // Show victory dialog.
                victory.ShowDialog();

                // Close current window.
                this.Close();
            }
        }

        ///<summary>
        /// Created by: Brandon Biles
        /// Last Edited by: Brandon Biles
        /// Last Edit date: 5/08/2020 
        /// Description: When a tick of the timer occurs create two instances of an enemy. One instance is top pipe, 
        /// and the second instance is a bottom pipe.
        /// </summary>
        private void timerMakeEnemy_Tick(object sender, EventArgs e)
        {
            // Call makeEnemy method, make top pipe enemy
            makeEnemy(true);

            // After top pipe enemy is created then create bottom pipe enemy
            makeEnemy(false);
        }

        ///<summary>
        /// Created by: Jeng Leng
        /// Last Edited by: Nick
        /// Last Edit date: 5/3/2020 
        /// Description: Timer that keeps track of time, shows the amount of time the user has been playing.
        /// Removed Background gray/white toggle. - Nick
        /// </summary>
        private void countTime_Tick(object sender, EventArgs e)
        {
            // Increase the time count every second.
            count++;

            // Increase time value by 1 for every second of gameplay.
            time++;

            // Show the player how long the game lasted.
            this.timerCountLab.Text = count.ToString();
        }

        ///<summary>
        /// Created by: Jeng Leng
        /// Last Edited by: Brandon Biles
        /// Last Edit date: 5/08/2020 
        /// Description: Create a class method for the Timer class
        /// </summary>
        private void timerFormat(int seconds)
        {
            // Set the variable.
            countTimeSeconds = seconds; // Setup the seconds portion

            // While the timerCounts is more than or equal to 60, turn it into minutes.
            while (countTimeSeconds >= 60)
            {
                // Subtract the timer counts by 60.
                countTimeSeconds = countTimeSeconds - 60;

                // Add 1 to the minute count time.
                countTimeMinutes++;

                // While the countTimeMinutes is more than or equal to 60, turn it into hours.
                while (countTimeMinutes >= 60)
                {
                    // Subtract the minute count by 60.
                    countTimeMinutes = countTimeMinutes - 60;

                    // Add 1 to the hour count time.
                    countTimeHours++;
                }
            }
        }

        ///<summary>
        /// Created by: Brandon Biles
        /// Last Edited by: Brandon Biles
        /// Last Edit date: 4/27/2020 
        /// Description: Move the player down with each tick of the timer.
        /// </summary>
        private void timerPlayerFalls_Tick(object sender, EventArgs e)
        {
            // if the game continues move player.
            if (gameContinues)
            {
                // While game is going move player.
                player.Bird.Top += gravity;
            }
            else
            {
                // end timer if game has ended
                timerPlayerFalls.Enabled = false;
            }
        }

        ///<summary>
        /// Created by: Travis
        /// Last Edited by: Brandon Biles
        /// Last Edit date: 5/08/20 
        /// Description: When user let go of key player begins falling again.
        /// </summary>
        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            // When up or space key are released change gravity by to ten for player movement. 
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }

        }

        ///<summary>
        /// Created by: Jeng Leng
        /// Last Edited by: Brandon Biles
        /// Last Edit date: 5/09/2020 
        /// Description: When game start, the music plays and the player gets instantiated.
        /// </summary>
        private void Game_Load(object sender, EventArgs e)
        {
            // Play music on loop.
            audio.PlayLooping();

            // Add player to the game
            // Add players image
            player.Bird.Image = FinalProject.Properties.Resources.bird;

            // Instantiate the size of the player
            player.Height = 20;
            player.Width = 20;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            player.Bird.Size = new Size(player.Width, player.Height);

            // Set player starting location
            player.StartPointX = 35;
            player.StartPointY = 35;
            player.Bird.Location = new Point(player.StartPointX, player.StartPointY);

            // Make the player image visible to the user.
            player.Bird.Visible = true;
            player.Bird.BackgroundImageLayout = ImageLayout.Zoom;
            player.Bird.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(player.Bird);
            player.Bird.BringToFront();

            // Add two enemies one top pipe and one bottom pipe.
            makeEnemy(true);
            makeEnemy(false);
        }
    }
}
