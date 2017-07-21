using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetNote.Models
{
    public class User
    {

        [Key]
        public int UserNo { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public string UserPassword { get; set; }
    }
}
