﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrartionWithAnotation
{
    public class CheckValidaton
    {
       // [Required(ErrorMessage = "Property check {0} is required")]
        [RegularExpression("^[A-Z]{1}[A-Za-z]{2,}$", ErrorMessage = "Name should be minimum 3 character and start with caps")]
       // [StringLength(100,MinimumLength =3 ,ErrorMessage = "Name should be minimum 3 character" )]
        public string FirstName { get; set; }

        [RegularExpression("^[A-Z]{1}[A-Za-z]{2,}$", ErrorMessage = "Name should be minimum 3 character and start with caps")]
        public string LastName { get; set; }
    }
}