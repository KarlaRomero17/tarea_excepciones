using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                        string cadena;
                        var num=0;
                        var cubo=0;
                        try
                        {
                            Console.Write("Ingrese un valor:");
                            cadena = Console.ReadLine();
                            num = int.Parse(cadena);
                            cubo = num * num * num;
                            Console.WriteLine($"El cubo de {num} es {cubo}");
                        }
                        catch (Exception e) {
                            Console.WriteLine( e.Message);
                        }*/
            /*var  res="";
            var edad=0;
            bool continuar;
            do
            {
                Console.Write("\nIngresa tu edad: ");
                res = Console.ReadLine();
                try
                {
                    edad = int.Parse(res);
                    continuar=false;
                    if (edad<18)
                    {
                        Console.WriteLine("Lo sentimos, no cumples con el requisito");
                        continuar=true;
                    }
                    else
                    {
                        Console.WriteLine("Bienvenido");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Acceso denegado - Debes ser mayor. " + e.Message);
                    continuar=true;
                }
            } while(continuar== true);
            */


                double num1;
            double num2;
            double division;
            Console.Write("Ingrese su numero 1: ");
                num1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese su numero 2: ");
            num2 = double.Parse(Console.ReadLine());


            try
            {
                division = (num1 / num2);
                Console.WriteLine("El resultado de la division es: " + division);
            }
            // Least specific:
            catch (Exception e)
            {
                Console.WriteLine("{0} Second exception caught."+ e.Message);
            }




            Console.ReadKey();

        }
    }
}
