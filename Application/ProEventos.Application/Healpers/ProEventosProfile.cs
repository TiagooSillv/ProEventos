using AutoMapper;
using ProEventos.Application.Dtos;
using ProEventos.Domain.Models;

namespace ProEventos.Application.Healpers
{
    public class ProEventosProfile : Profile
    {
        public ProEventosProfile()
        {
            CreateMap<Evento, EventoDto>().ReverseMap();
        }
    }
}
