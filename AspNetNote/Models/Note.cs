using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetNote.Models
{
    public class Note
    {
        [Key]
        public int NoteNo { get; set; }

        [Required]
        public string NoteTitle { get; set; }

        [Required]
        public string NoteContents { get; set; }

        [Required]
        public int UserNo { get; set; }

        [ForeignKey("UserNo")]
        public virtual User User { get; set; }
    }
}
