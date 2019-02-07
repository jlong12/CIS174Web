using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Week2Assignment.shared.Enums;
using Week2Assignment.shared.ViewModels;

namespace Week2Assignment.Models
{
    public class PersonalDetailsModel
    {
        [Display(Name = "First Name: ")]
        public string firstName { get; set; }

        [Display(Name = "Last Name: ")]
        public string lastName { get; set; }

        [Display(Name = "Age: ")]
        public int age { get; set; }

        [Display(Name = "Major: ")]
        public string major { get; set; }

        public GenderEnum Gender { get; set; }
        [Display(Name = "Gender: ")]
        public string GenderName => Gender.ToString();

        public List<PersonalDetailsViewModel> PersonalDetails { get; set; }
    }
}