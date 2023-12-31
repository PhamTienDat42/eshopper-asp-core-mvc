﻿using System.ComponentModel.DataAnnotations;

namespace EShopper.Models
{
    public class Color
    {
        [Key]
        public int ColorId { get; set; }
        [StringLength(150)]
        public string? ColorName { get; set; }
    }
}
