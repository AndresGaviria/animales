using lib_entidades;
using lib_repositorios.Interfaces;

namespace lib_repositorios.Implementaciones
{
    public class PropietariosRepositorio : IPropietariosRepositorio
    {
        private Conexion? conexion = null;

        public PropietariosRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Propietarios> Listar()
        {
            return conexion!.Listar<Propietarios>();
        }

        public Propietarios Guardar(Propietarios entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Propietarios Modificar(Propietarios entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Propietarios Borrar(Propietarios entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}