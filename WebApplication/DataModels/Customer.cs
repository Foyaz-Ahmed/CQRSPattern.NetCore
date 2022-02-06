using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class Customer
    {
        [Key]
        public int Id { set; get; }

        [Required]
        [DisplayName("Name")]
        public string CustomerName { set; get; }

        [Required]
        public string Email { set; get; }

        [Required]
        public bool Gender { set; get; }

        [Required]
        public int Age { set; get; }

    }
}
