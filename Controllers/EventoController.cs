using Microsoft.AspNetCore.Mvc;
using ProEventos;
using ProEventos.Domain;
using ProEventos;
using System.Collections.Generic;
using ProEventos.Persistence.Contexto;

namespace ProEventos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly IEnumerable<Evento> _evento = new List<Evento>
        {

        };

        [HttpGet]
        public IEnumerable<Evento> GetAll()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(e => e.Id == id);
        }

        private readonly ProEventosContext _context;

        public EventoController(ProEventosContext context)
        {
            _context = context;
        }
    }
}
