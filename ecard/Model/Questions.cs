using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ecard.Model
{
    public class Questions
    {
        [Key]
        public int ID { get; set; }

        //when you do your own model, you are to make your own greetings with this pattern

        [DisplayName("Season")]
        [Display(Prompt = "What is your favorite season?")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
        public string season { get; set; }

        [DisplayName("Animal")]
        [Display(Prompt = "If you had the ability to be one animal for a day, what would you choose?")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
        public string animal { get; set; }

        [DisplayName("Language")]
        [Display(Prompt = "If you could learn any human language, what would you learn?")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
        public string language { get; set; }

        [DisplayName("History")]
        [Display(Prompt = "If you had the ability to spend an hour in any time and place in history, what is your choice?")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
        public string history { get; set; }

        [DisplayName("Meal")]
        [Display(Prompt = "If the chef of your dreams were to walk in this room and make you anyting you want for a single meal, what would you ask for?")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
        public string meal { get; set; }

        [DisplayName("Astronomical Object")]
        [Display(Prompt = "What is your favorite astronomical object in the sky?")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "You must enter between 2 to 100 characters")]
        public string astronomical { get; set; }
    }
}