using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOnProject.Domain;
using GameOnProject.Shared.Orchestrators.Interfaces;
using GameOnProject.Shared.ViewModels;

namespace GameOnProject.Shared.Orchestrators
{
    public class ProfileOrchestrator : IProfileOrchestrator
    {
        private readonly PlayerContext _playerContext;

        public ProfileOrchestrator()
        {
            _playerContext = new PlayerContext();
        }

        public async Task<bool> UpdateProfile(ProfileViewModel profile)
        {
            var updateEntity = await _playerContext.Profiles.FindAsync(profile.UserId);

            if (updateEntity == null)
            {
                return false;
            }

            updateEntity.FirstName = profile.FirstName;
            updateEntity.LastName = profile.LastName;
            updateEntity.Gender = profile.Gender;
            updateEntity.Email = profile.Email;
            updateEntity.PhoneNumber = profile.PhoneNumber;

            await _playerContext.SaveChangesAsync();

            return true;
        }
    }
}
