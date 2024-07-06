using AdapterPattern.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class SistemaMensalidade
    {

        public void CalculaMensalidade(List<Aluno> alunos)
        {
            foreach (var aluno in alunos)
            {
                var mensalidade = aluno.Mensalidade * 1.1M;

                Console.WriteLine($"Aluno {aluno.Nome} " +
                                    $"- Valor da mensalidade R$ {mensalidade}.");
            }
        }
    }
}
