using System;
using System.ComponentModel.DataAnnotations;

namespace TranThiLua681.Models
{
    public class TTL681
    {
        [Key]
        [StringLength(20, MinimumLength = 3)]
        public int TLLId { get; set; }
         [StringLength(50, MinimumLength = 3)]
        public string TTLName { get; set; }
        [StringLength(4000), Required(ErrorMessage="Please enter product description.")]
        public string TTLGender { get; set; }
    }
}