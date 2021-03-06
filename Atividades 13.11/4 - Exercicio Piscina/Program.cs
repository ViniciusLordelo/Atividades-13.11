using System;

namespace _4___Exercicio_Piscina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade Vinicius!");
            int idade = int.Parse(Console.ReadLine());

            if(idade>=5 && idade <=7) {
                Console.WriteLine(" Você vai para piscina Infantil A");
            } else {
                if(idade >=8 && idade <=11) {
                    Console.WriteLine("Você vai para piscina Infantil B");
                } else {
                    if(idade >=11 && idade <= 14) {
                        Console.WriteLine("Você vai para piscina Juvenil");
                    } else {
                        if (idade >=14 && idade <= 17) {
                            Console.WriteLine("Você vai para Piscina Juvenil B");
                        } 
                        Console.WriteLine("Você vai subir na categoria de Adultos");
                    }

                }
            }
            }
        }
    }
