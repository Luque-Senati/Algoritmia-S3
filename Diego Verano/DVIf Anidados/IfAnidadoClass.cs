using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DVIf_Anidados
{
    internal class IfAnidadoClass
    {
        static void Main()
        {
            try
            {
                Console.Write("Ingrese el precio de la zapatilla: ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal precio) || precio <= 0)
                {
                    Console.WriteLine("Precio no válido.");
                    return;
                }

                Console.Write("Ingrese el tipo de zapatilla (Runing/Mountain/Urban): ");
                string tipo = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(tipo))
                {
                    Console.WriteLine("Tipo de zapatilla no válido.");
                    return;
                }
                Console.Write("Ingrese la talla: ");
                if (!int.TryParse(Console.ReadLine(), out int talla) || talla <= 0)
                {
                    Console.WriteLine("Talla no válida.");
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
                    {
                        Console.WriteLine("Tipo de zapatilla no reconocido.");
                        return;
                    }

                    decimal descuento = precio * porcentajeDescuento;
                    decimal totalPagar = precio - descuento;

                    Console.WriteLine($"\nMonto comprado: {precio:C}");
                    Console.WriteLine($"Descuento aplicado: {descuento:C} ({porcentajeDescuento:P})");
                    Console.WriteLine($"Total a pagar: {totalPagar:C}");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error: {ex.Message}");
            }
        }
     }
}


