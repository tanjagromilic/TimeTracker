using System.ComponentModel.DataAnnotations;

namespace TimeTrackerPMF.Client.Models
{
    public class ClientInputModel
    {
        [Required]
        public string Name { get; set; }

    }


}
