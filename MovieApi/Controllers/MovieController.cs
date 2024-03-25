
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Models;
using MovieApi.Repositories.Interfaces;

namespace MovieApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly IBaseRepository<Movie> _repository;
        private readonly IMovieRepository _movieRepository;

        public MovieController(IMovieRepository movieRepository,IBaseRepository<Movie>repository)
        {
            _repository = repository;
            _movieRepository = movieRepository;
        }

        //GET: 
        [HttpGet("Movie/{id}")]
        public ActionResult<IEnumerable<Movie>> GetMoviesByCategory(int id)
        {
            var filmesPorCategoria = _movieRepository.GetMoviesByCategory(id);

            if (filmesPorCategoria == null)
                return NotFound();
          return Ok(filmesPorCategoria);
        }

        // GET: Movie
        [HttpGet]
        public ActionResult<IEnumerable<Movie>> GetAll()
        {
            var filmes = _repository.GetAll();
            return Ok(filmes);
        }

        // GET: Movie/{id}
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var filmeExistente = _repository.Get(m=>m.Id == id);

            if(filmeExistente == null)
                return NotFound();

            return Ok(filmeExistente);

        }

        

        // POST: Movie
        [HttpPost]
        public IActionResult Create(Movie filme)
        {
            var filmeCriado = _repository.Create(filme);
            return new CreatedAtActionResult(nameof(Get), "Movie", new {id = filmeCriado.Id},filmeCriado);
        }


        // PUT: Movie
        [HttpPost]
       
        public IActionResult Edit(int id, Movie filme)
        {
           if(id!= filme.Id)
                return BadRequest();
           var filmeExistente = _repository.Get(f=> f.Id == id);
            if(filmeExistente == null)
                return NotFound();
            var filmeAtualizado = _repository.Update(filmeExistente);
            return Ok(filmeAtualizado);
        
        }

        
       
        // POST: Movie/{id}
        public IActionResult Delete(int id)
        {
            var filmeExistente = _repository.Get(f => f.Id == id);
            if (filmeExistente == null)
                return NotFound();
            var filmeExcluido = _repository.Delete(filmeExistente);
            return Ok(filmeExcluido);
        }
    }
}
