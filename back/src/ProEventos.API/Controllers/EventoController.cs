using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventotController : ControllerBase
    {
       
        public IEnumerable<Evento> _evento = new Evento[]{
            new Evento{
                 EventoId = 1,
                Local = "Brasili",
                Tema = "Angular 11 e dotnet 5",
                Lote = "1º Lote",
                QtdPessoa = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                imagem = "foto1.png"
            },
            new Evento{
                 EventoId = 2,
                Local = "Sao Paulo",
                Tema = "Js React Viw",
                Lote = "3º Lote",
                QtdPessoa = 400,
                DataEvento = DateTime.Now.AddDays(4).ToString(),
                imagem = "foto4.png"
            }
        };

        public EventotController()
        {           
        }

        [HttpGet]
        public IEnumerable <Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int id){
            return _evento.Where(evento => evento.EventoId == id);
        }
    }
}
