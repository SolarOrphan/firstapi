using System.Collections.Generic;
using firstapi.Data;
using firstapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace firstapi.Controllers
{
    [Route("api/")]
    [ApiController]
    public class HowTosController : Controller
    {
        private Ifirstapirepo _repository;

        public HowTosController(Ifirstapirepo repo)
        {
            _repository = repo;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Howto>> GetAllHowTos()
        {
            var Howtoitems = _repository.GetData();
            return Ok(Howtoitems);
        }

        [HttpGet("{id}")]
        public ActionResult<Howto> GetHowTosById(int id)
        {
            var Howtoitem = _repository.getobject(id);
            return Ok(Howtoitem);
        }
    }
}