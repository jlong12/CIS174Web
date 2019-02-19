using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOnEntertainment.Domain;
using GameOnEntertainment.Shared.ViewModels;

namespace GameOnEntertainment.Shared.Orchestrators
{
    public class PersonOrchestrator
    {
        private readonly PlayerContext _playerContext;
       
        public PersonOrchestrator()
        {
            _playerContext = new PlayerContext();   
        }

        public List<PersonViewModel> GetAllPersons()
        {
            var persons = _playerContext.Persons.Select(x => new PersonViewModel
            {
                PersonId = x.PersonId,
                FirstName = x.FirstName,
                LastName = x.LastName,
                DateCreated = x.DateCreated,
                Email = x.Email
            }).ToList();

            return persons;
        }
        
    }
}
