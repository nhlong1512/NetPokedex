using AutoMapper;
using NetPokedex.Dto;
using NetPokedex.Models;

namespace NetPokedex.Helper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Pokemon, PokemonDto>();
        }
    }
}
