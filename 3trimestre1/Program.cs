using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _3trimestre1
{
    class Program
    {
        static void Main(string[] args)
        {

            //  1...Leer un número por teclado y definir si es par o impar


            /*int num = 0;
            Console.WriteLine("Escribe un numero");
            num = int.Parse(Console.ReadLine());

            //  2... Ahora aplicaremos la estructura que define si el numero es par o impar

            if (num % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }

            Console.ReadKey();*/


            // 3....Leer un número por teclado y generar las Tabla de multiplicar de ese número del 1 al 10


            /*int n, i;
            Console.WriteLine("Didite el valor de la tabla:");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= 10; i++) 
            {
                Console.WriteLine(" {0} x {1} = {2}", n, i, (n * i));
            }

            Console.ReadKey();*/



            //  4...Generar las tablas de multiplicar del 2 al 9, cada una del 1 al 10


            /*int i;
            int j;
            int resultado;

            

            for (i = 2; i <= 9; i = i + 1)
            {
                Console.WriteLine("");
                Console.WriteLine("Tabla numero: " + i);
                Console.WriteLine("");

                for(j = 1; j <= 10; j++)
                {
                    resultado = i * j;
                    Console.WriteLine( i + " x " + j + " = " + resultado);
                }
            }

            Console.ReadKey();*/


            // 5....Leer un número por teclado y definir si es primo o no

            /*int num = 0;
            int cal = 0;
            Console.WriteLine("Ingrese un numero a definir: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < (num + 1); i++)
            {
                if (num % i == 0)
                {
                    cal++;
                }
            }
            if (cal!= 2)
            {
                Console.WriteLine("El numero no es primo");
            }
            else
            {
                Console.WriteLine("El numero es primo");
            }

            Console.ReadKey();*/


            //  6 .....Dado el vector edad = [12, 50, 23, 10, 18, 35, 41, 85, 16, 45], ordenarlos en forma ascendente


            /*int men = 0, pen = 0;
            int[] num;

            int[] vector = new int [] {12, 50, 23, 10, 18, 35, 41, 85, 16, 45};


            Console.Write("ingrese la cantidad de numeros que desea ordenar: ");
            men =int.Parse(Console.ReadLine());
            num = new int[men];

            for (int m = 0; m < men; m++)
            {
                Console.WriteLine("\nIngrese el numero {0}", m + 1);
                num [m]= int.Parse(Console.ReadLine());

            }

            for (int  i = 1; i < men; i++)
            {
                for (int a = 0; a < men - 1; a++)
                {
                    if (num[i] < num[a])
                    {
                        pen = num[i];
                        num[i] = num[a];
                        num[a] = pen;                   }
                }
            }

            Console.WriteLine("\nDe menor a mayor\n");

            for (int q = 0; q<men; q++)
            {
                Console.Write(num[q] + " - ");

            }

            Console.WriteLine();

            Console.ReadKey();*/



            /*int[] n = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
              int i, j;
              int temp; 
              int t = n.Length;

              Console.WriteLine("----------ARREGLO ORIGINAL-----------");
              Console.WriteLine("");

              foreach( int elemento in n)
              {
                  Console.Write(elemento + " - ");
              }

              Console.WriteLine("");
              Console.WriteLine("\n----------TAMAÑO DEL VECTOR-----------\n                 " + t); 
              Console.WriteLine("");


              // ----------------------------ORDENAR VECTOR----------------------//

              // for (int i = 0; i < n.Length; i ++);

              for (j = 1; j< t - 1; j ++)
              {
                  for (i = 0; i < t - j; i ++)
                  {
                      if (n[i] > n[i + 1])
                      {
                          temp = n[i];
                          n[i] = n[i + 1];
                          n[i + 1] = temp;
                      }
                  }
              }

              Console.WriteLine("----------¨ARREGLO ORDENADO  1 ¨-----------");
              Console.WriteLine("");
              foreach (int elemento in n)
              {
                  Console.Write(elemento + " - ");
              }

              Console.WriteLine("");
              Console.ReadKey();*/


            //   7....Datos los vectores edad = [12, 50, 23, 10, 18, 35, 41, 85, 16, 45]nombre =
            //["juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady"]Leer un nombre por teclado
            // definir si existe, y en caso de existir mostrar su edad de lo contrario un mensaje que el nombre no existe



            /*int[] edad = new int[] {10, 12, 16, 18, 23, 35, 41, 45, 50, 85};
            string[] nombre = new string[] { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
            bool existe = false;

            Console.WriteLine(" Escriba el nombre del cual desea informacion: ");
            string name = Console.ReadLine().ToLower().Trim();



            for ( int n = 0; n < nombre.Length; n ++)
            {
                if (name == nombre[n])
                {
                    existe = true;
                    Console.WriteLine(" Nombre: " + nombre[n] + " \n Edad: " + edad[n]);
                }
            }

            if ( existe == false)
            {
                Console.WriteLine(" El nombre de cual desea informacion, no existe. ");
            }

            Console.ReadKey();*/


            //Partiendo de los vectores anteriores buscar el menor y el mayor y presentar sus respectivos nombres con su edad.


            /*int[] edad = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
            string[] nombre = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
            Console.WriteLine("\n      Los vectores son: \n");
            Console.WriteLine("      Nombre  /  Edad");
            Console.WriteLine("");

            for (int z = 0; z <= 9; z++)
            {
                Console.WriteLine("      " + nombre[z] + "  =  " + edad[z]);
            }
            int H = edad.Length;
            for (int j = 1; j < H; j++)
            {
                for (int e = 0; e < H - j; e++)
                {
                    if (edad[e] > edad[e + 1])
                    {
                        int temp = edad[e];
                        string temp2 = nombre[e];
                        edad[e] = edad[e + 1];
                        nombre[e] = nombre[e + 1];
                        edad[e + 1] = temp;
                        nombre[e + 1] = temp2;
                    }
                }
            }
            Console.WriteLine("\n      Menor a mayor: \n");
            Console.WriteLine("      Nombre  /  Edad");
            Console.WriteLine("");


            for (int z = 0; z <= 9; z++)
            {
                Console.WriteLine("      " + nombre[z] + "  =  " + edad[z]);
            }
           
            Console.ReadLine();


            Console.ReadKey();*/


            /*Console.Write("\n ingrese el palabra:  ");
            String palindromo = (Console.ReadLine());
            char[] poliArray = palindromo.ToCharArray();
            String contrario = "";
            for (int e = poliArray.Length - 1; e >= 0; e--)
            {
                contrario += poliArray[e];
            }
            if (palindromo == contrario)
            {
                Console.WriteLine("\n    La palabra " + palindromo + ", Es palindromo");
                Console.WriteLine("\n     --------------------//--------------------\n");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n    La palabra " + palindromo + ", no es palindromo");
                Console.WriteLine("\n    Su inverso es: " + contrario);
                Console.ReadLine();
            }
           
                   
    
            Console.Clear();*/
           


        }
    }
}
    






