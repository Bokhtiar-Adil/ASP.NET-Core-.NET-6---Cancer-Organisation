using System.ComponentModel.DataAnnotations;

namespace NonProfitSiteV3.Models
{
    public class TreatmentCenters
    {
        [Key]
        public int TC_Id { get; set; }
        [Display(Name = "Name")]
        public string TC_name { get; set; }
        [Display(Name = "Description")]
        public string TC_description { get; set; }
        [Display(Name = "Address")]
        public string TC_address { get; set; }
        [Display(Name = "Contact Number/s")]
        public string TC_contact { get; set; }
        [Display(Name = "Email")]
        public string TC_email { get; set; }
    }
}
