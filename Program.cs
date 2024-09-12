using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
namespace JogoAdivinhação2
{
    internal class Program
    {
        
        static void Main(string[] args) // parâmetro - recebe argumentos em forma de texto 
        {
            int continuar = 1, password = 0, attempt = 0, number = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Sorteando números entre 1 e 10");
                password = sorteio(password);

                Console.WriteLine("Começou! Tente adivinhar o número:");
                attempt = 0;


                do
                {
                    attempt++;
                    Console.WriteLine("Tentativa n° " + attempt);
                    Console.WriteLine("Digite um número: "); 
                    number = int.Parse(Console.ReadLine());
                    dicas(number, password, attempt);
                }while(number!=password);

                Console.WriteLine("Digite 0 para sair ou qualquer outro número para continuar");
                continuar = int.Parse(Console.ReadLine());
            }while(continuar!=0);

            int sorteio(int password) // se o metodo tem um tipo ele retorna (recebe oq voltar do sorteio, passando um parâmetro)
            { 
                Random n = new Random();  
                password = Convert.ToInt32(n.Next(1, 10));
                return password;
            }

            void dicas(int number, int password, int attempt) // void n retrona nada no método (o metodo faz alguma mas n retorna nada - void = sem retorno)
            {
                if (number > password)
                    Console.WriteLine("O número soteada é menor que " + number);
                else
                    if (number < password)
                    Console.WriteLine("O número soteada é maior que " + number);
                else
                    Console.WriteLine("Parabéns você acertou o número em " + attempt + "tentativas");
            }
        }
        
    }
}
