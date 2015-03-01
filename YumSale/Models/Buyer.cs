﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace YumSale.Models
{
    /// <summary>
    /// Light weight account, then where is not item attached, it should be delete
    /// shouldn't need login
    /// </summary>
    public class Buyer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Contact { get; set; }

        public string Token { get; set; }
    }
}
