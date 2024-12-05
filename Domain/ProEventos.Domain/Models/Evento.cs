using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Security;

namespace ProEventos.Domain.Models
{
    //Serve para poder eu não mudar o nome da minha classe e usar o nome que tiver no banco de dados 
    //[Table("EventosDetalhes")]
    public class Evento
    {
        //[Key] 
        public int Id { get; set; }
        public string Tema { get; set; }
        public string Local { get; set; }
        public DateTime? DataEvento { get; set; }
        public int QtdPessoas { get; set; }
        public string ImagemURL { get; set; }
        [Required]
        public string Telefone { get; set; }
        public string Email { get; set; }
        public IEnumerable<Lote> Lotes { get; set; }
        public IEnumerable<RedeSocial> RedeSociais { get; set; }
        public IEnumerable<PalestranteEvento> PalestranteEventos { get; set; }
    }
}
