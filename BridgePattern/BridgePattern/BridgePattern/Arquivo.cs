using BridgePattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public abstract class Arquivo
    {
        protected IGerarArquivo _gerarArquivo;
        protected Arquivo(IGerarArquivo gerarArquivo)
        {
            _gerarArquivo = gerarArquivo;
        }
        public virtual void GravarArquivo(Funcionario funcionario)
        {
           _gerarArquivo.GerarArquivo(funcionario);
        }
    }
}
