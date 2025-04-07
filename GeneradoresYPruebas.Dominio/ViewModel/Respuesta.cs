using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradoresYPruebas.Dominio.ViewModel;
public class Respuesta
{
    public string Mensaje { get; set; }
    public List<double> Numeros { get; set; }

    public Respuesta(List<double> numeros, string mensaje = "")
    {
        Mensaje = mensaje;
        Numeros = numeros;
    }
}
