using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application._5_ConsultarHistoriaClinica;
using Domain.HistoriaClinica;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Services.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet("{id}")]

        public String Get(string id)
        {
            Ctrl_ConsultarHistoriaClinica ctrlC = new Ctrl_ConsultarHistoriaClinica();

            try
            {
                return ctrlC.solicitarHistoriaClinica(id);
            }
            catch (HistoriaClinicaNoDisponibleException ex)
            {
                return "{" + ex.Message + "}";
            }
        }

    }
}
