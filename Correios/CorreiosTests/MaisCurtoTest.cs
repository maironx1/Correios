using Correios;
using Correios.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CorreiosTests
{
    [TestClass]
    public class MaisCurtoTest
    {
        public IMaisCurto MaisCurto = new Dijkstra();
        [TestMethod]
        public void BuscaMaisCurtoDeTxt()
        {
            try
            {
                var resultado = MaisCurto.BuscaResultado(CorreiosTestHelper.Trechos, CorreiosTestHelper.Encomendas);
                CollectionAssert.AreEqual(CorreiosTestHelper.Resultado, resultado.ToArray());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
