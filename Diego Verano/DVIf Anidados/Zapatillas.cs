using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DVIf_Anidados
{
    class Zapatillas
    {
        
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FreeConsole();

        public static void Ejercicio()
        {
            
            AllocConsole();

            try
            {
                Console.Write("Ingrese el precio de la zapatilla: ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal precio) || precio <= 0)
                {
                    Console.WriteLine("Precio no válido.");
                    TerminarConsola();
                    return;
                }

                Console.Write("Ingrese el tipo de zapatilla (Runing/Mountain/Urban): ");
                string tipo = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(tipo))
                {
                    Console.WriteLine("Tipo de zapatilla no válido.");
                    TerminarConsola();
                    return;
                }

                Console.Write("Ingrese la talla: ");
                if (!int.TryParse(Console.ReadLine(), out int talla) || talla <= 0)
                {
                    Console.WriteLine("Talla no válida.");
                    TerminarConsola();
                    return;
                }

                decimal porcentajeDescuento = 0;

                if (tipo.Equals("Runing", StringComparison.OrdinalIgnoreCase))
                {
                    if (talla <= 40)
                        porcentajeDescuento = 0.05m;
                    else if (talla <= 45)
                        porcentajeDescuento = 0.02m;
                    else
                        porcentajeDescuento = 0.01m;
                }
                else if (tipo.Equals("Mountain", StringComparison.OrdinalIgnoreCase))
                {
                    if (talla <= 40)
                        porcentajeDescuento = 0.10m;
                    else if (talla <= 45)
                        porcentajeDescuento = 0.05m;
                    else
                        porcentajeDescuento = 0.02m;
                }
                else if (tipo.Equals("Urban", StringComparison.OrdinalIgnoreCase))
                {
                    if (talla <= 40)
                        porcentajeDescuento = 0.15m;
                    else if (talla <= 45)
                        porcentajeDescuento = 0.12m;
                    else
                        porcentajeDescuento = 0.05m;
                }
                else
                {
                    Console.WriteLine("Tipo de zapatilla no reconocido.");
                    TerminarConsola();
                    return;
                }

                decimal descuento = precio * porcentajeDescuento;
                decimal totalPagar = precio - descuento;

                Console.WriteLine($"\nMonto comprado: {precio:C}");
                Console.WriteLine($"Descuento aplicado: {descuento:C} ({porcentajeDescuento:P})");
                Console.WriteLine($"Total a pagar: {totalPagar:C}");

                
                TerminarConsola();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error: {ex.Message}");
                TerminarConsola();
            }
        }

        private static void TerminarConsola()
        {
            Console.WriteLine("\nPresione ENTER para cerrar esta ventana...");
            Console.ReadLine(); 
            FreeConsole(); 
        }
    }
}