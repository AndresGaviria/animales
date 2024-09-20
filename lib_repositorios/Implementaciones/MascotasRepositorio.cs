using lib_entidades;
using lib_repositorios.Interfaces;

namespace lib_repositorios.Implementaciones
{
    public class MascotasRepositorio : IMascotasRepositorio
    {
        private Conexion? conexion = null;

        public MascotasRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Mascotas> Listar()
        {
            return conexion!.Listar<Mascotas>();
        }

        public Mascotas Guardar(Mascotas entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Mascotas Modificar(Mascotas entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Mascotas Borrar(Mascotas entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}