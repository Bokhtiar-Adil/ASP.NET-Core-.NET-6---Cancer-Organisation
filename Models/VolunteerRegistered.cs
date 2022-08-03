using System.ComponentModel.DataAnnotations;

namespace NonProfitSiteV3.Models
{
    public class VolunteerRegistered
    {
        [Key]
        public int VReg_Id { get; set; }
        [Display(Name = "Branch")]
        public string VReg_branch { get; set; } 
        [Display(Name = "Name")]
        public string VReg_name { get; set; }
        [Display(Name = "Father's Name")]
        public string? VReg_father { get; set; }
        [Display(Name = "Contact Number/s")]
        public string VReg_contact { get; set; }
        [Display(Name = "Email")]
        public string VReg_email { get; set; }
        [Display(Name = "Educational Qualification")]
        public string VReg_education { get; set; }
        [Display(Name = "Previous Volunteer Experience/s")]
        public string VReg_experience { get; set; }
        [Display(Name = "Religion")]
        public string VReg_religion { get; set; }
        [Display(Name = "Date of Birth")]
        public string VReg_dob { get; set; }
        [Display(Name = "Current Address")]
        public string VReg_address { get; set; }
    }
}
