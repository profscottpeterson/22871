using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Timer
    {
        private int countTimeSeconds = 0;
        private int countTimeMinutes = 0;
        private int countTimeHours = 0;

        ///<summary>
        /// Created by: Jeng Leng
        /// Last Edited by: Jeng Leng
        /// Last Edit date: 4/12/2020 
        /// Description: Create a class constructor for the Timer class
        /// </summary>
        public Timer(int seconds)
        {
            countTimeSeconds = seconds;
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
