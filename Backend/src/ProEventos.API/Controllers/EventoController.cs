using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    public EventoController()
    {
        
    }

    public IEnumerable<Evento> _evento = new Evento[] {
            new () {
                EventoId = 1,
                Tema = "Angular 11 e .Net 6",
                Local = "Belo Horizonte",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemUrl = "foto.png"
            },
            new () {
                EventoId = 2,
                Tema = "Godot 4",
                Local = "Ipatinga",
                Lote = "3º Lote",
                QtdPessoas = 400,
                DataEvento = DateTime.Now.AddDays(7).ToString(),
                ImagemUrl = "foto_2.png"
            }
        };

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _evento;
    }

     [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
        return _evento.Where(evento => evento.EventoId == id);
    }

    [HttpPost]
    public string Post()
    {
        return "Exemplo de POST";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"Exemplo de PUT com id = {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"Exemplo de DELETE com id = {id}";
    }

}
