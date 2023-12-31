﻿using System.ComponentModel.DataAnnotations;

namespace EShopper.Models
{
    public class Size
    {
        [Key]
        public int SizeId { get; set; }
        [StringLength(30)]
        public string? SizeName { get; set; }
    }
}
