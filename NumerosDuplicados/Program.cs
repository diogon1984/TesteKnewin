using System;
using System.Collections.Generic;
using System.Linq;

namespace NumerosDuplicados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Duplicados na lista**");
            var valores = ReceberLista();
            ExisteNumeroDuplicado(valores);
        }

        private static List<int> ReceberLista()
        {
            var valoresInvalidos = false;
            string[] valores;
            List<int> valoresInt;

            do
            {
                Console.Write("Informe uma lista de números inteiros separados por virgula: ");
                valores = Console.ReadLine().Split(",");
                valoresInt = new List<int>();

                foreach (var valor in valores)
                {
                    if(int.TryParse(valor, out int valorInt))
                    {
                        valoresInt.Add(valorInt);
                        valoresInvalidos = false;
                    }
                    else
                    {   
                        valoresInvalidos = true;
                        break;
                    }
                }
            } while (valoresInvalidos);

            return valoresInt;
        }

        private static void ExisteNumeroDuplicado(List<int> listaNumeros)
        {
            for(int i = 0; i < listaNumeros.Count(); i++)
            {
                for (int j = i+1; j < listaNumeros.Count(); j++)
                {
                    if(listaNumeros[i] == listaNumeros[j])
                    {
                        Console.WriteLine($"O número na posição {j} é duplicado");
                        return;
                    }   
                }
            }
            Console.WriteLine($"A lista não possui números duplicados");
        }
    }
}
