using Microsoft.AspNetCore.Mvc;
using ProEventos.Data;
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
           
        };

        [HttpGet]
        public IEnumerable<Evento> GetAll()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(e => e.EventoId == id);
        }

        private readonly DataContext _context;

        public EventoController (DataContext context)
        {
            _context = context;
        }
    }
}
