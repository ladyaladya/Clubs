using System;

namespace ShwanLessonFive
{
    public class Club
    {
        public string Name {get;set;}
        public int NumberOfParticipants { get; set; }
        public bool SocietyActivities { get; set; }
        public string City { get; set; }

        public Club(string name, bool societyActivities)
        {
            Name = name;
            SocietyActivities = societyActivities;
        }

        public Club(string name, bool societyActivities, string city)
        {
            Name = name;
            SocietyActivities = societyActivities;
            City = city;
        }

        public void PrintFields(Club club)
        {
            Console.WriteLine(club.Name);
            Console.WriteLine(club.City);
            Console.WriteLine(club.NumberOfParticipants);
            Console.WriteLine(club.SocietyActivities);
        }



    }
}
