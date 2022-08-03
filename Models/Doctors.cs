using System.ComponentModel.DataAnnotations;

namespace NonProfitSiteV3.Models
{
    public class Doctors
    {
        [Key]
        public int Doc_Id { get; set; }
        [Display(Name = "Name")]
        public string Doc_name { get; set; }
        [Display(Name = "Description")]
        public string Doc_description { get; set; }
        [Display(Name = "City / Country")]
        public string Doc_city { get; set; }
        [Display(Name = "Contact Number/s")]
        public string Doc_contact { get; set; }
        [Display(Name = "Email")]
        public string Doc_email { get; set; }
    }
}
