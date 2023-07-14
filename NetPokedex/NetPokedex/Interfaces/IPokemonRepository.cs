using NetPokedex.Models;

namespace NetPokedex.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
    }
}
