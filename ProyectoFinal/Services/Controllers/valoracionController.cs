using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application._4_ValorarPaciente;
using Domain.HistoriaClinica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.Valoracion;
using Domain.Usuario.Paciente;

namespace Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class valoracionController : ControllerBase
    {
         [HttpPost]

        public IActionResult Post([FromBody] Valoracion valoracionP)
         {

             Ctrl_ValorarPaciente ctrlC = new Ctrl_ValorarPaciente();

             List<Valoracion> valoracion = new List<Valoracion>();

             try
             {
                 if (ModelState.IsValid)
                 {


                     if (ctrlC.verificarCedula(valoracionP.cedula) == false && ctrlC.solicitarHistoriaClinica(valoracionP.cedula)==true)
                     {
                        valoracion.Add(valoracionP);
                     }
                     else 
                    {
                        valoracion.Clear();
                    }


                     return new CreatedAtRouteResult("La valoración del paciente ha sido creada", new { valoracionP });
                 }
             }
             catch (CedulaYaExisteException ex)
             {
                 return BadRequest(ex.Message);
             }
            catch(HistoriaClinicaNoDisponibleException ex)
            {
                return BadRequest(ex.Message);
            }

             return BadRequest(ModelState);

         }
    }
}