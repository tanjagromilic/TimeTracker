using System;
using TimeTrackerPMF.Domain;

namespace TimeTrackerPMF.Models
{
    public class TimeEntryModel
    {
        private TimeEntryModel()
        {
        }
        public long Id { get; set; }
        public long ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ClientName { get; set; }
        public long UserId { get; set; }
        public string UserName { get; set; }
        public DateTime EntryDate { get; set; }
        public int Hours { get; set; }
        public string Description { get; set; }
        public decimal HourRate { get; set; }
        public decimal Total => Hours * HourRate;

        public static TimeEntryModel FromTimeEntry(TimeEntry timeEntry)
        {
            return new TimeEntryModel
            {
                Id = timeEntry.Id,
                UserId = timeEntry.User.Id,
                UserName = timeEntry.User.Name,
                ProjectId = timeEntry.Project.Id,
                ProjectName = timeEntry.Project.Name,
                ClientName = timeEntry.Project.Client.Name,
                EntryDate = timeEntry.EntryDate,
                Hours = timeEntry.Hours,
                HourRate = timeEntry.HourRate,
                Description = timeEntry.Description
            };
        }
    }
}
