using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentosDotNet.Models
{
    public class Calculadora
    {
        public void Somar (int x, int y)
        {
            Console.WriteLine ($"{x} + {y} = {x + y}");
        }

        public void Subtrair (int x, int y)
        {
            Console.WriteLine ($"{x} - {y} = {x - y}");
        }

        public void Multiplicar (int x, int y)
        {
            Console.WriteLine ($"{x} x {y} = {x * y}");
        }

        public void Dividir (int x, int y)
        {
            Console.WriteLine ($"{x} / {y} = {x / y}");
        }

        public void Potencia (int x, int y)
        {
            double potencia = Math.Pow(x, y); //A classe math contém as operações mais complexas; Pow = potência.
            Console.WriteLine ($"{x} ^ {y} = {potencia}");
        }

        //cálculos trigonométricos
        public void Seno (double angulo)
        {
            double radiano = angulo * Math.PI / 180; //A Math.Sin solicita que o ângulo seja em radianos e, para isso, multiplicamos o ângulo pelo valor de PI (Math.PI) dividido por 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine ($"Seno de {angulo} = {Math.Round(seno, 4)}"); //Esse método arredonda os valores e, após a vígula, você pode escolher quantas casas decimais deseja em seu resultado
        }

        public void Cosseno (double angulo)
        {
            double radiano = angulo * Math.PI / 180; //A Math.Cos solicita que o ângulo seja em radianos e, para isso, multiplicamos o ângulo pelo valor de PI (Math.PI) dividido por 180;
            double cosseno = Math.Cos(radiano);
            Console.WriteLine ($"Cosseno de {angulo} = {Math.Round(cosseno, 4)}"); //Esse método arredonda os valores e, após a vígula, você pode escolher quantas casas decimais deseja em seu resultado
        }

        public void Tangente (double angulo)
        {
            double radiano = angulo * Math.PI / 180; //A Math.Tan solicita que o ângulo seja em radianos e, para isso, multiplicamos o ângulo pelo valor de PI (Math.PI) dividido por 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine ($"Tangente de {angulo} = {Math.Round(tangente, 4)}"); //Esse método arredonda os valores e, após a vígula, você pode escolher quantas casas decimais deseja em seu resultado
        }

        public void RaizQuadrada (double x)
        {
            double raiz = Math.Sqrt(x); //Sqrt significa raiz quadrada
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }
    }
}