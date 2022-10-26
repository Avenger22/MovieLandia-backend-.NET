﻿using DTO.MovieDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Domain.Contracts
{
    public interface IMoviesDomain
    {
        public IList<MoviesDTO> GetAllMovies();
        public MoviesDTO GetMovieById(int id);
    }
}
