using System.ComponentModel.DataAnnotations;

namespace NonProfitSiteV3.Models
{
    public class FinancialAid
    {
        [Key]
        public int AID_Id { get; set; }

        [Display(Name = "Name")]
        public string AID_name { get; set; }

        [Display(Name = "Father's Name")]
        public string? AID_father { get; set; }

        [Display(Name = "Contact Number/s")]
        public string AID_contact { get; set; }

        [Display(Name = "Email")]
        public string? AID_email { get; set; }

        [Display(Name = "Address")]
        public string AID_address { get; set; }

        [Display(Name = "Occupation")]
        public string AID_occupation { get; set; }

        [Display(Name = "Reason")]
        public string AID_reason { get; set; }
    }
}
