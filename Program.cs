using System;
using System.IO;
using System.Text;

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

            Club club = new Club("NoBorringRunners", true, "Vinnytsia");
            club.SaveClubInfoNotify += Club_SaveClubInfoNotify;
            club.SaveClubInfo(club);


            Console.ReadLine();
        }

        private static void Club_SaveClubInfoNotify(Club club)
        {
            string path = "C:\\Users\\Admin\\Desktop";
            try
            {
                if (Directory.Exists(path))
                {
                    if (!Directory.Exists(path + "\\ClubsInfo"))
                    {
                        {
                            Directory.CreateDirectory(path + "\\ClubsInfo");
                        }
                    }
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            using (var sw = new StreamWriter(path + $"\\ClubsInfo\\{club.Name}.txt", false, Encoding.UTF8))
            {
                sw.WriteLine($"Club name: {club.Name}");
                sw.WriteLine($"Club city: {club.City}");
                sw.WriteLine($"Number of participants: {club.NumberOfParticipants}");
                sw.WriteLine($"Club get participation in events: {club.SocietyActivities}");
            }
            Console.WriteLine($"Information about \"{club.Name}\" was successfully saved \nto \"" + path 
                + $"\\ClubsInfo\\{club.Name}.txt\"");
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
