﻿using System.ComponentModel.DataAnnotations;

namespace BookWise.Models
{
    public class LoginModel
    {
        [Required]
        public string UserName { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
    }
}