using Microsoft.AspNetCore.Mvc;
using apitest.Data;
using System.Collections.Generic;
using apitest.Models;

namespace apitest.Controllers
{
    //api/comida
    [Route("api/comida")]
    [ApiController]
    public class ComidaController: ControllerBase
    {
        private IComidaRepository _repository { get; set; }
        public ComidaController(IComidaRepository repository)
        {
            this._repository=repository;
        }
        // private readonly MockComidaRepository repository= new MockComidaRepository();
        
        [HttpGet]
        public ActionResult <IEnumerable<Comida>> GetComida (){
            var items=  _repository.GetComida();
            return Ok(items);
        }
        [HttpGet("{Id}")]
        public ActionResult <Comida> GetComidaById(int Id){
            var result = _repository.GetComidaById(Id);
            return Ok(result);
        }
    }
}