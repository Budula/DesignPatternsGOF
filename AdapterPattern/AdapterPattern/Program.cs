// See https://aka.ms/new-console-template for more information
using AdapterPattern;


var alunosArray = SistemaEscolar.GetListaAlunosMensalidades();
ICalculaMensalidade calculo = new AlunoAdapter();
calculo.ProcessaCalculoMensalidade(alunosArray);
Console.ReadLine();