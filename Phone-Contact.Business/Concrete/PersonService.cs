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
using System.Text.RegularExpressions;
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
        public async Task<IDataResult<PersonDto>> AddAsync(PersonAddDto entity)
        {
            var person = _mapper.Map<Person>(entity);

            var personAdd = await _personRepository.AddAsync(person);
            var personDto = _mapper.Map<PersonDto>(personAdd);

            return new SuccessDataResult<PersonDto>(personDto, Messages.Added);
        }

        public async Task<IDataResult<bool>> DeleteAsync(int id)
        {   

            var isDelete = await _personRepository.DeleteAsync(id);
            return new SuccessDataResult<bool>(isDelete,Messages.Deleted);
        }

        public async Task<IDataResult<PersonDto>> GetAsync(Expression<Func<Person, bool>> filter)
        {
                var person = await _personRepository.GetAsync(filter);
                if (person == null)
                {
                        return new ErrorDataResult<PersonDto>(null,Messages.NotListed);
                }
                var personDto = _mapper.Map<PersonDto>(person);
                return new SuccessDataResult<PersonDto>(personDto);
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

        public async Task<IDataResult<PersonUpdateDto>> UpdateAsync(PersonUpdateDto entity)
        {   

            var getPerson = await _personRepository.GetAsync(x  => x.Id == entity.Id);
            var person = _mapper.Map<Person>(entity);

            person.UpdatedDate = DateTime.UtcNow;
            person.UpdatedBy = 1;

            var personUpdateDto = _mapper.Map<PersonUpdateDto>(person);
            return new SuccessDataResult<PersonUpdateDto>(personUpdateDto, Messages.Updated);
        }
    }
}
