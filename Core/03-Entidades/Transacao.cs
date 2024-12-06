using System.ComponentModel.DataAnnotations;

namespace Core._03_Entidades
{
        public class Transacao
    {
        public int Id { get; set; }
        public int CompraId { get; set; }
        public DataType Data { get; set; }
        public int Parcelamento { get; set; }
        public string MetodoPagamento { get; set; }
    }
}
