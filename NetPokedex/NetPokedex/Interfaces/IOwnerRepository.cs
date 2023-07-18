using NetPokedex.Models;

namespace NetPokedex.Interfaces
{
    public interface IOwnerRepository
    {
        ICollection<Owner> GetOwners();
        Owner GetOwner(int ownerId);
        bool OwnerExists(int ownerId);
        ICollection<Pokemon> GetPokemonsByOwner(int ownerId);
        ICollection<Owner> GetOwnersByPokemon(int pokemonId);
        bool Save();
        bool CreateOwner(Owner owner);
    }
}
