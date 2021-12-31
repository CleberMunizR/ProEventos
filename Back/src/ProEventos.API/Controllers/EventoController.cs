using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento= new Evento[]{
                new Evento(){
                        EventoID = 1,
                        Tema = "Angular 11 e .NET 5",
                        Local = "Belo Horizonte",
                        Lote = "1º Lote",
                        QtdPessoas = 250,
                        DataEvento = DateTime.Now.AddDays(2).ToString()
                },
                new Evento(){
                        EventoID = 2,
                        Tema = "Angular 11 e .NET 5 e suas novidades",
                        Local = "São Paulo",
                        Lote = "2º Lote",
                        QtdPessoas = 350,
                        DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")
                }
        };

        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
                return  _evento;
        }
        
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
                return  _evento.Where(Evento => Evento.EventoID == id);
        }

        [HttpPost]
        public string Post()
        {
                return "Exemplo de post";
        }

         [HttpPut("{id}")]
        public string Put(int id)
        {
                return $"Exemplo de put com id = {id}";
        }
    }
}
