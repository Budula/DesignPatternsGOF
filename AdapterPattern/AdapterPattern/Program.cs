// See https://aka.ms/new-console-template for more information
using AdapterPattern;


var alunosArray = SistemaEscolar.GetListaAlunosMensalidades();
//SistemaMensalidade calculo = new SistemaMensalidade();
ICalculaMensalidade calculo = new AlunoAdapter();
calculo.ProcessaCalculoMensalidade(alunosArray);
Console.ReadLine();