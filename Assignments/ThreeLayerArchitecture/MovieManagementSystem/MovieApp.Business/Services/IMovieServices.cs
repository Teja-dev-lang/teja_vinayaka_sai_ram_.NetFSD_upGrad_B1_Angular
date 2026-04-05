using MovieApp.Business.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Business.Services
{
    public interface IMovieServices 
    {
        public List<MovieDTO> GetAllMovies();
        public MovieDTO? GetMovieById(string title);
        public void AddMovie(MovieDTO movie);
        public void UpdateMovie(MovieDTO movie);
        public void DeleteMovie(int id);
    }
}
