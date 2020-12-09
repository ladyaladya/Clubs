using System;

namespace ShwanLessonFive
{
    public class Club
    {
        public string Name { get; set; } = "Club name isn't specified";
        public int NumberOfParticipants { get; set; } = 0;
        public bool SocietyActivities { get; set; } = false;
        public string City { get; set; } = "Club city isn't specified";
        public delegate void EventHandler(Club club);
        public event EventHandler Notify;

        public Club(string name, bool societyActivities)
        {
            Name = name;
            SocietyActivities = societyActivities;
        }

        public Club()
        {
            
        }

        public Club(string name, bool societyActivities, string city)
        {
            Name = name;
            SocietyActivities = societyActivities;
            City = city;
        }

        public void StartSocietyActivities(Club club)
        {
            club.SocietyActivities = true;
            Notify?.Invoke(club);
        }


        public void PrintFields()
        {
            Console.WriteLine("Club name: " + Name);
            Console.WriteLine("Club city: " + City);
            Console.WriteLine("Number of participants: " + NumberOfParticipants);
            Console.WriteLine("Club get participation in events: " + SocietyActivities);
        }
    }
}
