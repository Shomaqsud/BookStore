using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers

{
        [ApiController]
        [Route("Autor")]
    
        public class AutorController : ControllerBase
        {
            private readonly BookStoreContext _appContext;
            public AutorController(BookStoreContext appContext)
            {
                _appContext = appContext;
            }
            [HttpPost]
            public int CreateAutor(Autor autor)
            {
                _appContext.Autors.Add(autor);
                _appContext.SaveChanges();
                return autor.Id;
            }
            [HttpGet]
            public List<Autor> GetAutor()
            {
                return _appContext.Autors.ToList();
            }
            [HttpDelete]
            public void DeleteAutor(int autorid)
            {
                var a = _appContext.Autors.FirstOrDefault(a => a.Id == autorid);
                _appContext.Autors.Remove(a);
                _appContext.SaveChanges();
            }

            [HttpPut]
            public Autor UpdateAutor(Autor autor)
            {
                _appContext.Autors.Update(autor);
                _appContext.SaveChanges();
                return autor;
            }
        }
    
}
