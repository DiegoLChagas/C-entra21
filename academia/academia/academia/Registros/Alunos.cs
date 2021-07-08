using System;
using System.Collections.Generic;
using System.Text;

namespace academia.Alunos
{
    class Aluno : Pessoa
    {
        public string turma { get; set; }
        public double mensalidade { get; set; }
        public bool paga { get; set; }

        public override string ToString()
        {
            return Nome;
        }

     


    }
}
