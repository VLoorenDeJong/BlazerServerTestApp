using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazerServerApp3.Models
{
    public class DisplayPersonModel
    {
        [Required]
        [MaxLength(15, ErrorMessage ="First name to long")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(15, ErrorMessage = "Last name to long")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAdress { get; set; }

    }
}
