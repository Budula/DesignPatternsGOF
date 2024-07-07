using BridgePattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class CalculaSalario : Arquivo
    {
        public CalculaSalario(IGerarArquivo gerarArquivo) : base(gerarArquivo) 
        {            
        }
        public void ProcessaSalarioFuncionario(Funcionario funcionario)
        {
            funcionario.SalarioTotal = funcionario.SalarioBase + funcionario.Incentivo;

            Console.WriteLine($"Valor do salário para o funcionario {funcionario.Nome}\n : " +
                $"R$ {funcionario.SalarioTotal}");

            this.GravarArquivo(funcionario);

        }
    }
}
