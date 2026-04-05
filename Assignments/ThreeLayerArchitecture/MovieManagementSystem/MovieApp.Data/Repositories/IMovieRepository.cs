using MovieApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Data.Repositories
{
    public interface IMovieRepository
    {
        public List<Movie> GetAllMovies();
        public Movie? GetMovieById(string title);
        public void AddMovie(Movie movie);
        public void UpdateMovie(Movie movie);
        public void DeleteMovie(int id);
    }
}
