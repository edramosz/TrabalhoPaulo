using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._03_Entidades
{
 [Table("Transacoes")]
        public class Transacao
    {
        public int Id { get; set; }
        public int CompraId { get; set; }
        public DataType Data { get; set; }
        public int Parcelamento { get; set; }
        public string MetodoPagamento { get; set; }
    }
}
