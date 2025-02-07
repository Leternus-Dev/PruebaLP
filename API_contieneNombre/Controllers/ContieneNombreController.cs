using API_contieneNombre.Services;
using API_contieneNombre.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_contieneNombre.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContieneNombreController : ControllerBase
    {
        private readonly IContieneNombreCode _contieneNombreService;
        public ContieneNombreController(IContieneNombreCode service)
        {
            _contieneNombreService = service;
        }

        [HttpPost]
        public ActionResult<ContieneNombreResponse> ContieneNombre([FromBody] ContieneNombreRequest request)
        {
            bool resultado = _contieneNombreService.ContieneNombre(request.Info, request.Nombre);
            return Ok(new ContieneNombreResponse { Resultado = resultado });
        }


    }
}