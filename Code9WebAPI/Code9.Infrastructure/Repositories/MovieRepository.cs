using Code9.Domain.Interfaces;
using Code9.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code9.Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly CinemaDbContext _dbContext;

        public MovieRepository(CinemaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Movie> AddMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Task<List<Movie>> GetAllMovies()
        {
            throw new NotImplementedException();
        }
    }
}
