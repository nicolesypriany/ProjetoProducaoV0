﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producao.Models
{
    internal class Maquina
    {
        public Maquina(string nome, string marca)
        {
            this.Nome = nome;
            this.Marca = marca;
        }

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Marca { get; set; }
    }
}
