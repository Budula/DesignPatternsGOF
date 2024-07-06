using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExercise
{
    public class MeuGeradorGrafico
    {
        public string Titulo { get; set; }
        public List<string> XValores { get; set; }
        public List<int> YValores { get; set; }

        public void GerarGrafico()
        {
            Console.WriteLine($"\n << Meu Gerador Grafico : Gerando Grafico >>");
        }
    }
}
