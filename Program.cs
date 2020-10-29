using System;

namespace ShwanLessonFive
{
    public class Program
    {
        static void Main(string[] args)
        {
            RunningClub RC0 = new RunningClub("NoBoringRunners", true, "Vinnytsia");
            RunningClub RC1 = new RunningClub("SuperRunners", false, "Vinnytsia");

            RC0.NumberOfParticipants = 225;
            RC1.NumberOfParticipants = 35;

            RunningClub MergedRC0 = new RunningClub("", false);
            Console.WriteLine(RC0.City == RC1.City);
            MergedRC0 = MergedRC0.MergeClubs(RC0, RC1);
            MergedRC0.PrintFields(MergedRC0);

            Console.ReadLine();
        }
    }
}
