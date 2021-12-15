using Appache.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appache.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        {
            
        }

        public IEnumerable<Evento> _evento = new Evento[]
        {
            new Evento()
            {
                EventoId = 1,
                Tema = "Angular e .NET 5",
                Local = "Rio de Janeiro",
                Lote = "2° Lote",
                QtdPessoas = 200,
                DataEvento = DateTime.Now.AddDays(4).ToString(),
                ImagemURL = "fotoger.png"
            },
            new Evento()
            {
                EventoId = 2,
                Tema = "Angular 11 e .NET 5",
                Local = "Belo Horizonte",
                Lote = "1° Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "foto.png"
            }
        };

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpPost]
        public String Post()
        {
            return "Exemplo de Post";
        }
    }
}
