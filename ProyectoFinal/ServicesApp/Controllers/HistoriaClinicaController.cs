using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application._5_ConsultarHistoriaClinica;
using Domain.HistoriaClinica;
using Domain.Usuario.Paciente;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ServicesApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HistoriaClinica : ControllerBase
    {

        [HttpGet("{id}")]

        public String Get(string id)
        {
            Ctrl_ConsultarHistoriaClinica ctrlC = new Ctrl_ConsultarHistoriaClinica();

            try
            {
                return ctrlC.getHistoriaClinica(id);
            }
            catch (HistoriaClinicaNoDisponibleException ex)
            {
                return "{" + ex.Message + "}";
            }
        }
    }
}
