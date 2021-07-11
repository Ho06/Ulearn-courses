using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ULearn.DataBase.Entites;
using ULearn.Models;

namespace ULearn.Mapper
{
    public class ULearnMapper: Profile
    {
        public ULearnMapper()
        {
            CreateMap<Cart,CartVM>();
            CreateMap<CartVM, Cart>();
            CreateMap<Category,CategoryVM>();
            CreateMap<CategoryVM,Category>();
               
            //CreateMap<TophederCardsVM, TopHeaderCard>();
            //CreateMap<TopHeaderCard, TophederCardsVM>();



        }
    }
}
