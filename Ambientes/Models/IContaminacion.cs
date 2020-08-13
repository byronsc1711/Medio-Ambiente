

namespace AfectacionMedioAmbiental.Models
{
    public interface IContaminacion
    {
        string Desechar(string desechosSolidos);
        string Extraer(string gasesNaturales);
        string Tratar(string aguasResiduales);

    }
}
