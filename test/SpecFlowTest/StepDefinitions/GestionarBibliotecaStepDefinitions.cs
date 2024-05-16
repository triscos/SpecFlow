using System;
using DemoSpecFlow;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowTest.StepDefinitions
{
    [Binding]
    public class GestionarBibliotecaStepDefinitions
    {
        private readonly FeatureContext _feature;

        public GestionarBibliotecaStepDefinitions(FeatureContext feature)
        {
            _feature = feature;
        }

        [Given(@"que el usuario ha introducido los detalles del libro")]
        public void GivenQueElUsuarioHaIntroducidoLosDetallesDelLibro(Table table)
        {
            if (_feature.ContainsKey("libro"))
            {
                _feature.Remove("libro");
            }
            _feature.Add("libro", table.CreateInstance<Libro>());
        }

        [When(@"el usuario pulsa el boton de guardar")]
        public void WhenElUsuarioPulsaElBotonDeGuardar()
        {
            var bilbioteca = _feature.Get<Biblioteca>("biblioteca");
            var libro = _feature.Get<Libro>("libro");
            bilbioteca.AgregarLibro(libro);
        }

        [Then(@"los detalles del libro con isbn ""([^""]*)""  se muestran en pantalla")]
        public void ThenLosDetallesDelLibroConIsbnSeMuestranEnPantalla(string p0)
        {
            var bilbioteca = _feature.Get<Biblioteca>("biblioteca");
            var libro = _feature.Get<Libro>("libro");
            var libros = bilbioteca.ObtenerLibros();
            libros.Should().NotBeNull();
            libros.Exists(x => x.ISBN == libro.ISBN
                            && x.Autor == libro.Autor
                            && x.Titulo == libro.Titulo)
                .Should().BeTrue();
        }

        [When(@"el usuario pulsa el boton de eliminar el libro con isbn ""([^""]*)""")]
        public void WhenElUsuarioPulsaElBotonDeEliminarElLibroConIsbn(string p0)
        {
            var bilbioteca = _feature.Get<Biblioteca>("biblioteca");
            bilbioteca.EliminarLibro(p0);
        }

        [Then(@"el libro con isbn ""([^""]*)"" no se muestra en pantalla")]
        public void ThenElLibroConIsbnNoSeMuestraEnPantalla(string p0)
        {
            var biblioteca = _feature.Get<Biblioteca>("biblioteca");
            var libros = biblioteca.ObtenerLibros();
            libros.Exists(x => x.ISBN == p0).Should().BeFalse();
        }

    }
}
