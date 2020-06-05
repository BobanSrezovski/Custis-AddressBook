using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AddressBook.Data.Entities
{
    public class Person
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "You must provide a First Name")]
        [DisplayName("First Name")]
        [StringLength(20, ErrorMessage = "First name is to long")]
        [RegularExpression(@"^[A-Za-z]+(((\'|\-|\.)?([A-Za-z])+))?$", ErrorMessage = "Not a valid name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "You must provide a Last Name")]
        [DisplayName("Last Name")]
        [StringLength(50, ErrorMessage = "Last name is to long")]
        [RegularExpression(@"^[A-Za-z]+(((\'|\-|\.)?([A-Za-z])+))?$", ErrorMessage = "Not a valid last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessage = "Not a valid phone number, example: 070 111-222 or 070111222")]
        public string MobileNumber { get; set; }

        [Display(Name = "Work Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{2,3})\)?[-. ]?([0-9]{3,4})[-. ]?([0-9]{3})$", ErrorMessage = "Not a valid phone number, example: 02 3111-222 or 023111222")]
        public string WorkNumber { get; set; }

        [Display(Name = "Home Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{2,3})\)?[-. ]?([0-9]{3,4})[-. ]?([0-9]{3})$", ErrorMessage = "Not a valid phone number, example: 02 3111-222 or 023111222")]
        public string HomeNumber { get; set; }

        [DisplayName("Home Address")]
        [StringLength(100)]
        public string HomeAddress { get; set; }

        [DisplayName("Work Address")]
        [StringLength(100)]
        public string WorkAddress { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$", ErrorMessage = "Not a valid email address")]
        public string EmailAddress { get; set; }


    }
}
