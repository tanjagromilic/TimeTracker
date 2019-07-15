using TimeTrackerPMF.Domain;

namespace TimeTrackerPMF.Models
{
    public class ProjectInputModel
    {
        public string Name { get; set; }
        public long ClientId { get; set; }

        public void MapTo(Project project)
        {
            project.Name = Name;
        }

    }
}
