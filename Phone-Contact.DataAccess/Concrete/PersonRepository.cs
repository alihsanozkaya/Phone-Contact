using Phone_Contact.Core.EntityFramework;
using Phone_Contact.DataAccess.Abstract;
using Phone_Contact.DataAccess.Contexts;
using Phone_Contact.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Contact.DataAccess.Concrete
{
    public class PersonRepository : EfBaseRepository<Person, ApplicationDbContext>, IPersonRepository
    {
       
    }
}
