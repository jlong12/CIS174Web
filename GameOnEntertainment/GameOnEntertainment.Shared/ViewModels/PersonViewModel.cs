﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOnEntertainment.Shared.ViewModels
{
    public class PersonViewModel
    {
        public Guid PersonId { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Email { get; set; }
    }
}
