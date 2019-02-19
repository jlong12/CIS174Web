using System;
using System.ComponentModel.DataAnnotations;

namespace GameOnEntertainment.Domain.Entities
{
    public class Person
    {
        public Guid PersonId { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Email { get; set; }
    }
}
