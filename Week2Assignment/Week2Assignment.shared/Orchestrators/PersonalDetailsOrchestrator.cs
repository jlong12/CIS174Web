using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2Assignment.shared.Orchestrators.Interfaces;
using Week2Assignment.shared.ViewModels;

namespace Week2Assignment.shared.Orchestrators
{
    public class PersonalDetailsOrchestrator : IPersonalDetailsOrchestrator
    {
        public List<PersonalDetailsViewModel> GetPersonalDetails()
        {
            var personaldetails = new List<PersonalDetailsViewModel>
            {
                new PersonalDetailsViewModel
                {
                    firstName = "Jonathan",
                    lastName = "Long",
                    age = 24,
                    major = "BIS Web Development"
                }
            };

            return personaldetails;
        }
    }
}
