using DemoSpecFlow;

namespace SpecFlowTest.Hook
{
    [Binding]
    public class GestionarBibliotecaHook
    {

        private const string RUTA_ARCHIVO = "biblioteca_test.txt";
        private const string BIBLIOTECA = "biblioteca";

        [BeforeFeature("GestionarBiblioteca")]
        public static void BeforeFeature(FeatureContext _featureContext)
        {
            var biblioteca = new Biblioteca(RUTA_ARCHIVO);
            _featureContext.Add(BIBLIOTECA, biblioteca);
        }

        [AfterFeature("GestionarBiblioteca")]
        public static void AfterFeature(FeatureContext _featureContext)
        {
            _featureContext.Remove(BIBLIOTECA);
            File.Delete(RUTA_ARCHIVO);
        }
    }
}
