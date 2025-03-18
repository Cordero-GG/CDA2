using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lista_Circular; 
namespace Testeos
{
    [TestClass]
    public sealed class TestListasCirculares
    {
        // Pruebas para CircularDoublyLinkedList
        [TestMethod]
        public void TestCircularDoublyLinkedList_InsertarInicio()
        {
            CircularDoublyLinkedList lista = new CircularDoublyLinkedList();
            lista.InsertarInicio(10);
            lista.InsertarInicio(20);

            Assert.AreEqual("20, 10", lista.ToString());
            Assert.AreEqual(2, lista.ObtenerTamaño());
        }

        [TestMethod]
        public void TestCircularDoublyLinkedList_InsertarFinal()
        {
            CircularDoublyLinkedList lista = new CircularDoublyLinkedList();
            lista.InsertarFinal(10);
            lista.InsertarFinal(20);

            Assert.AreEqual("10, 20", lista.ToString());
            Assert.AreEqual(2, lista.ObtenerTamaño());
        }

        [TestMethod]
        public void TestCircularDoublyLinkedList_InsertAt()
        {
            CircularDoublyLinkedList lista = new CircularDoublyLinkedList();
            lista.InsertarInicio(10);
            lista.InsertarFinal(30);
            lista.InsertAt(20, 1);

            Assert.AreEqual("10, 20, 30", lista.ToString());
            Assert.AreEqual(3, lista.ObtenerTamaño());
        }

        [TestMethod]
        public void TestCircularDoublyLinkedList_EliminarInicio()
        {
            CircularDoublyLinkedList lista = new CircularDoublyLinkedList();
            lista.InsertarInicio(10);
            lista.InsertarFinal(20);
            lista.EliminarInicio();

            Assert.AreEqual("20", lista.ToString());
            Assert.AreEqual(1, lista.ObtenerTamaño());
        }

        [TestMethod]
        public void TestCircularDoublyLinkedList_EliminarFinal()
        {
            CircularDoublyLinkedList lista = new CircularDoublyLinkedList();
            lista.InsertarInicio(10);
            lista.InsertarFinal(20);
            lista.EliminarFinal();

            Assert.AreEqual("10", lista.ToString());
            Assert.AreEqual(1, lista.ObtenerTamaño());
        }

        [TestMethod]
        public void TestCircularDoublyLinkedList_EliminarAt()
        {
            CircularDoublyLinkedList lista = new CircularDoublyLinkedList();
            lista.InsertarInicio(10);
            lista.InsertarFinal(20);
            lista.InsertarFinal(30);
            lista.EliminarAt(1);

            Assert.AreEqual("10, 30", lista.ToString());
            Assert.AreEqual(2, lista.ObtenerTamaño());
        }

        // Pruebas para CircularSinglyLinkedList
        [TestMethod]
        public void TestCircularSinglyLinkedList_IncertarInicio()
        {
            CircularSinglyLinkedList lista = new CircularSinglyLinkedList();
            lista.IncertarInicio(10);
            lista.IncertarInicio(20);

            lista.ToStirng(); // Debería imprimir "20, 10"
            Assert.AreEqual(2, lista.DarTamaño());
        }

        [TestMethod]
        public void TestCircularSinglyLinkedList_IncertarFinal()
        {
            CircularSinglyLinkedList lista = new CircularSinglyLinkedList();
            lista.IncertarFinal(10);
            lista.IncertarFinal(20);

            lista.ToStirng(); // Debería imprimir "10, 20"
            Assert.AreEqual(2, lista.DarTamaño());
        }

        [TestMethod]
        public void TestCircularSinglyLinkedList_InsertAt()
        {
            CircularSinglyLinkedList lista = new CircularSinglyLinkedList();
            lista.IncertarInicio(10);
            lista.IncertarFinal(30);
            lista.InsertAt(20, 1);

            lista.ToStirng(); // Debería imprimir "10, 20, 30"
            Assert.AreEqual(3, lista.DarTamaño());
        }

        [TestMethod]
        public void TestCircularSinglyLinkedList_EliminarInicio()
        {
            CircularSinglyLinkedList lista = new CircularSinglyLinkedList();
            lista.IncertarInicio(10);
            lista.IncertarFinal(20);
            lista.EliminarInicio();

            lista.ToStirng(); // Debería imprimir "20"
            Assert.AreEqual(1, lista.DarTamaño());
        }

        [TestMethod]
        public void TestCircularSinglyLinkedList_EliminarFinal()
        {
            CircularSinglyLinkedList lista = new CircularSinglyLinkedList();
            lista.IncertarInicio(10);
            lista.IncertarFinal(20);
            lista.EliminarFinal();

            lista.ToStirng(); // Debería imprimir "10"
            Assert.AreEqual(1, lista.DarTamaño());
        }

        [TestMethod]
        public void TestCircularSinglyLinkedList_DeleteAt()
        {
            CircularSinglyLinkedList lista = new CircularSinglyLinkedList();
            lista.IncertarInicio(10);
            lista.IncertarFinal(20);
            lista.IncertarFinal(30);
            lista.DeleteAt(1);

            lista.ToStirng(); // Debería imprimir "10, 30"
            Assert.AreEqual(2, lista.DarTamaño());
        }
    }
}