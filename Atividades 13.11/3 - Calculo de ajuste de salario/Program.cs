using System;

namespace _3___Calculo_de_ajuste_de_salario
{
    class Program
    {
        static void Main(string[] args)
        { 

            Console.WriteLine("Digite seu salario");
            int salario = int.Parse(Console.ReadLine());
             if(salario<500) {
                 double ajuste = salario*1.30;
                 Console.WriteLine("Você recebeu ajuste de 30% no seu salario e o valor a sacar é de:"+ajuste);
             } else {
                 Console.WriteLine("Você não tem direito ao ajuste salarial");
             }
        }
    }
}
