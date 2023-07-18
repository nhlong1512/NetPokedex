using NetPokedex.Models;

namespace NetPokedex.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();
        Review GetReview(int reviewId);
        bool ReviewExists (int reviewId);
        ICollection<Review> GetReviewsByPokemon(int pokemonId);
        bool Save();
        bool CreateReview(Review review);
    }
}
