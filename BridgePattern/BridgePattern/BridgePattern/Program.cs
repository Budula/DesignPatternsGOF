// See https://aka.ms/new-console-template for more information
using BridgePattern;
using BridgePattern.Model;

Console.WriteLine("Hello, World!");

Funcionario funcionario1 = new Funcionario
{
    Id = 101,
    Nome = "William",
    SalarioBase = 3000,
    Incentivo = 900
};

CalculaSalario calculaSalario = new CalculaSalario(new GeraXml());
calculaSalario.ProcessaSalarioFuncionario(funcionario1);

funcionario1.Incentivo = 1200;

calculaSalario = new CalculaSalario(new GeraJson());
calculaSalario.ProcessaSalarioFuncionario(funcionario1);

Console.ReadLine();