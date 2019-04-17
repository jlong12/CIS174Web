using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public ProfileViewModel GetProfileByEmail(string email)
        {

            var profile = _playerContext.Profiles.Where(x => x.Email == email)
                .Select(x => new ProfileViewModel
                {
                    Email = x.Email,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Gender = x.Gender,
                    PhoneNumber = x.PhoneNumber,
                    UserId = x.UserId
                }).SingleOrDefault();
            return profile;
        }

        public async Task<List<PersonViewModel>> GetAllPersons()
        {
            var persons = await _playerContext.Persons.Select(x => new PersonViewModel
            {
                PersonId = x.PersonId,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Gender = x.Gender,
                Email = x.Email,
                PhoneNumber = x.PhoneNumber
            }).ToListAsync();

            return persons;
        }
        // TODO: Make a method that gets the person by the email 


        public async Task<PersonViewModel> SearchPerson(string searchString)
        {
            var person = await _playerContext.Persons
                .Where(x => x.FirstName.StartsWith(searchString))
                .FirstOrDefaultAsync();

            if (person == null)
            {
                return new PersonViewModel();
            }

            var viewModel = new PersonViewModel
            {
                PersonId = person.PersonId,
                FirstName = person.FirstName,
                LastName = person.LastName,
                Gender = person.Gender,
                Email = person.Email,
                PhoneNumber = person.PhoneNumber
            };

            return viewModel;
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
