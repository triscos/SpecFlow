using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DemoSpecFlow.Test.StepDefinitions
{
    [Binding]
    public class ValidacionDatosEntradaStepDefinitions
    {
        [Given(@"Dado un libro con los datos de entrada")]
        public void GivenDadoUnLibroConLosDatosDeEntrada(Table table)
        {
           var libro = table.CreateInstance<Libro>();
            //libro.
        }

        [When(@"Valido los datos de entrada")]
        public void WhenValidoLosDatosDeEntrada()
        {
            throw new PendingStepException();
        }

        [Then(@"Los datos de entrada son validos")]
        public void ThenLosDatosDeEntradaSonValidos()
        {
            throw new PendingStepException();
        }
    }
}
