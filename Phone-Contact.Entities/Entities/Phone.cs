using Phone_Contact.Entities.Common;
using Phone_Contact.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Contact.Entities.Entities
{
    public class Phone : BaseEntity
    {

        public string PhoneNumber { get; set; }
        public PhoneType PhoneType { get; set; }
    }
}
