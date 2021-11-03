using System;

namespace PesoIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
            double _pesoIdeal = default;
            string _sexo = default;
            Console.WriteLine("---- Peso Ideal ----");

            Console.Write("Digite sua altura em metros.....: ");
            double.TryParse(Console
            .ReadLine()
            .ToString(), out double _altura);

            Console.Write("Sexo [M]asculino / [F]eminino...: ");            
            _sexo = Console.ReadLine();

            if(_sexo == "m" || _sexo == "M"){
                _pesoIdeal = (_altura * 72.7) - 58;
                Console.WriteLine($"\nSeu peso ideal é {Math.Round(_pesoIdeal,2)}kg.");
            }
            else if(_sexo == "f" || _sexo == "F"){
                _pesoIdeal = (_altura * 62.1) - 44.7;
                Console.WriteLine($"\nSeu peso ideal é {Math.Round(_pesoIdeal,2)}kg.");
            }
            else{
                Console.WriteLine("\nVocê digitou um parâmetro inválido.");
            }
        }
    }
}
