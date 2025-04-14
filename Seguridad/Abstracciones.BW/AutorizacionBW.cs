using Autorizacion.Abstracciones.DA;
using Autorizacion.Abstracciones.Modelos;
using SeguridadMW.Abstracciones.BW;

namespace SeguridadMW.BW
{
    public class AutorizacionBW : IAutorizacionBW
    {
        private ISeguridadDA _seguridadDA;

        public AutorizacionBW(ISeguridadDA seguridadDA)
        {
            _seguridadDA = seguridadDA;
        }

        public async Task<Usuario> ObtenerInformacionUsuario(Usuario usuario)
        {
            return await _seguridadDA.ObtenerInformacionUsuario(usuario);
        }

        public async Task<IEnumerable<Perfil>> ObtenerPerfilesxUsuario(Usuario usuario)
        {
            return await _seguridadDA.ObtenerPerfilesxUsuario(usuario);

        }
    }
}
