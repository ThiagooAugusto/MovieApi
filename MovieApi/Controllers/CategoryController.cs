using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Models;
using MovieApi.Repositories.Interfaces;

namespace MovieApi.Controllers
{
    public class CategoryController : ControllerBase
    {
        private readonly IBaseRepository<Category> _repository;

        public CategoryController(IBaseRepository<Category> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        // GET: Category
        public ActionResult Get()
        {
            var categorias = _repository.GetAll();
            return Ok(categorias);
        }

        [HttpGet("{id}")]
        // GET: Category/{id}
        public ActionResult Get(int id)
        {
            var categoriaExistente = _repository.Get(c=>c.Id ==  id);
            if(categoriaExistente == null)
                return NotFound(); 
            return Ok(categoriaExistente);
        }


       
        // POST: Category
        [HttpPost]
        public IActionResult Post(Category categoria)
        {
            var categoriaCriada = _repository.Create(categoria);
            return new CreatedAtActionResult(nameof(Get), "Category",
            new { id = categoriaCriada.Id },
            categoriaCriada);
        }

       
        // PUT: Category/{id}
        [HttpPut("{id}")]
        public ActionResult Put(int id, Category categoria)
        {
            if(id!=categoria.Id)
                return BadRequest();
            var categoriaExistente = _repository.Get(c=>c.Id==id);

            if (categoriaExistente == null)
                return NotFound();

            var categoriaAtualizada = _repository.Update(categoriaExistente);
            return Ok(categoriaAtualizada);
        }

        // DELETE: Category/{id}
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var categoriaExistente = _repository.Get(c => c.Id == id);
            if(categoriaExistente == null)
                return NotFound();

            var categoriaExcluida = _repository.Delete(categoriaExistente);
            return  Ok(categoriaExcluida);

        }
    }
}
