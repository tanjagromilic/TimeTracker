using System;
using TimeTrackerPMF.Domain;

namespace TimeTrackerPMF.Models
{
    public class UserInputModel
    {
        public string Name { get; set; }
        public decimal HourRate { get; set; }

        public void MapTo(User user)
        {
            user.Name = Name;
            user.HourRate = HourRate;
        }
    }
}
