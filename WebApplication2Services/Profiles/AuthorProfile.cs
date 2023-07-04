using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2Services.Models;

namespace WebApplication2Services.Profiles
{
    public class AuthorProfile:Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorDto>()
                .ForMember(dest=>dest.Address,opt=>opt.MapFrom(src=>$"{src.AddressNo},{src.Street},{src.City}"));
        }
    }
}
