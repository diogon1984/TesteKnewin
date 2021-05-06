using CadastroCidade.Dominio.Entidades;
using CadastroCidade.Repositorio.Repositorio;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CadastroCidadeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CidadeController : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet("ObterTodos")]
        public IEnumerable<Cidade> ObterTodos()
        {
            var cidadeRepositorio = new CidadeRepositorio();
            return cidadeRepositorio.ObterTodos();
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("pesquisacidade/{id:long}")]
        public Cidade PesquisaPorId(int Id)
        {
            var cidadeRepositorio = new CidadeRepositorio();
            return cidadeRepositorio.ObterPorId(Id);
        }

        [Authorize]
        [Route("pesquisarfronteira/{id:long}")]
        public IEnumerable<Cidade> ObterFronteiras(int id)
        {
            var cidadeRepositorio = new CidadeRepositorio();
            return cidadeRepositorio.ObterFronteiras(id);
        }

        [Authorize]
        [HttpGet]
        [Route("quantidadehabitantes/{ids}")]
        public decimal ObterSomaHabitantes(string ids)
        {
            var ListIds = ids.Split(',').Select(Int32.Parse).ToList();
            var cidadeRepositorio = new CidadeRepositorio();
            return cidadeRepositorio.ObterSomaHabitantes(ListIds);
        }

        [Authorize]
        [HttpGet("ObterRota")]
        public IEnumerable<Cidade> ObterRota([FromQuery] int origemId, [FromQuery] int destinoId)
        {
            var cidadeRepositorio = new CidadeRepositorio();
            return cidadeRepositorio.ObterRota(origemId, destinoId);
        }

        [Authorize]
        [HttpPut]
        public IActionResult AlterarCidade([FromBody] Cidade cidade)
        {
            var cidadeRepositorio = new CidadeRepositorio();
            cidadeRepositorio.AlterarCidade(cidade);
            return Ok(cidade.Id);
        }
    }
}
