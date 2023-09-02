using Phone_Contact.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Contact.Entities.Common
{
    public class BaseEntity : IEntity
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public int CreatedBy { get; set; } = 1;
        public DateTime? UpdatedDate { get; set; } 

        public int? UpdatedBy { get; set; } = 1;
    }
}
