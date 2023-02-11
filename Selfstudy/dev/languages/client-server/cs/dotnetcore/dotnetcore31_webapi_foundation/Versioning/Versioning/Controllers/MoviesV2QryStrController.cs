﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Versioning.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

// ============================================================================
// Versioning using Query Strings, i.e.: api/movies?api-version=2.0
// ============================================================================

namespace Versioning.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/movies")]
    [ApiController]
    public class MoviesV2QryStrController : ControllerBase
    {
        static List<MoviesV2> _movies = new List<MoviesV2>()
        {
            new MoviesV2() {Id=0, MovieDescription="Non-stop, action packed...", MovieName="John Wick", MovieType="Action"},
            new MoviesV2() {Id=0, MovieDescription="Another non-stop, action packed...", MovieName="John Wick2", MovieType="Action" }
        };

        // GET: https://localhost:44300/api/movies?api-version=2.0
        [HttpGet]
        public IEnumerable<MoviesV2> Get()
        {
            return _movies;
        }

        // GET api/<MoviesV2Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MoviesV2Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MoviesV2Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MoviesV2Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
