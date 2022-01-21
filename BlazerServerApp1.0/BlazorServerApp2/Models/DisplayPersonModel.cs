using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerApp2.Models
{
    public class DisplayPersonModel
    {
        [Required]
        [MaxLength(20, ErrorMessage ="First name is to long")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage ="Last name is to long")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAdress { get; set; }
    }
}
