namespace ProEventos.Models
{
    public class Evento
    {
        public int EventoId { get; set; }
        public string Local { get; set; }
        public DateTime DataEvento { get; set; }
        public string Tema { get; set; }
        public int Quantidade { get; set; }
        public string Lote { get; set; }
        public string ImageURL { get; set; }
    }
}
