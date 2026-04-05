using MovieApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Data.Database;
namespace MovieApp.Data.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public readonly MovieDbContext _context;

        public MovieRepository(MovieDbContext context)
        {
            _context = context;
        }

        public void AddMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public void DeleteMovie(int id)
        {
            var movie = _context.Movies.Find(id);
            if (movie is null)
            {
                return;
            }

            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }

        public List<Movie> GetAllMovies()
        {
            var movies = _context.Movies.ToList();
            return movies;
        }

        public Movie? GetMovieById(string title)
        {
            Movie? movie = _context.Movies.SingleOrDefault(e => e.Title == title);
            return movie;
        }

        public void UpdateMovie(Movie movie)
        {
            _context.Movies.Update(movie);
            _context.SaveChanges();
        }
    }
}
