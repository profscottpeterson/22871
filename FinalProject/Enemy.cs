using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    class Enemy
    {
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

               // if (enemy.Bounds.IntersectsWith(pbPlayer.Bounds))
              //  {
                    // If the enemy hits the player end the game.
              //      EndGame(false);
              //  }
            }

            if (position == 0)
            {
                //If Position equals 0 then delete enemy and reset Position
                enemy.Dispose();
                position = 500;
            }
        }
    }
}
