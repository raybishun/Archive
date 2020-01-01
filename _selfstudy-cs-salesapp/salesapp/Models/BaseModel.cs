﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SalesApp.Models
{
    class BaseModel
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(100)]
        public string UpdatedBy { get; set; }

        [Required]
        public DateTime UpdatedDate { get; set; }
    }
}
