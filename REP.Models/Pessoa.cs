﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REP.Models
{
      public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa() { }//desserializar

        public Pessoa(string _nome, int _idade)
        {
            Nome = _nome;
            Idade = _idade;
        }
    }
}
