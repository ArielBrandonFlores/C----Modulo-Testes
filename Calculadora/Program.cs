// See https://aka.ms/new-console-template for more information
using Calculadora.Services;

CalculadoraImplementação calculadora = new CalculadoraImplementação();
int num1 = 10;
int num2 = 20;
Console.WriteLine($"{num1} + {num2} = {calculadora.Somar(num1, num2)}");

