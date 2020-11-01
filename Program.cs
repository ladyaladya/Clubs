using System;
namespace ShwanLessonFive
{
    public class Program
    {
        static void Main(string[] args)
        {
            CyclingClub CC = new CyclingClub();
            CC.GoToRide += CC_GoToRide;
            CC.TakeTime(DateTime.Parse("31.10.2020 19:52:00"));
            CC.TakeTime(DateTime.Parse("31.10.2028 7:52:00"));
            #region runningClub
            //RunningClub RC0 = new RunningClub("NoBoringRunners", true, "Vinnytsia");
            //RunningClub RC1 = new RunningClub("SuperRunners", false, "Vinnytsia");
            //RC0.NumberOfParticipants = 225;
            //RC1.NumberOfParticipants = 35;

            //RunningClub MergedRC = new RunningClub();
            //MergedRC = MergedRC.MergeClubs(RC0, RC1);
            //MergedRC.PrintFields(MergedRC);

            //RunningClub MergedRC1 = new RunningClub();
            //MergedRC1 = RC0 + RC1;
            //MergedRC1.PrintFields(MergedRC1);
            #endregion

            Console.ReadLine();
        }

        private static void CC_GoToRide()
        {
            Console.WriteLine("Go cycling!");
        }
    }

}
