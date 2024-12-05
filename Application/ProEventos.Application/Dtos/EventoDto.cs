using ProEventos.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace ProEventos.Application.Dtos
{
    public class EventoDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O Campo tema é obrigatorio"),
         StringLength(30, MinimumLength = 3,
                          ErrorMessage = "Quantidade de caracteres invalido"),]
        public string Tema { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }
        [Display(Name = "Quantidade de Pessoas")]
        [Range(1, 9999, ErrorMessage = "{0} deve corresponder esse intervalo")]
        public int QtdPessoas { get; set; }

        [RegularExpression(@".*\.(gif|jpe?g|bmp|png)$",
                           ErrorMessage ="Não e um formato de imagem válida")]
        public string ImagemURL { get; set; }
        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "O campo {0} obrigatorio ")]
        [Phone(ErrorMessage = "O campo {0} está com número inválido")]
        public string Telefone { get; set; }
        [Display(Name = "e-mail")]
        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        [EmailAddress(ErrorMessage ="O {0} está inválido")]
        public string Email { get; set; }

        public IEnumerable<LoteDto> Lotes { get; set; }
        public IEnumerable<RedeSocialDto> RedeSocial { get; set; }
        public IEnumerable<PalestranteDto> PalestrantesEventos { get; set; }

    }
}
