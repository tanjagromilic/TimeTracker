using System.ComponentModel.DataAnnotations;

namespace TimeTrackerPMF.Client.Models
{
    public class UserInputModel
    {
        [Required]
        public string Name { get; set; }

        [Range(1,1000)]
        public decimal HourRate { get; set; }

       
    }
}
