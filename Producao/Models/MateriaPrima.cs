using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producao.Models
{
    internal class MateriaPrima
    {
        public MateriaPrima(string Nome)
        {
            this.Nome = Nome;
        }

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Fornecedor { get; set;}
        public string? Unidade { get; set; }
        public double Preco {  get; set; }
    }
}
