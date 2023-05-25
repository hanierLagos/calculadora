using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, resultado;
            char operador, volver;
            do
            {
                Console.WriteLine("Ingrese el primer numero");
                numero1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                numero2 = double.Parse(Console.ReadLine());
                do {
                    Console.WriteLine("Ingrese el operador (+ , - , / , * )");
                    operador = char.Parse(Console.ReadLine());
                    switch (operador)
                    {
                        case '+':
                            resultado = numero1 + numero2;
                            Console.WriteLine("El resultado de la suma es: " + resultado);
                            break;
                        case '-':
                            resultado = numero1 - numero2;
                            Console.WriteLine("El resultado de la resta es: " + resultado);
                            break;
                        case '*':
                            resultado = numero1 * numero2;
                            Console.WriteLine("El resultado de la multiplicacion es: " + resultado);
                            break;
                        case '/':
                            if (numero2 == 0)
                                Console.WriteLine("No se puede dividir entre cero");
                            else
                            {
                                resultado = numero1 / numero2;
                                Console.WriteLine("El resultado de la division es: " + resultado);
                            }
                            break;
                        default:
                            Console.WriteLine("Operador invalido");
                            break;
                    }
                    Console.ReadLine();
                } while (!(operador == '+' || operador == '-' || operador == '*' || operador == '/'));
                Console.WriteLine("Desea volver a ejecutar el programa S o N ");
                volver = char.Parse(Console.ReadLine());
            } while (volver == 'S' || volver == 's');
            Console.WriteLine("Gracias por su opinion");
            Console.ReadLine();

           

        }
    }
}
