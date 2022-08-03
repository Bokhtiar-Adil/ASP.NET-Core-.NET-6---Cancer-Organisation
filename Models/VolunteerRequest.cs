using System.ComponentModel.DataAnnotations;

namespace NonProfitSiteV3.Models
{
    public class VolunteerRequest
    {
        [Key]
        public int VLreq_Id { get; set; }
        [Display(Name = "Name")]
        public string VLreq_name { get; set; }
        [Display(Name = "Father's Name")]
        public string? VLreq_father { get; set; }
        [Display(Name = "Contact Number/s")]
        public string VLreq_contact { get; set; }
        [Display(Name = "Email")]
        public string? VLreq_email { get; set; }
        [Display(Name = "Address")]
        public string VLreq_address { get; set; }
        [Display(Name = "Occupation")]
        public string VLreq_occupation { get; set; }
        [Display(Name = "Why Do You Need Volunteers?")]
        public string VLreq_type { get; set; }
        [Display(Name = "How Many Volunteer Needed?")]
        public int VLreq_quantity { get; set; }
    }
}
