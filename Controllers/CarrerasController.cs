using Microsoft.AspNetCore.Mvc;
using ejemploClase2.Model;

namespace ejemploClase2.Controllers
{
    [ApiController]
    [Route("gestorMaterias")]
    public class CarrerasController : ControllerBase
    {
        List<Carrera> listCarreras = new List<Carrera>();
        public CarrerasController() {
            Carrera carrera1 = new Carrera(1, "Analista de Sistemas", 3);
            Carrera carrera2 = new Carrera(2, "Profesorado de Inglés", 4);
            listCarreras.Add(carrera1);
            listCarreras.Add(carrera2);
        }

        [HttpGet]
        [Route("materias")]
        public dynamic materias()
        {
            return listCarreras;
        }

        [HttpPost]
        [Route("crearMateria")]
        public dynamic agregarMaterias(List<Carrera> listaNueva)
        {
            foreach (Carrera materia in listaNueva)
            {
                listCarreras.Add(materia);
            }

            return listCarreras;
        }
    }
}
