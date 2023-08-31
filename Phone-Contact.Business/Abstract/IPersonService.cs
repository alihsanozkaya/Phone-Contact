using Phone_Contact.Core.Results;
using Phone_Contact.Entities.Dtos.Person;
using Phone_Contact.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Phone_Contact.Business.Abstract
{
    //Todo : Bunlar değiştirilecek
    public interface IPersonService
    {
        Task<IDataResult<IEnumerable<PersonDetailDto>>> GetListAsync(Expression<Func<Person, bool>> filter = null);

        Task<IDataResult<PersonDto>> AddAsync(PersonAddDto entity);


        Task<IDataResult<PersonUpdateDto>> UpdateAsync(PersonUpdateDto entity);

        Task<IDataResult<PersonDto>> GetAsync(Expression<Func<Person, bool>> filter);

        Task<IDataResult<bool>> DeleteAsync(int id);
    }
}
