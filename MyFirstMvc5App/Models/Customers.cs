using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFirstMvc5App.Models
{
    public class Customers
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings=false,ErrorMessage="First Name is compulasary")]
        [DataType(DataType.Text)]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Last Name is compulasary")]
        [DataType(DataType.Text)]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Address is compulasary")]
        [DataType(DataType.MultilineText)]
        [MaxLength(350)]
        public string Address { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is compulasary")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(120)]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Contact Number is compulasary")]
        [DataType(DataType.PhoneNumber)]
        [MaxLength(30)]
        public string ContactNumber { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Post Code is compulasary")]
        [RegularExpression(@"^([A-PR-UWYZ0-9][A-HK-Y0-9][AEHMNPRTVXY0-9]?[ABEHMNPRVWXY0-9]? {1,2}[0-9][ABD-HJLN-UW-Z]{2}|GIR 0AA)$")]
        [MaxLength(10)]
        public string PostCode { get; set; }

        public string PreferredContactMode { get; set; }

        


    }
}