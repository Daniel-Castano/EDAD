using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application._5_ConsultarHistoriaClinica;
using Domain.HistoriaClinica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServicesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoriasClinicasController : ControllerBase
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