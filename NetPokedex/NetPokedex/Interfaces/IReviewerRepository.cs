using NetPokedex.Models;

namespace NetPokedex.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviewers();
        Reviewer GetReviewer(int reviewerId);
        bool ReviewerExists(int reviewerId);
        ICollection<Review> GetReviewsByReviewer(int reviewerId);
    }
}
