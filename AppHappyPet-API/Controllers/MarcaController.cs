﻿using Business;
using Entity.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppHappyPet_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        private readonly MarcaService mar_service;

        public MarcaController(MarcaService mar_service)
        {
            this.mar_service = mar_service;
        }

        // GET: api/<MarcaController>
        [HttpGet]
        public IActionResult ListarMarcas([FromQuery] string? nombre)
        {
            try
            {
                var marcas = mar_service.ListarMarcas(nombre!);
                return Ok(new { mensaje = "Marcas encontradas", data = marcas });
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensaje = ex.Message });
            }

        }

        // POST api/<MarcaController>
        [HttpPost]
        public IActionResult RegistrarMarcas([FromBody] Marca marca)
        {
            try
            {
                var resultado = mar_service.RegistrarMarcas(marca);
                return Ok(new { mensaje = resultado });
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensaje = ex.Message });
            }
        }

        // PUT api/<MarcaController>/5
        [HttpPut]
        public IActionResult ActualizarMarca([FromBody] Marca marca)
        {
            try
            {
                var resultado = mar_service.ActualizarMarca(marca);
                return Ok(new { mensaje = resultado });
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensaje = ex.Message });
            }
        }

        // DELETE api/<MarcaController>/5
        [HttpDelete("{idMarca}")]
        public IActionResult EliminarMarca(int idMarca)
        {
            try
            {
                var resultado = mar_service.EliminarMarca(idMarca);
                return Ok(new { mensaje = resultado });
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensaje = ex.Message });
            }
        }
    }
}
