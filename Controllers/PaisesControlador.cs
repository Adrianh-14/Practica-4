using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace PRACTICA__4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisesControlador : ControllerBase
    {
        IAccciones acions;
        public PaisesControlador(IAccciones acions)
        {
            this.acions = acions;
        }

        [HttpGet("ver paises")]
        public IActionResult get()
        {

            return Ok(acions.getpaises());
        }
        [HttpGet("ver paises por continentes")]
        public IActionResult getPaisCont(string Continente)
        {

            return Ok(acions.pais(Continente));
        }
        [HttpGet("Mostrar nombre y apellido")]
        public IActionResult post(string nombre, string apellido)
        {

            return Ok(acions.NombreYapellido(nombre, apellido));
        }

        [HttpGet("Mostrar paises por cantidad de poblacion")]

        public IActionResult mostrar(int cantidad)
        {
            return Ok(acions.paisM(cantidad));
        }
        [HttpGet("Nombre y apellido")]

        public IActionResult mostrarNOmbre(string nombres, string apellidos)
        {
            return Ok(acions.NombreYapellido(nombres, apellidos));
        }
    }

}
