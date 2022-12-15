using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class Microrganismo
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arange - caso de prueba
            string esperado = "hola";
            //Act - invocar al metodo a probar

            string actual = "hola";

            //Assert - verifico que el resultado sea el esperado
            Assert.AreEqual(esperado, actual);
        }
        [TestMethod]
        [ExpectedException(typeof("nombre de la exception"))]
        public void TieneException()
        {
            //arange - caso de prueba

            //Act - invocar al metodo a probar



            //Assert - verifico que el resultado sea el esperado
        }
    }
}
