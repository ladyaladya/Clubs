using System;
using System.Collections.Generic;
using System.Text;

namespace ShwanLessonFive
{
    public class CyclingClub
    {
        public event Action GoToRide;

        public void TakeTime(DateTime now)
        {
            if(now.Hour <= 8)
            {
                GoToRide?.Invoke();
            }
        }
    }
}
