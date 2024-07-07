using AdapterExercise;

//var geradorGrafico = new MeuGeradorGrafico();
IGrafico geradorGrafico = new GraficoAdapter();

geradorGrafico.Titulo = "Gerador de Grafico";

geradorGrafico.XValores = new List<string>();
geradorGrafico.XValores.Add("Seg");
geradorGrafico.XValores.Add("Ter");

geradorGrafico.YValores = new List<int>();
geradorGrafico.YValores.Add(10);
geradorGrafico.YValores.Add(20);

geradorGrafico.GerarGrafico();

Console.ReadLine();