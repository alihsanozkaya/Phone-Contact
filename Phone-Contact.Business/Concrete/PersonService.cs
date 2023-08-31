using AutoMapper;
using Phone_Contact.Business.Abstract;
using Phone_Contact.Business.Constants;
using Phone_Contact.Core.Results;
using Phone_Contact.DataAccess.Abstract;
using Phone_Contact.Entities.Dtos.Person;
using Phone_Contact.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Contact.Business.Concrete
{
    public class PersonService : IPersonService
    {
        IMapper _mapper;
        IPersonRepository _personRepository;
        public PersonService(IPersonRepository personRepository,IMapper mapper)
        {
            _mapper = mapper;
            _personRepository = personRepository;
         }
        public Task<IDataResult<PersonDto>> AddAsync(PersonAddDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<bool>> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<PersonDto>> GetAsync(Expression<Func<Person, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<PersonDetailDto>>> GetListAsync(Expression<Func<Person, bool>> filter = null)
        {
            //Todo  : Automapper eklenecek
            // Dependency Injection olacak 
            //Todo : IDataResult tiplerine göre  DataResultlar döndürlecek
            if (filter == null)
            {
                // Exception 
                //throw new UnauthorizedAccessException("UnAuthorized"); 
                var response = await _personRepository.GetListAsync();
                var responseDetailDto = _mapper.Map<IEnumerable<PersonDetailDto>>(response);
                return new SuccessDataResult<IEnumerable<PersonDetailDto>>(responseDetailDto, Messages.Listed);
            }
            else
            {
                var response = await _personRepository.GetListAsync(filter);
                var responseDetailDto = _mapper.Map<IEnumerable<PersonDetailDto>>(response);
                return new SuccessDataResult<IEnumerable<PersonDetailDto>>(responseDetailDto, Messages.Listed);
            }

        }

        public Task<IDataResult<PersonUpdateDto>> UpdateAsync(PersonUpdateDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
