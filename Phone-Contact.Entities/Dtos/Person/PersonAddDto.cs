using Phone_Contact.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Contact.Entities.Dtos.Person
{
    public class PersonAddDto : IDto
    {

        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }

        //public List<Phone> Phones { get; set; }
    }
}
