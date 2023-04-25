using System.ComponentModel.DataAnnotations.Schema;
using CarRental.Domain.Shared;

namespace CarRental.Domain.Entities
{
    public class User : BaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }   
        
        public string Contact { get; set; }

        public string Address { get; set; }
    }
}
