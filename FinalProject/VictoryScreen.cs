//-----------------------------------------------------------------------
// <copyright file="VictoryScreen.cs" company="Brandon Biles, Jeng Leng Lee, Nick Schuchard, Travis Lambert.">
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
    public partial class VictoryScreen : Form
    {
        public VictoryScreen()
        {
            InitializeComponent();
            CenterToParent();
        }

        // Edited by: Jeng Leng
        // Variable for calling the game form
        public string textBoxTimeSet
        {
            get { return setTimeWinTxtBox.Text; }
            set { setTimeWinTxtBox.Text = value; }
        }

        ///<summary>
        /// Created by: Brandon Biles
        /// Last Edited by: Brandon Biles
        /// Last Edit date: 4/2/2020 
        /// Description: Exits out of application.
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the application.
            Application.Exit();
        }

        ///<summary>
        /// Created by: Brandon Biles
        /// Last Edited by: Brandon Biles
        /// Last Edit date: 5/08/2020 
        /// Description: Starts a new game.
        /// </summary>
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            // Hide current window
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

            // Show game window
            game.ShowDialog();

            // Close current window.
            this.Close();
        }
    }
}
