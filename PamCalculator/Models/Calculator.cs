
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamCalculator.Models
{
    public class Calculator
    {
        public double PrimeiroTermo { get; set; }

        public double SegundoTermo { get; set; }

        public double Resultado { get; set; }

        public double Somar(double n1, double n2)
        {
            //Soma dois número
            PrimeiroTermo = n1;
            SegundoTermo = n2;
            Resultado = n1 + n2;
            return Resultado; 
        }

        public double Subtrair(double n1, double n2)
        {
            //Subtrai números
            PrimeiroTermo = n1;
            SegundoTermo = n2;
            Resultado = n1 - n2;
            return Resultado;
        }

        public double Multiplicar(double n1, double n2)
        {
            //Multiplica números
            PrimeiroTermo = n1;
            SegundoTermo = n2;
            Resultado = n1 * n2;
            return Resultado;
        }
        
        
        public double Dividir(double n1, double n2)
        {
            //Divide números
            PrimeiroTermo = n1;
            SegundoTermo = n2;
            Resultado = n1 /n2;
            return Resultado;

        }

        public double Elevar(double n1, double n2)
        {
            PrimeiroTermo = n1;
            SegundoTermo = n2;
            Resultado = Math.Pow(n1, n2);
            return Resultado;

      
        }

        public double Raiz(double n1, double n2)
        {
            PrimeiroTermo = n1;
            Resultado = Math.Pow(n1, (1 / n2));
            return Resultado;
        }
       

    }
}