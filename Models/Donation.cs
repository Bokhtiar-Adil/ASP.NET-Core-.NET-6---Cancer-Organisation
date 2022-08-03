using System.ComponentModel.DataAnnotations;

namespace NonProfitSiteV3.Models
{
    public class Donation
    {
        [Key]
        public int Don_ID { get; set; }
        [Display(Name = "Contact Number/s")]
        public string Don_contact { get; set; }
        [Display(Name = "Email")]
        public string? Don_email { get; set; }
        [Display(Name = "Amount (in Taka)")]
        public int Don_amount { get; set; }
        [Display(Name = "Payment Method and Details")]
        public string Don_details { get; set; }
    }
}
