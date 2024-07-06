using AdapterPattern.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class AlunoAdapter : ICalculaMensalidade
    {
        public SistemaMensalidade sistemaMensalidade = new SistemaMensalidade();
        public void ProcessaCalculoMensalidade(string[,] alunosArray)
        {
            
            List<Aluno> listaAlunos = new List<Aluno>();

            ConverteArrayParaList(alunosArray, listaAlunos);
            sistemaMensalidade.CalculaMensalidade(listaAlunos);
        }

        private void ConverteArrayParaList(string[,] alunosArray, List<Aluno> listaAlunos)
        {
            string id = null;
            string nome = null;
            string mensalidade = null;
            for (int i = 0; i < alunosArray.GetLength(0); i++)
            {
                for (int j = 0; j < alunosArray.GetLength(1); j++)
                {
                    if (j==0)
                    {
                        id = alunosArray[i,j];
                    }
                    else if (j==1)
                    {
                        nome = alunosArray[i, j];
                    }
                    else
                    {
                        mensalidade = alunosArray[i, j];
                    }
                }
                listaAlunos.Add(new Aluno(Convert.ToInt32(id),nome,Convert.ToDecimal(mensalidade)));
            }
        }
    }
}
