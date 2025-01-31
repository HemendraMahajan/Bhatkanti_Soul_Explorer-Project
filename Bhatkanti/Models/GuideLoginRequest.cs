﻿using System.ComponentModel.DataAnnotations;

namespace Bhatkanti_.Models
{
    public class GuideLoginRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}