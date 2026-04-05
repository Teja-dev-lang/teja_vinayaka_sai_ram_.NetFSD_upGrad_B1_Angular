using MovieApp.Business.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Data.Repositories;
using MovieApp.Data.Entities;

namespace MovieApp.Business.Services
{
    public class MovieServices : IMovieServices
    {
        private readonly IMovieRepository _repo;

        public MovieServices(IMovieRepository repo)
        {
            _repo = repo;
        }
        public void AddMovie(MovieDTO movieDto)
        {
            if(movieDto == null)
            {
                throw new ArgumentNullException(nameof(movieDto));
            }
            if (string.IsNullOrWhiteSpace(movieDto.Title))
            {
                throw new Exception("Title is Required");
            }
            if (movieDto.Duration <= 0)
            {
                throw new Exception("Duration must be greater than 0");
            }
            if (movieDto.ReleaseDate > DateTime.Now)
            {
                throw new Exception("Movie Release Date cannot be in the Future");
            }
            var movie = new Movie()
            {
                MovieId = movieDto.MovieId,
                Title = movieDto.Title,
                Genre = movieDto.Genre,
                ReleaseDate = movieDto.ReleaseDate,
                Rating = movieDto.Rating,
                Duration = movieDto.Duration,
                Language = movieDto.Language
            };
            _repo.AddMovie(movie);

        }

        public void DeleteMovie(int id)
        {
            _repo.DeleteMovie(id);
        }

        public List<MovieDTO> GetAllMovies()
        {
            var movies = _repo.GetAllMovies();
            return movies.Select(movieDto => new MovieDTO()
            {
                MovieId = movieDto.MovieId,
                Title = movieDto.Title,
                Genre = movieDto.Genre,
                ReleaseDate = movieDto.ReleaseDate,
                Rating = movieDto.Rating,
                Duration = movieDto.Duration,
                Language = movieDto.Language
            }).ToList();
        }

        public MovieDTO? GetMovieById(string title)
        {
            var movie = _repo.GetMovieById(title);
            return new MovieDTO
            {
                MovieId = movie.MovieId,
                Title = movie.Title,
                Genre = movie.Genre,
                ReleaseDate = movie.ReleaseDate,
                Rating = movie.Rating,
                Duration = movie.Duration,
                Language = movie.Language
            };
        }

        public void UpdateMovie(MovieDTO movieDto)
        {
            var movie = new Movie()
            {
                Title = movieDto.Title,
                Genre = movieDto.Genre,
                ReleaseDate = movieDto.ReleaseDate,
                Rating = movieDto.Rating,
                Duration = movieDto.Duration,
                Language = movieDto.Language
            };
            _repo.UpdateMovie(movie);

        }
    }
}
