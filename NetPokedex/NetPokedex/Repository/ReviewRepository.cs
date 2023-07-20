﻿using NetPokedex.Data;
using NetPokedex.Interfaces;
using NetPokedex.Models;

namespace NetPokedex.Repository
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly DataContext _context;

        public ReviewRepository( DataContext context)
        {
            _context = context;
        }


        public Review GetReview(int reviewId)
        {
            return _context.Reviews.Where(r => r.Id == reviewId).FirstOrDefault();
        }

        public ICollection<Review> GetReviews()
        {
            return _context.Reviews.ToList();
        }

        public ICollection<Review> GetReviewsByPokemon(int pokemonId)
        {
            return _context.Reviews.Where(r => r.Pokemon.Id == pokemonId).ToList();
        }

        public bool ReviewExists(int reviewId)
        {
            return _context.Reviews.Any(r => r.Id == reviewId);
        }
        public bool CreateReview(Review review)
        {
            _context.Add(review);
            return Save();

        }

        public bool UpdateReview(Review review)
        {
            _context.Update(review);
            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }


    }
}
