using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_PC_1054723_Ciclo_2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1");

            Console.Write("Número ENTERO: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int numero))
            {
                if (numero > 0)
                {
                    Console.WriteLine("Resultado: El número es positivo.");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("Resultado: El número es negativo.");

                }
                else
                {
                    Console.WriteLine("Resultado: El número es cero.");

                }
            }
            else
            {
                Console.WriteLine("Error: El valor ingresado no es un número entero.");

            }

            Console.ReadKey();
            Console.Clear();



            Console.WriteLine("Ejercicio 2");
            Console.WriteLine("Ingrese un numero entre 1 y 7");
            int vNumero = Convert.ToInt32(Console.ReadLine());
            string dia = "";
            if (vNumero == 1)
            {
                dia = "Lunes";
            }
            else if (vNumero == 2)
            {
                dia = "Martes";
            }
            else if (vNumero == 3)
            {
                dia = "Miercoles";
            }
            else if (vNumero == 4)
            {
                dia = "Jueves";
            }
            else if (vNumero == 5)
            {
                dia = "Viernes";
            }
            else if (vNumero == 6)
            {
                dia = "Sabado";
            }
            else if (vNumero == 7)
            {
                dia = "Domingo";
            }
            else
            {
                Console.WriteLine("El numero ingresado no es valido");
            }
            Console.WriteLine("El numero " + vNumero + " corresponde al dia " + dia);
            Console.ReadKey(true);
        }
    }
}
