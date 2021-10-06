using System;
using System.ComponentModel.DataAnnotations;

namespace TranThiLua681.Models
{
    public class TranThiLua681

    {   [Key]
        [StringLength(20, MinimumLength = 3)]
        public string PersonId { get; set; }
        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string PersonName { get; set; }

        
    }
}