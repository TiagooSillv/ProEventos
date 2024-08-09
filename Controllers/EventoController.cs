using Microsoft.AspNetCore.Mvc;
using ProEventos.Models;
using System.Collections.Generic;

namespace ProEventos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly IEnumerable<Evento> _evento = new List<Evento>
        {
            new Evento
            {
                EventoId = 1,
                Tema = "Angular e .Net",
                Local = "Es",
                Lote = "1 lote",
                Quantidade = 10,
                DataEvento = DateTime.Now.AddDays(2),
                ImageURL = "Foto.png"
            },
            new Evento
            {
                EventoId = 2,
                Tema = "React e Node.js",
                Local = "RJ",
                Lote = "2 lote",
                Quantidade = 20,
                DataEvento = DateTime.Now.AddDays(5),
                ImageURL = "Foto2.png"
            }
        };

        [HttpGet]
        public IEnumerable<Evento> GetAll()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _evento.FirstOrDefault(e => e.EventoId == id);
        }
    }
}
