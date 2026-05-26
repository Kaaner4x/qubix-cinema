using QubixCinema.DataAccess;
using QubixCinema.Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace QubixCinema.Business.Services
{
    public class MovieService
    {
        private readonly QubixCinemaContext _context;

        public MovieService(QubixCinemaContext context)
        {
            _context = context;
        }

        public List<Movie> GetAllMovies()
        {
            return _context.Movies.ToList();
        }

        public Movie GetMovieById(int id)
        {
            return _context.Movies.FirstOrDefault(m => m.MovieId == id);
        }

        public void AddMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public void UpdateMovie(Movie movie)
        {
            var existingMovie = _context.Movies.FirstOrDefault(m => m.MovieId == movie.MovieId);
            if (existingMovie != null)
            {
                existingMovie.MovieName = movie.MovieName;
                existingMovie.Genre = movie.Genre;
                existingMovie.Runtime = movie.Runtime;
                existingMovie.ReleaseDate = movie.ReleaseDate;
                _context.SaveChanges();
            }
        }

        public void DeleteMovie(int id)
        {
            var existingMovie = _context.Movies.FirstOrDefault(m => m.MovieId == id);
            if (existingMovie != null)
            {
                _context.Movies.Remove(existingMovie);
                _context.SaveChanges();
            }
        }
    }
}
