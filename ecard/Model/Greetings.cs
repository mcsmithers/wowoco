using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ecard.Model
{
    public class Greetings
    {
        [Key]
        public int ID { get; set; }

        //when you do your own model, you are to make your own greetings with this pattern

        [DisplayName("Your Friend's Name")]
        [Display(Prompt = "Your Friend's Name")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
        public string friendname { get; set; }

        [DisplayName("Your Friend's Email")]
        [Display(Prompt = "Your Friend's Email")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
        public string friendemail { get; set; }

        [DisplayName("Email Subject")]
        [Display(Prompt = "Email Subject")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
        public string subject { get; set; }

        [DisplayName("Your Custom Message")]
        [Display(Prompt = "Your Custom Message")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
        public string message { get; set; }

        [DisplayName("Your Name")]
        [Display(Prompt = "Your Name")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
        public string sendername { get; set; }

        [DisplayName("Your Email")]
        [Display(Prompt = "Your Email")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
        public string senderemail { get; set; }
    }
}