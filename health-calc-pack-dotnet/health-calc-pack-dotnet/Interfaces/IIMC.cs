namespace health_calc_pack_dotnet.Interfaces
{
    public interface IIMC
    {
        double Calcular(Double altura, Double peso);
        string ObterCategoriaIMC(double imc);
        bool ValidarDados(double altura, double peso);

    }
}
