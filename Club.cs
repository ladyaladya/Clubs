using System;

namespace ShwanLessonFive
{
    public class Club<T>
    {
        public T Id { get; set; }
        public string Name {get;set;}
        public int NumberOfParticipants { get; set; }
        public bool SocietyActivities { get; set; }
        public string City { get; set; }

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

        public void PrintFields(Club<T> club)
        {
            Console.WriteLine("Club name: " + club.Name);
            Console.WriteLine("Club city: " + club.City);
            Console.WriteLine("Number of participants: " + club.NumberOfParticipants);
            Console.WriteLine("Club get participation in events: " + club.SocietyActivities);
            Console.WriteLine("Club id: " + club.Id);
        }
    }
}
