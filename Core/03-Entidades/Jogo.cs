using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._03_Entidades
{
    public class Jogo
    {
        public int Id { get; set; }
        public int Tipo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }
        public string Genero { get; set; }
        public int Estoque { get; set; }
    }
}
