using lib_entidades;

namespace lib_repositorios.Interfaces
{
    public interface IPropietariosRepositorio
    {
        List<Propietarios> Listar();
        Propietarios Guardar(Propietarios entidad);
        Propietarios Modificar(Propietarios entidad);
        Propietarios Borrar(Propietarios entidad);
    }
}