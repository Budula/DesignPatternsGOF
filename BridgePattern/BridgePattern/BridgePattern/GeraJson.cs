using BridgePattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class GeraJson : IGerarArquivo
    {
        public void GerarArquivo(Funcionario funcionario)
        {
            //Logica para gerar os dados no formato Json.
            Console.WriteLine($"Dados do funcionario {funcionario.Nome} Gerado no formato Json");
        }
    }
}
