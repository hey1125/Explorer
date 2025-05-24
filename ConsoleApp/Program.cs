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
                // Aquí iría la lógica para añadir un producto
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