//-----------------------------------------------------------------------
// <copyright file="GameOver.cs" company="Brandon Biles, Jeng Leng Lee, Nick Schuchard, Travis Lambert.">
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

    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
            CenterToParent();
        }

        ///<summary>
        /// Created by: Brandon Biles
        /// Last Edited by: Brandon Biles
        /// Last Edit date: 4/1/2020 
        /// Description: Exits the application.
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit out of the application.
            Application.Exit();
        }

        ///<summary>
        /// Created by: Brandon Biles
        /// Last Edited by: Brandon Biles
        /// Last Edit date: 4/1/2020 
        /// Description: Starts a new game.
        /// </summary>
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            // Hide current window
            this.Hide();

            // Create instance of new game and bring it up.
            Game game = new Game()
            {
                Width = 1500,
                Height = 700
            };
            game.ShowDialog();

            // Close current window.
            this.Close();
        }
    }
}
