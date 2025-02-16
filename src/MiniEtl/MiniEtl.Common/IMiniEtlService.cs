

namespace MiniEtl.Common
{
    /// <summary>
    /// Actúa como fachada para los módulos, permitiendo así mayor modularidad y facilidad
    /// para la aplicación cliente. El cliente puede simplemente registrar en su contenedor
    /// IoC el módulo que le interesa utilizar en su negocio.
    /// </summary>
    public interface IMiniEtlService<T>
    {
        T Extract(string sourceConnection);
    }
}
