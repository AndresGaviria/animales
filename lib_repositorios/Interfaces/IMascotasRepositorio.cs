using lib_entidades;

namespace lib_repositorios.Interfaces
{
    public interface IMascotasRepositorio
    {
        List<Mascotas> Listar();
        Mascotas Guardar(Mascotas entidad);
        Mascotas Modificar(Mascotas entidad);
        Mascotas Borrar(Mascotas entidad);
    }
}