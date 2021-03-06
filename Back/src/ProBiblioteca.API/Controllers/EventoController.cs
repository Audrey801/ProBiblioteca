using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProBiblioteca.API.Models;

namespace ProBiblioteca.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
    public IEnumerable<Evento>_evento = new Evento[]{
        new Evento(){
            EventoId = 1,
            Tema ="Angular 11 e .Net 5",
            Local = "Iputinga-Recife",
            Lote = "1° Lote",
            Qtdpessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString(),
            ImagemUrl = "foto.png"},

        new Evento(){
            EventoId = 2,
            Tema ="Angular e Suas Novidades",
            Local = "Madalena-Recife",
            Lote = "2° Lote",
            Qtdpessoas = 350,
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            ImagemUrl = "foto1.png"}


            };
        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
              
        }
         [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId ==id);
              
        }
        
        [HttpPost]
        public string Post()
        {
            return "exemplo de Post";
        }
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "exemplo de DElete";
        }
    }
}
