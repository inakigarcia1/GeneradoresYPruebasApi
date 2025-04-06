using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradoresYPruebas.Dominio.ViewModel;
public class MensajeCuadradoMedio
{
    public string Mensaje { get; set; }
    public List<double> Numeros { get; set; }

    public MensajeCuadradoMedio(string mensaje, List<double> numeros)
    {
        Mensaje = mensaje;
        Numeros = numeros;
    }
}
