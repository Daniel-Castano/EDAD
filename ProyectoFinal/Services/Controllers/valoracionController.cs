using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application._4_ValorarPaciente;
using Domain.HistoriaClinica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class valoracionController : ControllerBase
    {

        [HttpGet("{id}")]

        public String Get(string id)
        {
            Ctrl_ValorarPaciente ctrlC = new Ctrl_ValorarPaciente();

            try
            {
                return ctrlC.verificarCedula(id);
            }
            catch (HistoriaClinicaNoDisponibleException ex)
            {
                return "{" + ex.Message + "}";
            }
        }
    }
}