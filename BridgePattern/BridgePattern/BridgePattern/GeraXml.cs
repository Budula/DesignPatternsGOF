using BridgePattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class GeraXml : IGerarArquivo
    {
        public void GerarArquivo(Funcionario funcionario)
        {
            Console.WriteLine($"Dados do funcionario {funcionario.Nome} Gerado no formato Xml");
        }
    }
}
