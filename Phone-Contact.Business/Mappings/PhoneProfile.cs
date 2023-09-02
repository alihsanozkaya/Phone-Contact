using AutoMapper;
using Phone_Contact.Entities.Dtos.Phone;
using Phone_Contact.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Contact.Business.Mappings
{
    public class PhoneProfile : Profile
    {


        public PhoneProfile()
        {

            CreateMap<PhoneAddDto, Phone>();
            CreateMap<Phone, PhoneAddDto>();

            CreateMap<PhoneUpdateDto, Phone>();
            CreateMap<Phone, PhoneUpdateDto>();

            CreateMap<PhoneDetailDto, Phone>();
            CreateMap<Phone, PhoneDetailDto>();
            CreateMap<PhoneDto, Phone>();
            CreateMap<Phone, PhoneDto>();
        }
    }
}