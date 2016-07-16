using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ejemplo.Tests
{
    [TestClass]
    public class Products
    {
        [TestMethod]
        public void ConsultarProduntosNegros()
        {
            //Definir el escenario de la prueba
            string miColor = "Black";
            //Repositorio
            var repositorio = new Ejemplo.BL.Repositorios.ProductRepository();
            //Invocar al metodo correspondiente
            var resultado = repositorio;
        }
    }
}
