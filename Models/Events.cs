using System.ComponentModel.DataAnnotations;

namespace NonProfitSiteV3.Models
{
    public class Events
    {
        [Key]
        public int Ev_Id { get; set; }
        [Display(Name = "Name")]
        public string Ev_name { get; set; }
        [Display(Name = "Location")]
        public string Ev_location { get; set; }
        [Display(Name = "Time and Date")]
        public string Ev_timedate { get; set; }
        [Display(Name = "Status")]
        public string Ev_status { get; set; }
    }
}
