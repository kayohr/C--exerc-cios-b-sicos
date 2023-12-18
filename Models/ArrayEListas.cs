using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploProjeto.Models
{
    public class ArrayEListas
    {
        public void arrayDeInterios(){
        int[] arrayInteiros = new int[3];
        arrayInteiros[0] = 72;
        arrayInteiros[1] = 64;
        arrayInteiros[2] = 50;

        for (int contador = 0; contador < arrayInteiros.Length; contador++)
        {
            Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
        }
        }

        public void arrayDeInteriosForEach(){
        Console.WriteLine("Sem contador");
        int[] arrayInteiros = new int[3];
        arrayInteiros[0] = 72;
        arrayInteiros[1] = 64;
        arrayInteiros[2] = 50;

        foreach(int valor in arrayInteiros)
        {
            Console.WriteLine(valor);
        }

        Console.WriteLine("Com contador");
        int contadorForeach = 0;
          foreach(int valor in arrayInteiros)
        {
            Console.WriteLine($"Posição Nº {contadorForeach} - {valor}");
        }
        }

             public void arrayDeInteriosCopy(){
         Console.WriteLine("Sem contador");
        int[] arrayInteiros = new int[3];
        arrayInteiros[0] = 72;
        arrayInteiros[1] = 64;
        arrayInteiros[2] = 50;

        //Jeito de pegar valores diferentes.
        // int[] arrayInteirosDobrado = new int[2];
        // Array.Copy(arrayInteiros, arrayInteirosDobrado, 2);
        int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
        Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

        foreach (var elemento in arrayInteirosDobrado)
        {
            Console.WriteLine(elemento);
        }
        
        }

        public void listArray(){
        List<string> listaString = new List<string>();

        listaString.Add("SP");
        listaString.Add("BA");
        listaString.Add("MG");

        for(int i = 0; i < listaString.Count; i++)
        {
            Console.WriteLine($"Posição Nº {i} - {listaString[i]}");
        }
        
        }
    }
}