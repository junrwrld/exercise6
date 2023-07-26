using System;
using System.Drawing;
using System.Globalization;

namespace exercise5
{
    public class _exercise5
    {
        static void Main(string[] args)
        {
            //Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
            //hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas
            //decimais

            Console.WriteLine("Digite seu número de funcionário:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantas horas você trabalhou");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor que você recebe por horas trabalhas: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double calculoFinal = hours * salario;


            Console.WriteLine("O seu número de funcionário é: " + number);
            Console.WriteLine("Você tem " + hours + " horas trabalhadas");
            Console.WriteLine("Seu salário será correspondente a: U$ " + calculoFinal.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}