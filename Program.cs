using System;

namespace ShwanLessonFive
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region RunningClub
            //RunningClub RC0 = new RunningClub("NoBoringRunners", true, "Vinnytsia");
            //RunningClub RC1 = new RunningClub("SuperRunners", false, "Vinnytsia");
            //RC0.NumberOfParticipants = 225;
            //RC1.NumberOfParticipants = 35;

            ////RunningClub MergedRC = new RunningClub();
            ////MergedRC = MergedRC.MergeClubs(RC0, RC1);
            ////MergedRC.PrintFields(MergedRC);

            //RunningClub MergedRC1 = new RunningClub();
            //MergedRC1 = RC0 + RC1;
            //MergedRC1.PrintFields(MergedRC1);
            #endregion

            Club club = new Club();
            club.Notify += StartSocietyActivitiesEvent;
            club.StartSocietyActivities(club);
            club.PrintFields();


            Console.ReadLine();
        }

        private static void StartSocietyActivitiesEvent(Club club)
        {
            Console.WriteLine($"The club {club.Name} started it's society activities! \nCongratulations!!!");
        }



        //private static void CheckSundayEvent()
        //{
        //    bool isSunday = String.Equals(DateTime.Today.DayOfWeek.ToString(), "Sunday");
        //    if (isSunday)
        //    {
        //        Console.WriteLine("Today our club organize an event at 8 am.");
        //    }
        //    else Console.WriteLine("The next event will be on Sunday.");
        //}
    }
}
