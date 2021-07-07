using System;
using System.Collections.Generic;
using System.Text;

namespace academia.Alunos
{
    class Alunos : Pessoas
    {
        public string turma { get; set; }
        public double mensalidade { get; set; }
        public bool paga = true;

        
    }
}
