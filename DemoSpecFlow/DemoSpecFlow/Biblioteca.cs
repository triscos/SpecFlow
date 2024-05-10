namespace DemoSpecFlow
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Biblioteca
    {
        private readonly List<Libro> libros;

        private string rutaArchivo { get; set; }

        public Biblioteca() : this("biblioteca.txt")
        {
        }

        public Biblioteca(string rutaArchivo)
        {
            this.rutaArchivo = rutaArchivo;
            libros = new List<Libro>();
            CargarDatos();
        }

        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
            GuardarDatos();
        }

        public void EliminarLibro(string isbn)
        {
            var libro = libros.FirstOrDefault(l => l.ISBN == isbn);
            if (libro != null)
            {
                libros.Remove(libro);
                GuardarDatos();
            }
        }

        public List<Libro> ObtenerLibros()
        {
            return libros;
        }

        public void ActualizarLibro(Libro libroActualizado)
        {
            var libro = libros.FirstOrDefault(l => l.ISBN == libroActualizado.ISBN);
            if (libro != null)
            {
                libro.Titulo = libroActualizado.Titulo;
                libro.Autor = libroActualizado.Autor;
                GuardarDatos();
            }
        }

        private void CargarDatos()
        {
            if (File.Exists(rutaArchivo))
            {
                var lineas = File.ReadAllLines(rutaArchivo);
                foreach (var linea in lineas)
                {
                    var datos = linea.Split(',');
                    var libro = new Libro
                    {
                        Titulo = datos[0],
                        Autor = datos[1],
                        ISBN = datos[2]
                    };
                    libros.Add(libro);
                }
            }
        }

        private void GuardarDatos()
        {
            var lineas = libros.Select(l => $"{l.Titulo},{l.Autor},{l.ISBN}");
            File.WriteAllLines(rutaArchivo, lineas);
        }
    }

}
