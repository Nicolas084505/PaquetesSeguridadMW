using Autorizacion.Abstracciones.Modelos;

namespace SeguridadMW.Abstracciones.BW
{
    public  interface IAutorizacionBW
    {
        Task<Usuario> ObtenerInformacionUsuario(Usuario usuario);

        Task<IEnumerable<Perfil>> ObtenerPerfilesxUsuario(Usuario usuario);
    }
}
