﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application._1_CrearServicio;
using Application._2_RegistrarPaciente;
using Domain.Usuario.Paciente;
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

            String jsonString = FakeDB.Usuario.ToJSON();
            pacienteAfiliados = System.Text.Json.JsonSerializer.Deserialize<List<PacienteAfiliado>>(jsonString);

            return pacienteAfiliados.ToList();
        }

        [HttpPost]

        public IActionResult Post([FromBody] PacienteAfiliado pacienteA)
        {

            Ctrl_RegistrarPaciente ctrlC = new Ctrl_RegistrarPaciente();

            List<PacienteAfiliado> pacienteAfiliado = new List<PacienteAfiliado>();

            if (ModelState.IsValid)
            {
                try
                {
                    if (ctrlC.verificarCedula(pacienteA.Cedula) == false)
                    {
                        pacienteAfiliado.Add(pacienteA);
                    }
                }

                catch (CedulaYaExisteException ex)
                {
                    return BadRequest(ex.Message);
                }

                try
                {
                    ctrlC.verificarDatos(pacienteA.Telefono, pacienteA.FechaNacimiento); 
                }

                catch (DatosNoValidosException ex)
                {
                    return BadRequest(ex.Message);
                }

                return new CreatedAtRouteResult("Nuevo paciente regitrado con éxito", new { pacienteA });

            }

            return BadRequest(ModelState);
            
        }
    }
}