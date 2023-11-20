using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizUno = { { 17, 9, 36 }, 
                                 { 8, 7, 3 }, 
                                 { 15, 28, 87 } 
                                };

            int suma = 0;
            int CantElemento = 0;

            foreach (var elemto in matrizUno)
            {
                suma += elemto;
                CantElemento++;
            }

            /*sacar promedio de la matrizuno*/
            double promedio = (double)suma / CantElemento;

            string noAplican = "";
            string aplican = "";

            foreach (var elemento in matrizUno)
            {
                if (elemento <= 0.6 * promedio)
                {
                    noAplican += $"{elemento}, ";
                }
                else
                {
                    aplican += $"{elemento}, ";
                }
            }


            Console.WriteLine($"La suma es: {suma}");
            Console.WriteLine($"Promedio: {promedio}");
            Console.WriteLine($"No aplican para sumar: {noAplican.TrimEnd(',', ' ')}");
            Console.WriteLine($"Sí aplican para sumar: {aplican.TrimEnd(',', ' ')}");


            Console.ReadLine();
        }

    }
}
