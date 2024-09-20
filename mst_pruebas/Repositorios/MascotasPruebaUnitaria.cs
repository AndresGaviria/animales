using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class MascotasPruebaUnitaria
    {
        private IMascotasRepositorio? iRepositorio = null;

        public MascotasPruebaUnitaria()
        {
            var conexion = new Conexion();
            conexion.StringConnection = "server=localhost;database=db_animales;uid=sa;pwd=Clas3sPrO2024_!;TrustServerCertificate=true;";
            iRepositorio = new MascotasRepositorio(conexion);
        }

        [TestMethod]
        public void Ejecutar()
        {
            Listar();
        }

        private void Listar()
        {
            var lista = iRepositorio!.Listar();
            Assert.IsTrue(lista.Count > 0);
        }
    }
}