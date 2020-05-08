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

        // Values of Players location
        private int xPlayerLoc;
        private int yPlayerLoc;

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
        int gravity = 7;

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
            
            // Set player location
            xPlayerLoc = 50;
            yPlayerLoc = 50;
            pbPlayer.Location = new Point(xPlayerLoc, yPlayerLoc);
        }

        ///<summary>
        /// Created by: Brandon Biles
        /// Last Edited by: Brandon Biles
        /// Last Edit date: 5/08/2020 
        /// Description: When button press occurs move player.
        /// </summary>
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            // if up arrow or space bar are pressed move player, but only when the game contiunes is true.
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Space && gameContinues)
            {

                // if SpeedChange false move player by 6 each time.
                if (SpeedChange == false)
                {
                    // Move the player up.
                    gravity = -6;
                }

                // else when SpeedChange is true move player by 12 each time.
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
                    // if SpeedChange is false, change to true.
                    SpeedChange = true;
                }
                else
                {
                    // else if SpeedChange was true, change to false.
                    SpeedChange = false;
                }
            }
        }

        ///<summary>
        /// Created by: Brandon Biles
        /// Last Edited by: Brandon Biles
        /// Last Edit date: 5/08/2020 
        /// Description: Create new enemies after a certain amount of ticks.
        /// </summary>
        private void timerMoveEnemy_Tick(object sender, EventArgs e)
        {
            //If player is still alive and time is under 100
            if(time < timeLimit && gameContinues)
            {               
                // Move every enemy in 
                for(int i = 0; i < enemies.Count; i++)
                {
                    // If the enemy has reached the end of the left side of the window
                    if(enemies[i].show.Left < 0)
                    {
                        // randNumb equals new random number between 1 and 300
                        Random rand = new Random();
                        int randNumb = rand.Next(1, 300);

                        //If Position equals 0 then delete enemy and reset Position.
                        enemies[i].show.Visible = false;
                        enemies.RemoveAt(i);                    
                        
                    }

                    // if enemy hitbox intersects with the player hitbox end game.
                    if (enemies[i].show.Bounds.IntersectsWith(pbPlayer.Bounds))
                    {
                        // Call EndGame method.
                        EndGame(false);

                        // Break out of loop of the player lost. Break prevents multipule EndGame methods from being called.
                        break;
                    }
                    
                    // if player hits the ground or the top, end the game
                    if (pbGround.Bounds.IntersectsWith(pbPlayer.Bounds) || pbRoof.Bounds.IntersectsWith(pbPlayer.Bounds))
                    {
                        // Call EndGame method.
                        EndGame(false);

                        // Break out of loop of the player lost. Break prevents multipule EndGame methods from being called.
                        break;
                    }

                    //Change enemy location
                    enemies[i].show.Left -= 5;
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
        /// Description: Create a new enemy.
        /// </summary>
        private void makeEnemy(bool topEnemy)
        {
            // Instateate new instance of random value;
            Random rand = new Random();

            // when topEnemy is true create an enemy on the top of the screen
            if (topEnemy == true)
            {
                Enemy enemy = new Enemy
                {

                    // Set enemy values. X_axis is set to either 0 for the top pipe and Y_axis set to size 700.                
                    X_axis = 0,
                    Y_axis = 700,
                    Width = rand.Next(35, 50),
                    Length = rand.Next(25, 200),
                };
                // Make enemy size.
                enemy.show.Size = new Size(enemy.Width, enemy.Length);

                // Make enemy color.
                enemy.show.Image = FinalProject.Properties.Resources.pipe_top;
                enemy.show.SizeMode = PictureBoxSizeMode.StretchImage;

                // Set's the size and location.
                enemy.show.Anchor = AnchorStyles.Top;
                enemy.show.Left = enemy.Y_axis;
                enemy.show.Top = enemy.X_axis;

                // Move enemy.
                enemy.show.Visible = true;

                // adds enemy to screen
                Controls.Add(enemy.show);

                // Display enemy on top of pbSky 
                enemy.show.BringToFront();

                // Add enemy to list.
                enemies.Add(enemy);

            }

            // when topEnemy is false create an enemy on the bottom of the screen
            else if (topEnemy == false)
            {
                Enemy enemy = new Enemy
                {
                    
                    // Set enemy values. X_axis is set to 305 for the bottom pipe and Y_axis set to size 700.                    
                    Width = rand.Next(40, 50),
                    Length = rand.Next(185, 200),

                    // Find the top pipe and set the X_axis of the new enemy (bottom pipe) to a set amount of pixels greater 
                    // than the privious enemys length. This ensure that there is always enough space for the player to advance.
                    X_axis = enemies[enemies.Count-1].Length + rand.Next(85, 120),
                    Y_axis = 700,
                };

                // Make enemy size.
                enemy.show.Size = new Size(enemy.Width, enemy.Length);

                // set enemy image layout to zoom
                enemy.show.BackgroundImageLayout = ImageLayout.Zoom;

                // Make enemy color.
                enemy.show.Image = FinalProject.Properties.Resources.pipe_bottom;
                enemy.show.SizeMode = PictureBoxSizeMode.StretchImage;

                // Set's the size and location.
                enemy.show.Anchor = AnchorStyles.Bottom;
                enemy.show.Left = enemy.Y_axis;
                enemy.show.Top = enemy.X_axis;

                // Move enemy.
                enemy.show.Visible = true;

                // adds enemy to screen
                Controls.Add(enemy.show);

                // Display enemy on top of pbSky 
                enemy.show.BringToFront();

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
                // Change gamecontinues to false
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
        /// Description: When a tick of the timer occurs create twi instances of an enemy. One instace is top pipe, 
        /// and the second instance is a bottom pipe.
        /// </summary>
        private void timerMakeEnemy_Tick(object sender, EventArgs e)
        {
            // Call makeEnemy method Fisrt make top pipe enemy
            makeEnemy(true);

            // After top pipe enemy is created then create bottom pipe enemy
            makeEnemy(false);
        }

        ///<summary>
        /// Created by: Jeng Leng
        /// Last Edited by: Nick
        /// Last Edit date: 5/3/2020 
        /// Description: Timer that keeps track of time.
        /// Removed Background gray/white toggle. - Nick
        /// </summary>
        private void countTime_Tick(object sender, EventArgs e)
        {
            // Increase the time count every second.
            count++;

            // Increae time value by 1 for every second of gameplay.
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

            // While the timerCounts is more than  or equal to 60, turn it into minutes.
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
                pbPlayer.Top += gravity;
            }
            else
            {
                // end timer is game has ended
                timerPlayerFalls.Enabled = false;
            }
        }

        ///<summary>
        /// Created by: Travis
        /// Last Edited by: Brandon Biles
        /// Last Edit date: 5/08/20 
        /// Description: When user let go of key player begins failing again.
        /// </summary>
        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            // When key is relased change gravity by to ten for player movement. 
            if(e.KeyCode == Keys.Up || e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }

        }

        ///<summary>
        /// Created by: Jeng Leng
        /// Last Edited by: Brandon Biles
        /// Last Edit date: 5/08/2020 
        /// Description: When game start, music plays.
        /// </summary>
        private void Game_Load(object sender, EventArgs e)
        {
            // Play music on loop.
            audio.PlayLooping();

            // Make two enemies one top pipe and one bottom pipe.
            makeEnemy(true);
            makeEnemy(false);
        }
    }
}
