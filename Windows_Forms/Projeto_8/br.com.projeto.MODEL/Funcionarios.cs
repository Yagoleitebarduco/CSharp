﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_8.br.com.projeto.MODEL
{
    internal class Funcionarios : Clientes
    {
        public string Senha {  get; set; }
        public string cargo { get; set; }
        public string nivel_Acesso { get; set; }
    }
}
