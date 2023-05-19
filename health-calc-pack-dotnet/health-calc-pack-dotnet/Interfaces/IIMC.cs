using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_calc_pack_dotnet.Interfaces
{
    public interface IIMC
    {
        double Calcular(Double altura, Double peso);
        string ObterCategoriaIMC(double imc);
        bool ValidarDados(double altura, double peso);

    }
}
