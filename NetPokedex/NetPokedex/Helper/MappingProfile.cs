﻿using AutoMapper;
using NetPokedex.Dto;
using NetPokedex.Models;

namespace NetPokedex.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();
            CreateMap<Country, CountryDto>();
            CreateMap<CountryDto, Country>();
            CreateMap<Owner, OwnerDto>();
            CreateMap<OwnerDto, Owner>();
            CreateMap<Review, ReviewDto>();
            CreateMap<ReviewDto, Review>();
            CreateMap<Reviewer, ReviewerDto>();
            CreateMap<ReviewDto, Review>();
        }
    }
}
