// See https://aka.ms/new-console-template for more information


using Conceitos;

Console.WriteLine("Bem vindo ao seu perfil no Nubank!");


Console.WriteLine("Informe o nome do cliente");
string nome = Console.ReadLine();


Console.WriteLine("Informe o cpf do cliente");
string cpf = Console.ReadLine();


Cliente cliente = new Cliente(nome,cpf);


Console.WriteLine($"Olá {cliente.Nome} !");
Console.WriteLine($"Seu cpf é : {cliente.Cpf} !");




Agencia agencia = new Agencia(2087); // Metodo construtor pois tem o mesmo nome da classe


Console.WriteLine($"Sua agencia é : {agencia.Numero}");

agencia.Nome = "Conta Corrente";
Console.WriteLine($"Sua conta é do tipo : {agencia.Nome}");

agencia.Telefone = "24992778679";
Console.WriteLine($"Seu numero de telefone é : {agencia.Telefone}");


Console.WriteLine("Informe o numero da conta");
long numero = Convert.ToInt64(Console.ReadLine());
Console.WriteLine($"Informe o saldo inicial da conta{numero}:");
decimal saldoInicial = decimal.Parse(Console.ReadLine());

Conta conta = new Conta(numero, saldoInicial);
Console.WriteLine($"Conta {conta.Numero} possui saldo R${conta.Saldo}.");


conta.Deposito(1000);
Console.WriteLine($"Após depósito, conta {conta.Numero} possui saldo R${conta.Saldo}.");

conta.Saque(500);
Console.WriteLine($"Após saque, conta {conta.Numero} possui saldo R${conta.Saldo}.");

