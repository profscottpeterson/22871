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
        public PictureBox show = new PictureBox();

        // set size and location.                    

        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int X_axis
        {
            get { return x_axis; }
            set { x_axis = value; }
        }

        public int Y_axis
        {
            get { return y_axis; }
            set { y_axis = value; }
        }

        private PictureBox Show
        {
            get { return show; }
            set { show = value; }
        }

        public int SetZIndex { get; internal set; }
    }
}
