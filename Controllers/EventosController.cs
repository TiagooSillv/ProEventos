using Microsoft.AspNetCore.Mvc;
using ProEventos.Application.Contratos;
using ProEventos.Domain;
using System.Diagnostics.CodeAnalysis;

public class EventosController : ControllerBase
{
    private readonly IEventoService _eventoService;

    public EventosController(IEventoService eventoService)
    {
        _eventoService = eventoService;
        
    }

    [HttpGet("/obterTodos")]
    public async Task<IActionResult> Get()
    {
        try
        {
            var eventos = await _eventoService.GetAllEventosAsync(true);
            if (eventos == null) return NotFound("Nenhum evento encontrado");

            return Ok(eventos);
        }
        catch (Exception ex)
        {

            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar recuperar eventos. Erro : {ex.Message}");
        }
    }

    [HttpGet("/api/eventos{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        try
        {
            var evento = await _eventoService.GetEventosByIdAsync(id);
            if (evento == null) return NotFound("Evento por id não encontrado");

            return Ok(evento);
        }
        catch (Exception ex)
        {

            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar recuperar eventos. Erro : {ex.Message}");
        }
    }
    [HttpGet("{tema}/tema")]
    public async Task<IActionResult> GetByTema(string tema)
    {
        try
        {
            var evento = await _eventoService.GetAllEventosByTemaAsync(tema, true);
            if (evento == null) return NotFound("Eventos por tema não encontrados");

            return Ok(evento);
        }
        catch (Exception ex)
        {

            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar recuperar eventos. Erro : {ex.Message}");
        }
    }
    [HttpPost("/api/eventos")]
    public async Task<IActionResult>Post(Evento model)
    {
        try
        {
            var evento = await _eventoService.AddEvento(model);
            if (evento == null) return BadRequest("Erro ao tentar adiconar evento.");

            return Ok(evento);
        }
        catch (Exception ex)
        {

            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar adicionar eventos. Erro : {ex.Message}");
        }
    }
    [HttpPut("atualizarEventos")]
    public async Task<IActionResult> Put(Evento model, int eventoId)
    {
        try
        {
            var evento = await _eventoService.UpdateEvento(eventoId, model);
            if (evento == null) return BadRequest("Erro ao tentar adiconar evento.");

            return Ok(evento);
        }
        catch (Exception ex)
        {

            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar atualizar eventos. Erro : {ex.Message}");
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete (int eventoId)
    {
        try
        {
            if (await _eventoService.DeleteEvento(eventoId))
            {
                return Ok("Deletado com sucesso");
            }
            else
                 return BadRequest("Não foi possivel deletar evento");
            
        }
        catch (Exception ex)
        {

            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Erro ao tentar deletar eventos. Erro : {ex.Message}");
        }
    }
}
