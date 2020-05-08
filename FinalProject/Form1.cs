//-----------------------------------------------------------------------
// <copyright file="Form1.cs" company="Brandon Biles, Jeng Leng Lee, Nick Schuchard, Travis Lambert.">
//     Copyright (c) Brandon Biles, Jeng Leng Lee, Nick Schuchard, Travis Lambert. All rights reserved.
// </copyright>
//--------------------------------------------------------------------------
namespace FinalProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class FormMainMenu : Form
    {

        //Edited by: Jeng
        System.Media.SoundPlayer wMP = new System.Media.SoundPlayer();

        public FormMainMenu()
        {
            InitializeComponent();
            
            //Edited by: Jeng
            wMP.SoundLocation = "Sounds/Our-Mountain_v003.wav";

            CenterToScreen();
        }

        ///<summary>
        /// Created by: Brandon Biles
        /// Last Edited by: Brandon Biles
        /// Last Edit date: 4/1/2020 
        /// Description: Exits the application.
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            // The user wants to exit the entire application.
            Application.Exit();
        }

        ///<summary>
        /// Created by: Brandon Biles
        /// Last Edited by: Brandon Biles
        /// Last Edit date: 5/08/2020 
        /// Description: Starts a new game and closes Main Menu window.
        /// </summary>
        private void btnStart_Click(object sender, EventArgs e)
        {
            // Hide main menu window.
            this.Hide();

            // Create instance of new game and bring it up.
            Game game = new Game()
            {
                Width = 700,
                Height = 400      
            };

            // Change time limit for game based of player choice
            if (rb1Minute.Checked == true)
            {
                // Time limit set to 1 minute
                game.TimeLimit = 60;
            }
            else if (rb2Minutes.Checked == true)
            {
                // Time limit set to 2 minutes
                game.TimeLimit = 120;
            }
            else if (rb3Minutes.Checked == true)
            {
                // Time limit set to 3 minutes
                game.TimeLimit = 180;
            }
            else if (rb4Minutes.Checked == true)
            {
                // Time limit set to 4 minutes
                game.TimeLimit = 240;
            }

            game.ShowDialog();

            // Close current window.
            this.Close();
        }        

        ///<summary>
        /// Created by: Jeng Leng
        /// Last Edited by: Brandon Biles
        /// Last Edit date: 5/08/2020 
        /// Description: When game start, music plays.
        /// </summary>
        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            // Play music on a loop
            wMP.PlayLooping();
        }
    }
}
