using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2Assignment.shared.ViewModels;

namespace Week2Assignment.shared.Orchestrators.Interfaces
{
    public interface IPersonalDetailsOrchestrator
    {
        List<PersonalDetailsViewModel> GetPersonalDetails();

    }
}
