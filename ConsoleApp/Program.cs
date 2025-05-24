using BusinessLogic;
using Entities;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al gestor de productos Dummy");
        Console.WriteLine("Por favor, elige una opción:");
        Console.WriteLine("1. Añadir producto");
        Console.WriteLine("2. Listar productos");
        var option = Console.ReadLine();
        switch(option)
        {
            case "1":
                Console.WriteLine("Añadiendo producto...");
                Console.WriteLine("Por favor, introduce id del producto:");
                var id = int.Parse(Console.ReadLine());
                Console.WriteLine("Por favor, introduce nombre del producto:");
                var name = Console.ReadLine();
                Console.WriteLine("Por favor, introduce stock del producto:");
                var stock = int.Parse(Console.ReadLine());
                Console.WriteLine("Por favor, introduce precio del producto:");
                var price = double.Parse(Console.ReadLine());

                var myProduct = new Product()
                {
                    id = id,
                    name = name,
                    stock = stock,
                    price = price

                };
                var pm = new ProductManager();
                try { 
                    pm.AddProduct(myProduct);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                break;
            case "2":
                Console.WriteLine("Listando productos...");
                // Aquí iría la lógica para listar los productos
                break;
                case "9":
                    Console.WriteLine("Saliendo del programa...");
                break;
            default:
                Console.WriteLine("Opción no válida. Por favor, elige 1 o 2.");
                break;
        }

    }
}