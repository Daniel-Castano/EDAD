using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Usuario.PacienteApp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class registroPacientesController : ControllerBase
    {
        [HttpGet]

        public IEnumerable<PacienteAfiliado> Get()
        {
            List<PacienteAfiliado> pacienteAfiliados;

            String jsonString = FakeDB.TablaHistoriaClinica.ToJSON();
            pacienteAfiliados = System.Text.Json.JsonSerializer.Deserialize<List<PacienteAfiliado>>(jsonString);

            return pacienteAfiliados.ToList();
        }
    }
}