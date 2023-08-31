using AutoMapper;
using Phone_Contact.Entities.Dtos.Person;
using Phone_Contact.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Contact.Business.Mappings
{
    public class PersonProfile : Profile
    {


        public PersonProfile()
        {

            CreateMap<PersonDetailDto, Person>();
            CreateMap<Person, PersonDetailDto>();

            //CreateMap<CategoryUpdateDto, Category>();
            //CreateMap<Category, CategoryUpdateDto>();

            //CreateMap<CategoriesDto, Category>();
            //CreateMap<Category, CategoriesDto>();

        }
    }
}
