﻿//-----------------------------------------------------------------------
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
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
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
        /// Last Edit date: 4/1/2020 
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
            
            game.ShowDialog();

            // Close current window.
            this.Close();
        }
        
        ///<summary>
        /// Created by: Jeng Leng
        /// Last Edited by: Jeng Leng
        /// Last Edit date: 4/12/2020 
        /// Description: The screen goes white and light gray every second.
        /// </summary>
        private void timer_Tick(object sender, EventArgs e)
        {
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
    }
}
