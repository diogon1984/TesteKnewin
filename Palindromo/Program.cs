using System;
using System.Text.RegularExpressions;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Palindromo**");            
            Console.Write("Informe a palavra: ");
            var palavra = Console.ReadLine();
            var resultado = ValidaPalindromo(palavra) ? "É um palindromo!" : "Não é um palindromo!";
            Console.WriteLine(resultado);
        }

        private static bool ValidaPalindromo(string palavra)
        {
            var letras = RemoverAcentosECaractesEspeciais(palavra);

            if ((letras.Length % 2) == 0)
                return false;

            for (int i = 0; i < letras.Length / 2; i++)
            {
                var ultimaLetra = letras.Length - 1;

                if (letras[i] != letras[ultimaLetra - i])
                    return false;
            }

            return true;
        }

        private static string RemoverAcentosECaractesEspeciais(string texto)
        {
            string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            string semAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";

            for (int i = 0; i < comAcentos.Length; i++)
            {
                texto = texto.Replace(comAcentos[i].ToString(), semAcentos[i].ToString());
            }
            return Regex.Replace(texto, @"[^\w]", ""); ;
        }
    }
}
