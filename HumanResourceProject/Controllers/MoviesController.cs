﻿using Domain.Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace MovieLandia.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMoviesDomain _moviesDomain;

        public MoviesController(IMoviesDomain moviesDomain)
        {
            _moviesDomain = moviesDomain;
        }

        [HttpGet]
        [Route("getAllMovies")]
        public IActionResult GetAllMovies()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }

                var movies = _moviesDomain.GetAllMovies();

                if (movies != null)
                {
                    return Ok(movies);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("getMovieById/{id}")]
        public IActionResult GetMovieById([FromRoute] int id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();
                var movie = _moviesDomain.GetMovieById(id);

                if (movie != null)
                    return Ok(movie);

                return NotFound();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
