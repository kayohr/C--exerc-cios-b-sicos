using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploProjeto.Models
{
    public class EstruturaDeREpeticao
    {
        public void LoopFor(int x){
            for(int cont = 0; cont <= 10; cont++){
                Console.WriteLine($"{x} x {cont} = {x * cont}");
            }
        }

        public void LoopWhile(){
            int numero = 5;
            int contador = 0;

            while(contador <=10){
                Console.WriteLine($"{contador}º Execução: {numero} * {contador} = {numero * contador}");
                contador++;

                // if (contador == 6){
                //     break; //Vai mostrar só 5 execuções, na sexta ele para.
                // }
            }
        }

         public void LoopWhile2(int numero, int contador ){

            while(contador <=10){
                Console.WriteLine($"{contador}º Execução: {numero} * {contador} = {numero * contador}");
                contador++;
            }
        }

         public void LoopDoWhile(){
            int soma = 0, numero = 0;

            do{
                Console.WriteLine("Digite um numero (0 para parar)");
                numero = Convert.ToInt32(Console.ReadLine());

                soma += numero;

            } while (numero != 0);
            
             Console.WriteLine($"Total da soma dos números digitados é: {soma}");
        }

           public void LoopDoWhile2(int soma, int numero){
            
            do{
                Console.WriteLine("Digite um numero (0 para parar)");
                numero = Convert.ToInt32(Console.ReadLine());

                soma += numero;

            } while (numero != 0);
            
             Console.WriteLine($"Total da soma dos números digitados é: {soma}");
        }
    }
}