namespace DemoSpecFlow
{
    static class Program
    {
        static void Main(string[] args)
        {
            var biblioteca = new Biblioteca();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("***** MENÚ *************");
            Console.WriteLine("1. Agregar libro");
            Console.WriteLine("2. Actualizar libro");
            Console.WriteLine("3. Eliminar libro");
            Console.WriteLine("4. Ver todos los libros");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("********************");

            while (true)
            {                
                var opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el título del libro: ");
                        var titulo = Console.ReadLine();
                        Console.Write("Ingrese el autor del libro: ");
                        var autor = Console.ReadLine();
                        Console.Write("Ingrese el ISBN del libro: ");
                        var isbn = Console.ReadLine();
                        var libroNuevo = new Libro { Titulo = titulo, Autor = autor, ISBN = isbn };
                        biblioteca.AgregarLibro(libroNuevo);
                        break;
                    case "2":
                        Console.Write("Ingrese el ISBN del libro a actualizar: ");
                        isbn = Console.ReadLine();
                        Console.Write("Ingrese el nuevo título del libro: ");
                        titulo = Console.ReadLine();
                        Console.Write("Ingrese el nuevo autor del libro: ");
                        autor = Console.ReadLine();
                        var libroActualizado = new Libro { Titulo = titulo, Autor = autor, ISBN = isbn };
                        biblioteca.ActualizarLibro(libroActualizado);
                        break;
                    case "3":
                        Console.Write("Ingrese el ISBN del libro a eliminar: ");
                        isbn = Console.ReadLine();
                        biblioteca.EliminarLibro(isbn);
                        break;
                    case "4":
                        var libros = biblioteca.ObtenerLibros();
                        foreach (var libro in libros)
                        {
                            Console.WriteLine($"Titulo: {libro.Titulo}, Autor: {libro.Autor}, ISBN: {libro.ISBN}");
                        }
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }
    }
}