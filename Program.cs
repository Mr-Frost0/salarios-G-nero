using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salariosGenero
{
    class Program
    {
        static void Main(string[] args)
        {

            //Realizar un programa llamado “salariosGenero” con interfaz para consola en C# .NET que permita registrar 10 empleados de una empresa, 
            //número de folio, sueldo, sexo (1=femenino y 2=masculino). Imprimir en pantalla la información correspondiente a cuantas mujeres ganan más de $900.000 pesos 
            //y cuantos hombres ganan menos de $1.000.000.


            //Definimos, creamos e inicializamos los vectores que captarán los datos de entrada
            string[] nombreEmpleado = new string[10];
            string[] folio = new string[10];
            double[] sueldo = new double[10];
            string[] sexo = new string[10];

            //Ciclo iterativo que capta los datos de los 10 empleados
            for (int i = 0; i < 10; i++)
            {

                //Pedimos los datos de entrada de las 10 personas
                Console.Write("\nPor favor ingrese el nombre del empleado número [{0}] -> ", i + 1);
                nombreEmpleado[i] = Console.ReadLine();
                Console.Write("\nIngrese el número de folio -> ");
                folio[i] = Console.ReadLine();
                Console.Write("\nCuál es el sueldo de [{0}]? -> ", nombreEmpleado[i]);
                sueldo[i] = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nCuál es su sexo? (Ingrese 1 para femenino y 2 para masculino)-> ");
                sexo[i] = Console.ReadLine();


            }

            //Ciclo iterativo que imprime por consola los datos que cumplan las condiciones
            for (int i = 0; i < 10; i++)
            {

                //Condicionales que imprimen los datos de salida dependiendo del caso
                if (sueldo[i] > 900000 & sexo[i] == "1")
                {
                    Console.WriteLine("\nLa empleada [{0}] gana más de $900.000 ", nombreEmpleado[i]);
                    Console.WriteLine("\nDatos básicos:", nombreEmpleado[i]);
                    Console.WriteLine("Número de folio - [{0}]", folio[i]);
                    Console.WriteLine("Sueldo - [{0}]", sueldo[i]);

                }
                if (sueldo[i] < 1000000 & sexo[i] == "2")
                {
                    Console.WriteLine("\nEl empleado [{0}] gana menos de $1.000.000", nombreEmpleado[i]);
                    Console.WriteLine("\nDatos básicos:");
                    Console.WriteLine("Número de folio - [{0}]", folio[i]);
                    Console.WriteLine("Sueldo - [{0}]", sueldo[i]);
                }

            }
            Console.ReadKey();

        }
    }
}
