using System.ComponentModel.DataAnnotations;

namespace NonProfitSiteV3.Models
{
    public class VolunteerApplicants
    {
        [Key]
        public int VA_Id { get; set; }
        [Display(Name = "Name")]
        public string VA_name { get; set; }
        [Display(Name = "Father's Name")]
        public string? VA_father { get; set; }
        [Display(Name = "Contact Number/s")]
        public string VA_contact { get; set; }
        [Display(Name = "Email")]
        public string VA_email { get; set; }
        [Display(Name = "Educational Qualification")]
        public string VA_education { get; set; }
        [Display(Name = "Previous Volunteer Experience/s")]
        public string VA_experience { get; set; }
        [Display(Name = "Religion")]
        public string VA_religion { get; set; }
        [Display(Name = "Date of Birth")]
        public string VA_dob { get; set; }
        [Display(Name = "Current Address")]
        public string VA_address { get; set; }

    }
}
