using System;
using TechTalk.SpecFlow;

namespace DemoSpecFlow.Test.StepDefinitions
{
    [Binding]
    public class CRUDLIBROSStepDefinitions
    {
        private Biblioteca biblioteca;
        private Libro libro;

        public CRUDLIBROSStepDefinitions()
        {
            biblioteca = new Biblioteca();
        }

        [Given(@"El libro con el siguiente titulo ""([^""]*)"", autor ""([^""]*)"" y isbn ""([^""]*)""")]
        public void GivenElLibroConElSiguienteTituloAutorYIsbn(string titulo, string autor, string isbn)
        {            
            libro = new Libro() { Titulo=titulo, Autor=autor, ISBN=isbn};           
        }

        [When(@"Inserto el libro a la biblioteca")]
        public void WhenInsertoElLibroALaBiblioteca()
        {
            biblioteca.AgregarLibro(libro);
        }

        [Then(@"El libro con el titulo ""([^""]*)"" debería ser añadido correctamente")]
        public void ThenElLibroConElTituloDeberiaSerAnadidoCorrectamente(string p0)
        {
            var libros = biblioteca.ObtenerLibros();
            libros.Exists(x => x.ISBN == p0).Should().BeTrue();
        }
    }
}
