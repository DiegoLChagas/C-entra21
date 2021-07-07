using System;
using System.Collections.Generic;
using System.Text;

namespace academia.Alunos
{
    class Academia
    {
        public List<Alunos> aluno { get; private set; }

        public Academia()
        {
            aluno = new List<Alunos>;
        }
        public void AdicionaAluno(Alunos alunos)
        {
            aluno.Add(alunos);
        }
        public void AdicionaAluno(string nome, string cpf, string rg)
        {
            aluno.Add(new Alunos(nome, cpf, rg));
        }
    }
}
