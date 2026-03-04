// See https://aka.ms/new-console-template for more information


using Conceitos;

Console.WriteLine("Bem vindo ao seu perfil no Nubank!");


Cliente cliente;
cliente = new Cliente();

cliente.Nome = "Iguin bariloche";
Console.WriteLine($"Nome do cliente : {cliente.Nome}");

cliente.Cpf = "21682195759";
Console.WriteLine($"Seu cpf é : {cliente.Cpf}");

Console.WriteLine("DDLFLFLLS");

Agencia agencia = new Agencia();

agencia.Numero = "3010";
Console.WriteLine($"Sua agencia é : {agencia.Numero}");

agencia.Nome = "Conta Corrente";
Console.WriteLine($"Sua conta é do tipo : {agencia.Nome}");

agencia.Telefone = "24992778679";
Console.WriteLine($"Seu numero de telefone é : {agencia.Telefone}");

Console.WriteLine("Obrigado pela consulta!");


