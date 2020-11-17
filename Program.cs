using System;

namespace ProjetoCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Perguntar a operação
            Console.WriteLine("Qual a operacao deseja fazer? \n Soma, Subtração, Multiplicação, Divisão");

            string operacao = Console.ReadLine();


            //Pedir o primeiro número
            Console.WriteLine("Digite o primeiro número: ");
            float num1 = float.Parse(Console.ReadLine());

            //Pedir o segundo número
            Console.WriteLine("Digite o segundo número: ");
            float num2 = float.Parse(Console.ReadLine());

            // Fazer o cálculo
           float resultado =0;

            if(operacao == "Soma"){
                    resultado = num1 + num2;
            }
            else if(operacao == "Subtracao"){
                resultado = num1 - num2;
            }
            else if(operacao == "Multiplicacao"){
                resultado = num1 * num2;
            }
            else if(operacao == "Divisao"){
                resultado = num1 / num2;
            }
            else{
                Console.WriteLine("Operacao Inválida");
            }


            //Mostrar o resultado
            
            //Concatenacao
         
            //Interpolação
            Console.WriteLine($"Calculo ; {num1} com {num2} = {resultado}");




        }
    }
}
