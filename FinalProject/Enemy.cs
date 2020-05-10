//-----------------------------------------------------------------------
// <copyright file="Enemy.cs" company="Brandon Biles, Jeng Leng Lee, Nick Schuchard, Travis Lambert.">
//     Copyright (c) Brandon Biles, Jeng Leng Lee, Nick Schuchard, Travis Lambert. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace FinalProject
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    ///<summary>
    /// Created by: Brandon Biles
    /// Last Edited by: Brandon Biles
    /// Last Edit date: 5/09/2020 
    /// Description: The following class contain all the data for an instance of an enemy.
    /// </summary>
    class Enemy
    {
        // Length of enemy instance.
        private int length;

        // Width of enemy instance.
        private int width;

        // Horizontal location of enemy.
        private int x_axis;

        // Vertical Location of enemy.
        private int y_axis;

        // Image of enemy.
        private PictureBox show = new PictureBox();
                        
        // Getter and setter for length
        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        // Getter and setter for width
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        // Getter and setter for x_axis
        public int X_axis
        {
            get { return x_axis; }
            set { x_axis = value; }
        }

        // Getter and setter for y_axis
        public int Y_axis
        {
            get { return y_axis; }
            set { y_axis = value; }
        }

        // Getter and setter for show
        public PictureBox Show
        {
            get { return show; }
            set { show = value; }
        }

        // Getter and setter for SetZIndex
        public int SetZIndex { get; internal set; }
    }
}
