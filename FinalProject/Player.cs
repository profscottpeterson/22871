//-----------------------------------------------------------------------
// <copyright file="Form1.cs" company="Brandon Biles">
//     Copyright (c) Brandon Biles. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace FinalProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    ///<summary>
    /// Created by: Brandon Biles
    /// Last Edited by: Brandon Biles
    /// Last Edit date: 5/09/2020 
    /// Description: The following class contain all the data for an instance of a player.
    /// </summary>
    class Player
    {
        // The players image.
        private PictureBox bird = new PictureBox();

        // The player width
        private int width;

        // The players height
        private int height;

        // The players horizontal starting position
        private int startPointX;

        // The players vertical starting position
        private int startPointY;

        // Getter and setter for bird.
        public PictureBox Bird {
            get { return bird; }
            set { bird = value; }
        }

        // Getter and setter for width.
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        // Getter and setter for height.
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        // Getter and setter for startPointX.
        public int StartPointX
        {
            get { return startPointX; }
            set { startPointX = value; }
        }

        // Getter and setter for startPointY.
        public int StartPointY
        {
            get { return startPointY; }
            set { startPointY = value; }
        }
    }
}
