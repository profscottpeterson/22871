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
    using System.Windows.Input;

    public partial class Game : Form
    { 
        bool jumping;
        int gravity = 7;
        
        // Values of Players location
        private int xPlayerLoc;
        private int yPlayerLoc;
        
        // Time played
        private int time;

        // Bool for Player still alive
        private bool gameContinues = true;

        // Array of enemies
        PictureBox[] enemies = new PictureBox[3];

        //Edited by: Jeng Leng
        // Variable for count, seconds, minutes, and hours.
        private int count;
        private int countTimeSeconds = 0;
        private int countTimeMinutes = 0;
        private int countTimeHours = 0;

        public Game()
        {
            InitializeComponent();
            CenterToParent();
            jumping = false;
            // Set player location
            xPlayerLoc = 50;
            yPlayerLoc = 50;
            pbPlayer.Location = new Point(xPlayerLoc, yPlayerLoc);
            // Set enemies
            enemies[0] = pbEnemy1;
            enemies[1] = pbEnemy2;
            enemies[2] = pbEnemy3;
        }

        ///<summary>
        /// Created by: Brandon Biles
        /// Last Edited by: Travis Lambert
        /// Last Edit date: 4/17/2020 
        /// Description: When button press occurs move player, if the player is not pressing the button, gravity will cause them to fall.
        /// </summary>
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                    jumping = true;
                    gravity = -6;
            }
            
        }
        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                jumping = false;
                gravity = 7;
            }
        }

        ///<summary>
        /// Created by: Brandon Biles
        /// Last Edited by: Travis Lambert
        /// Last Edit date: 4/17/2020 
        /// Description: Create new enemies after a certain amount of ticks.
        /// </summary>
        private void timerMoveEnemy_Tick(object sender, EventArgs e)
        {
            //If player is still alive and time is under 100
            if(time < 500 && gameContinues)
            {
                //Make it so the player drops due to gravity.
                pbPlayer.Top += gravity;
                // Create enemy.
                //makeEnemy();
                
                // Add more to time. When time is up player wins.
                time += 1;

                // TODO delete after makeEnemy works correctly  
                for(int i = 0; i < enemies.Length; i++)
                {
                    // If the enemy has reached the end of the left side of the window
                    if(enemies[i].Left < 0)
                    {
                        // randNumb equals new random number between 1 and 300
                        Random rand = new Random();
                        int randNumb = rand.Next(1, 300);

                        // set enemies back up at new location
                        enemies[i].Left = 400;
                        enemies[i].Top = randNumb;

                        // if enemy locations intersect seperate them.
                        if (pbEnemy1.Bounds.IntersectsWith(pbEnemy2.Bounds))
                        {
                            pbEnemy2.Top = randNumb + 200;
                        }
                        if (pbEnemy1.Bounds.IntersectsWith(pbEnemy3.Bounds))
                        {
                            pbEnemy3.Top = randNumb + 200;
                        }
                        if (pbEnemy2.Bounds.IntersectsWith(pbEnemy3.Bounds))
                        {
                            pbEnemy3.Top = randNumb + 200;
                        }
                    }

                    // if enemy hitbox intersects with the player hitbox end game.
                    if (enemies[i].Bounds.IntersectsWith(pbPlayer.Bounds))
                    {
                        EndGame(false);
                    }

                    //Change enemy location
                    enemies[i].Left -= 5;
                }                
            }
            else if(time >= 100 && gameContinues)
            {
                // end game player wins.
                EndGame(true);
            }
            
        }

        ///<summary>
        /// Created by: Brandon Biles
        /// Last Edited by: Brandon Biles
        /// Last Edit date: 4/1/2020 
        /// Description: Create a new enemy.
        /// </summary>
        private void makeEnemy()
        {
            // TODO: Currently method is not working. Any picturebox created in method does not show up on game form.
            int position = 500;

            // Make instance of enemy.
            PictureBox enemy = new PictureBox();

            // Make enemy size.
            //enemy.Size = new Size(100, 200);

            // Make enemy color.
            enemy.BackColor = Color.Red;

            // set size and location.
            enemy.SetBounds(100, 100, 100, 200);

            // Move enemy.
            enemy.Visible = true;            

            //enemy.Location = new Point(position, position);
            for (int i = 0; i < position; position -= 5)
            {
                enemy.Location = new Point(position, 500);

                if (enemy.Bounds.IntersectsWith(pbPlayer.Bounds)){
                    // If the enemy hits the player end the game.
                    EndGame(false);
                }
            }
            
            if(position == 0)
            {
                //If Position equals 0 then delete enemy and reset Position
                enemy.Dispose();
                position = 500;
            }
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
                // Stop timer
                timerMoveEnemy.Stop();

                //Edited by: Jeng Leng
                // Stop counting time
                countTime.Stop();

                // Hide game.
                this.Hide();

                // New GameOver window.
                GameOver end = new GameOver();

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
                // Stop timer
                timerMoveEnemy.Stop();

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
        /// Last Edited by: Jeng Leng
        /// Last Edit date: 4/12/2020 
        /// Description: Timer that keeps track of time and changes background for visual.
        /// </summary>
        private void countTime_Tick(object sender, EventArgs e)
        {
            // Increase the time count every second.
            count++;

            // Show the player how long the game lasted.
            this.timerCountLab.Text = count.ToString();

            // If the background color is white.
            if (BackColor == Color.White)
            {
                // The background color is light gray.
                BackColor = Color.LightGray;
            }
            else
            {
                // Otherwise, the background color is white.
                BackColor = Color.White;
            }
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
    }
}
