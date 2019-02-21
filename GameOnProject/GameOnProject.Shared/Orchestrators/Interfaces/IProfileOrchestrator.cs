using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOnProject.Shared.ViewModels;

namespace GameOnProject.Shared.Orchestrators.Interfaces
{
    public interface IProfileOrchestrator
    {
        Task<bool> UpdateProfile(ProfileViewModel profile);
    }
}
