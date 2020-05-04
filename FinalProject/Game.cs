﻿//-----------------------------------------------------------------------
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
        // Values of Players location
        private int xPlayerLoc;
        private int yPlayerLoc;
        
        // Time played
        private int time;

        // Bool for Player still alive
        private bool gameContinues = true;

        // List of enemies
        List<Enemy> enemies = new List<Enemy>();

        // Value to control speed setting of player
        bool spacePress = false;

        //Edited by: Jeng Leng
        // Variable for count, seconds, minutes, and hours.
        private int count;
        private int countTimeSeconds = 0;
        private int countTimeMinutes = 0;
        private int countTimeHours = 0;

        // booleam for player jump.
        bool jumping;
        int gravity = 7;

        public Game()
        {
            InitializeComponent();
            CenterToParent();

            // Set player jumping to false
            jumping = false;

            // Set player location
            xPlayerLoc = 50;
            yPlayerLoc = 50;
            pbPlayer.Location = new Point(xPlayerLoc, yPlayerLoc);
        }

        ///<summary>
        /// Created by: Brandon Biles
        /// Last Edited by: Brandon Biles
        /// Last Edit date: 4/22/2020 
        /// Description: When button press occurs move player.
        /// </summary>
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {           
            if (e.KeyCode == Keys.Up && gameContinues)
            {

                // if space euqals false move player by 6 each time.
                if (spacePress == false)
                {
                    // If the up arrow is pressed move player up.
                    jumping = true;
                    gravity = -6;
                }

                // else when space is true move player by 12 each time.
                else
                {
                    // If the up arrow is pressed move player up.
                    jumping = true;
                    gravity = -12;                    
                }
            }                    

            // Speed up or slowdown player speed
            else if(e.KeyCode == Keys.Space && gameContinues)
            {
                // if space is false, change to true
                if(spacePress == false)
                {
                    spacePress = true;
                }
                else
                {
                    // else if space was true, change to false
                    spacePress = false;
                }
            }
        }

        ///<summary>
        /// Created by: Brandon Biles
        /// Last Edited by: Brandon Biles
        /// Last Edit date: 4/1/2020 
        /// Description: Create new enemies after a certain amount of ticks.
        /// </summary>
        private void timerMoveEnemy_Tick(object sender, EventArgs e)
        {
            //If player is still alive and time is under 100
            if(time < 500 && gameContinues)
            {                
                // Add more to time. When time is up player wins.
                time += 1;

                // TODO delete after makeEnemy works correctly  
                for(int i = 0; i < enemies.Count; i++)
                {
                    // If the enemy has reached the end of the left side of the window
                    if(enemies[i].show.Left < 0)
                    {
                        // randNumb equals new random number between 1 and 300
                        Random rand = new Random();
                        int randNumb = rand.Next(1, 300);

                        //If Position equals 0 then delete enemy and reset Position
                        enemies[i].show.Visible = false;
                        enemies.RemoveAt(i);                    
                        
                    }

                    // if enemy hitbox intersects with the player hitbox end game.
                    if (enemies[i].show.Bounds.IntersectsWith(pbPlayer.Bounds))
                    {
                        EndGame(false);
                    }
                    
                    // if player hits the ground or the top, end the game
                    if (pbGround.Bounds.IntersectsWith(pbPlayer.Bounds) || pbRoof.Bounds.IntersectsWith(pbPlayer.Bounds))
                    {
                        EndGame(false);
                    }

                    //Change enemy location
                    enemies[i].show.Left -= 5;
                }                
            }
            else if(time >= 100 && gameContinues)
            {
                // end game player wins.
                EndGame(true);
            }            
        }

        ///<summary>
        /// Created by: Nick Schuchard
        /// Last Edited by: Brandon Biles
        /// Last Edit date: 4/27/2020 
        /// Description: Create a new enemy.
        /// </summary>
        private void makeEnemy()
        {
            
            // TODO: Currently method is not working. Any picturebox created in method does not show up on game form.
            //int position = 500;
            Random rand = new Random();

            // TODO: Add image to enemy picturebox 
            // Create new enemy.
            Enemy enemy = new Enemy
            {

                // Set enemy values. X_axis is set within size of window (0 - 400) and Y_axis set to size 700.
                X_axis = rand.Next(0, 350),
                Y_axis = 700,
                Width = rand.Next(25, 50),
                Length = rand.Next(50, 100),
        };
            
            // Make enemy size.
            enemy.show.Size = new Size(enemy.Width, enemy.Length);



            // Make enemy color.
            enemy.show.Image = FinalProject.Properties.Resources.pipe_bottom;
            enemy.show.SizeMode = PictureBoxSizeMode.StretchImage;
            
            // Set's the size and location.
            enemy.show.Left = enemy.Y_axis;
            enemy.show.Top = enemy.X_axis;

            // Move enemy.
            enemy.show.Visible = true;

            // adds enemy to screen
            Controls.Add(enemy.show);
            enemy.show.BringToFront();
            // Add enemy to list.
            enemies.Add(enemy);               
        }

        ///<summary>
        /// Created by: Brandon Biles
        /// Last Edited by: Jeng Leng
        /// Last Edit date: 4/12/2020 
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

        private void timerMakeEnemy_Tick(object sender, EventArgs e)
        {
            // Call makeEnemy method
            makeEnemy();
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

            // Show the player how long the game lasted.
            this.timerCountLab.Text = count.ToString();
        }

        ///<summary>
        /// Created by: Jeng Leng
        /// Last Edited by: Jeng Leng
        /// Last Edit date: 4/12/2020 
        /// Description: Create a class method for the Timer class
        /// </summary>
        private void timerFormat(int seconds)
        {
            // Set the variable.
            countTimeSeconds = seconds; // Setup the seconds portion

            // While the timerCounts is more than 60, turn it into minutes.
            while (countTimeSeconds > 60)
            {
                // Subtract the timer counts by 60.
                countTimeSeconds = countTimeSeconds - 60;

                // Add 1 to the minute count time.
                countTimeMinutes++;

                // While the countTimeMinutes is more than 60, turn it into hours.
                while (countTimeMinutes > 60)
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
        /// Last Edited by: Nick
        /// Last Edit date: 5/3/20 
        /// Description: When user let go of key player begins failing again.
        /// </summary>
        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                jumping = false;
                gravity = 10;
            }

        }
    }
}
