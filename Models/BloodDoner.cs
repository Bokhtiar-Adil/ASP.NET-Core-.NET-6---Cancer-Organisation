using System.ComponentModel.DataAnnotations;

namespace NonProfitSiteV3.Models
{
    public class BloodDoner
    {
        [Key]
        public int BB_Id { get; set; }
        [Display(Name = "Name")]
        public string BB_name { get; set; }
        [Display(Name = "Father's Name")]
        public string? BB_father { get; set; }
        [Display(Name = "Contact Number/s")]
        public string BB_contact { get; set; }
        [Display(Name = "Email")]
        public string? BB_email { get; set; }
        [Display(Name = "Address")]
        public string BB_address { get; set; }
        [Display(Name = "Occupation")]
        public string BB_occupation { get; set; }
        [Display(Name = "Bloodtype")]
        public string BB_blodtype { get; set; }
        [Display(Name = "Quantity (In Bags)")]
        public int BB_quantity { get; set; }
        [Display(Name = "Deadline (in days)")]
        public int BB_deadline { get; set; }
    }
}
