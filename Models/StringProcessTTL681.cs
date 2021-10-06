using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace TTL681.Models

{
    public class TTL0681
    {
        [Key]
        public string TTLId { get; set; }
         [Display(Name = "Tên")]
        public string HTTName { get; set; }
         [Display(Name = "Giới Tính")]
        public string TTLGender { get; set; }
    }
       public class StringProcessTTL681 : TTL0681
    {
       
        public string TTLName { get; set; }
    }
}