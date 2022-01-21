using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazerServerApp1._0.Models
{
    public class DisplayPersonModel
    {
        [Required]
        [StringLength(15, ErrorMessage = "First name is to long")]
        [MinLength(5, ErrorMessage = "First name is to short")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Last name is to long")]
        [MinLength(5, ErrorMessage = "Last name is to short")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAdress { get; set; }

    }
}
