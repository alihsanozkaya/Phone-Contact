using Phone_Contact.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Contact.Entities.Entities
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public List<Phone> Phones { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }

        public DateTime? BirthDate { get; set; }
    }
}
