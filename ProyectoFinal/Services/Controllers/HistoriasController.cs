using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application._5_ConsultarHistoriaClinica;
using Domain.HistoriaClinica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoriasController : ControllerBase
    {
        [HttpGet]

        public IEnumerable<HistoriaClinica> Get()
        {
            List<HistoriaClinica> historias;

            String jsonString = FakeDB.TablaHistoriaClinica.ToJSON();
            historias = System.Text.Json.JsonSerializer.Deserialize<List<HistoriaClinica>>(jsonString);

            return historias.ToList();
        }


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