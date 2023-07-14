using Microsoft.AspNetCore.Mvc;
using NetPokedex.Data;
using NetPokedex.Interfaces;
using NetPokedex.Models;
using System;

namespace NetPokedex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : Controller
    {
        private readonly IPokemonRepository _pokemonRepository;
        private readonly DataContext _datacontext;

        public PokemonController(IPokemonRepository pokemonRepository, DataContext datacontext)
        {
            _pokemonRepository = pokemonRepository;
            _datacontext = datacontext;
        }
        [HttpGet]
        [ProducesResponseType(200,Type=typeof(IEnumerable<Pokemon>))]
        public IActionResult GetPokemons()
        {
            var pokemons = _pokemonRepository.GetPokemons();
            if(!ModelState.IsValid) 
            {
                return BadRequest(ModelState);
            }
            return Ok(pokemons);
        }
    }
}
 