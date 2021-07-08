using System;
using System.Collections.Generic;
using System.Text;

namespace academia.Alunos
{
    class Academia
    {
        public List<Aluno> Alunos { get; private set; }

        public Academia()
        {
            Alunos = new List<Aluno>();
        }
      
        public void AdicionaAluno(string nome)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = nome;
           Alunos.Add(aluno);
        }
    }
}
