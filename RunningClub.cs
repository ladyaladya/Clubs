using System;

namespace ShwanLessonFive
{
    public class RunningClub : Club
    {
        public RunningClub(string name, bool societyActivities, string city) : base(name, societyActivities, city)
        {
        }

        public RunningClub(string name, bool societyActivities) : base(name, societyActivities)
        {
        }
        public RunningClub MergeClubs(RunningClub rc1, RunningClub rc2)
        {
            RunningClub RCMerged = new RunningClub("", false, "");
            if ((rc1.City == rc2.City) && ((rc1.SocietyActivities == true) || (rc2.SocietyActivities == true)))
            {
                RCMerged.NumberOfParticipants = rc1.NumberOfParticipants + rc2.NumberOfParticipants;
                RCMerged.SocietyActivities = true;
                RCMerged.City = rc1.City;
                if (rc1.NumberOfParticipants >= rc2.NumberOfParticipants)
                {
                    RCMerged.Name = rc1.Name;
                }
                else RCMerged.Name = rc2.Name;
            }
            return RCMerged;
        }
    }
}
